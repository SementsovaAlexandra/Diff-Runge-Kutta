using System.Net.Sockets;

namespace Curs2
{
    internal class SolverClient
    {
        private TcpClient client;
        private NetworkStream stream;
        private Problem problem;
        public int StartRow;
        public int RowCount;

        public SolverClient(string addr, int port, Problem problem, int startRow, int rowCount)
        {
            client = new TcpClient(addr, port);
            stream = client.GetStream();
            this.problem = problem;
            StartRow = startRow;
            RowCount = rowCount;
        }

        ~SolverClient()
        {
            stream.Close();
            client.Close();
        }

        public void SendProblem()
        {
            Console.WriteLine($"Sending problem");
            Transport<Problem>.Send(stream, problem);
        }

        public SolutionResponse SendSolutionRequest(SolutionRequest req)
        {
            Console.WriteLine($"Sending solution request task {StartRow},{RowCount}");
            Transport<SolutionRequest>.Send(stream, req);
            Console.WriteLine($"Reading solution response {StartRow},{RowCount}");
            var resp = Transport<SolutionResponse>.Receive(stream);
            Console.WriteLine($"Read solution response {resp.StartRow},{resp.X.Length}");
            return resp;
        }
    }
}
