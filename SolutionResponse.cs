using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    internal class SolutionResponse
    {
        // Partial variables from StartRow relative to full variables (SolutionRequest).
        // RowCount is X.Length.
        public double[] X;
        // What k number is calculated, 1-4
        public int KNum = 0;
        public int StartRow { get; set; }

        public SolutionResponse(double[] x, int startRow, int knum)
        {
            X = x;
            StartRow = startRow;
            KNum = knum;
        }
    }
}
