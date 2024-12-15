using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace Curs2
{
    internal class SolverServer
    {
        public static void Serve(int port)
        {
            TcpListener server = new TcpListener(IPAddress.Any, port);
            try
            {
                server.Start();
                Console.WriteLine($"Server is listening on :{port}");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                server.Stop();
            }
        }

        private static void HandleClient(TcpClient client)
        {
            try
            {
                Console.WriteLine($"Client connected: {client.Client.RemoteEndPoint}");

                NetworkStream stream = client.GetStream();

                var problem = Transport<Problem>.Receive(stream);
                Console.WriteLine($"Received problem");

                while (true)
                {
                    var kAll = new List<double[]>();
                    for (int n = 1; n <= 4; n++)
                    {
                        var sr = Transport<SolutionRequest>.Receive(stream);
                        Console.WriteLine($"Received task part {sr.KNum}, T={sr.T}");
                        if (sr.KNum != n)
                        {
                            throw new Exception($"Invalid k sequence: {sr.KNum}, expected: {n}");
                        }

                        var k = new double[sr.RowCount];
                        var sw = Stopwatch.StartNew();
                        var resp = problem.RungeKuttaSolutionPart(sr, k);
                        sw.Stop();
                        if (n < 4)
                        {
                            kAll.Append(k);
                        }

                        Console.WriteLine($"Calculated part {sr.KNum + 1} in {sw.Elapsed}");
                        Console.WriteLine($"Sending solution {resp.StartRow},{resp.X.Length}");
                        Transport<SolutionResponse>.Send(stream, resp);
                        Console.WriteLine($"Sent solution {resp.StartRow},{resp.X.Length}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Client error: {ex.Message}");
            }
            finally
            {
                client.Close();
                Console.WriteLine("Client disconnected");
            }
        }

    }
}
