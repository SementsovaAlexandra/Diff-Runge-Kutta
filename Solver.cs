namespace Curs2
{
    internal class Solver
    {
        public delegate void ReportProgress(int progress, SolutionRequest current);

        private List<SolverClient> SolverClients = new List<SolverClient>();
        private List<(string, int)> WorkerAddrs;

        public Solver(string workersFileName)
        {
            WorkerAddrs = new List<(string, int)>();
            string[] lines = File.ReadAllLines(workersFileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2 && int.TryParse(parts[1], out int port))
                {
                    WorkerAddrs.Add((parts[0], port));
                }
            }
            if (WorkerAddrs.Count < 1)
            {
                throw new Exception("Insufficient workers");
            }
        }

        ~Solver() {
            SolverClients.Clear();
        }

        public SolutionRequest Solve(Problem problem, ReportProgress? reporter = null)
        {
            Init(problem);
            var x = new double[problem.V.Length];
            Array.Copy(problem.V, x, problem.V.Length);
            var current = new SolutionRequest(x);
            var firstTime = true;
            for (var t = problem.T0; t < problem.T1; t+= problem.Step) {
                if (!(reporter is null))
                {
                    reporter((int)( (t - problem.T0)/(problem.T1 - problem.T0)*100 ), current);
                }
                for (var k = 1; k <= 4; k++)
                {
                    current.KNum = k;
                    current = FullStep(current, firstTime);
                    firstTime = false;
                }
            }

            return current;
        }

        private void Init(Problem problem)
        {
            var partSize = problem.V.Length / WorkerAddrs.Count;
            int i = 0;
            foreach (var w in WorkerAddrs)
            {
                int startRow = i * partSize;
                int rowCount = i == WorkerAddrs.Count-1? problem.V.Length - startRow : partSize;
                var client = new SolverClient(w.Item1, w.Item2, problem, startRow, rowCount);
                SolverClients.Add(client);
                i++;
            }
        }

        private SolutionRequest FullStep(SolutionRequest req, bool sendProblem = false)
        {
            var threads = new List<Thread>();
            var solutions = new SolutionResponse[SolverClients.Count];

            int i = 0;
            foreach (var client in SolverClients)
            {
                var ind = i;
                var cl = client;
                var thread = new Thread(() =>
                {
                    if (sendProblem)
                        cl.SendProblem();
                    var partReq = req.Partial(cl.StartRow, cl.RowCount, req.T);
                    var solution = cl.SendSolutionRequest(partReq);
                    lock(solutions)
                    {
                        solutions[ind] = solution;
                    }
                });
                threads.Add(thread);
                thread.Start();
                i++;
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            return SolutionRequest.Combine(solutions);
        }
    }
}
