using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    internal class SolutionRequest
    {
        // Current full variables
        public double[] X;
        // What k number to calculate, 1-4
        public int KNum { get; set; } = 0;

        // Requested range of variables: start index
        public int StartRow { get; set; }
        // Requested range of variables: number of variables
        public int RowCount { get; set; }
        // Current time point
        public double T { get; set; }

        public SolutionRequest(double[] x)
        {
            X = x;
            StartRow = 0;
            RowCount = 0;
        }

        // Create a copy of SolutionRequest with StartRow, RowCount and T set.
        public SolutionRequest Partial(int startRow, int rowCount, double t)
        {
            var x = new double[X.Length];
            Array.Copy(X, x, X.Length);
            var res = new SolutionRequest(X);
            res.StartRow = startRow;
            res.RowCount = rowCount;
            res.T = t;
            res.KNum = KNum;
            return res;
        }

        public static SolutionRequest Combine(SolutionResponse[] solutions)
        {
            int n = 0, kn = 0;
            foreach (var s in solutions)
            {
                kn = s.KNum;
                n += s.X.Length;
            }
            var x = new double[n];

            foreach (var s in solutions)
            {
                Array.Copy(s.X, 0, x, s.StartRow, s.X.Length);
            }

            var res = new SolutionRequest(x);
            res.KNum = kn;
            return res;
        }
    }
}
