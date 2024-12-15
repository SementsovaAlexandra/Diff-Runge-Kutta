using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Curs2
{
    internal class Problem
    {
        public double[,] A { get; set; }
        public double[] V { get; set; }
        public double T0 { get; set; }
        public double T1 { get; set; }
        public double Step { get; set; }

        public Problem(double[,] a, double[] v, double t0, double t1, double step)
        {
            A = a;
            V = v;
            T0 = t0;
            T1 = t1;
            Step = step;
        }

        public static Problem Random(int n)
        {
            var random = new Random();
            var a = new double[n, n];
            var v = new double[n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    a[r, c] = (double)(random.Next(-20, 21));
                }
                v[r] = (double)(random.Next(-20, 21));
            }

            return new Problem(a, v, 0, 1, 0.01);
        }

        public SolutionResponse RungeKuttaSolutionPart(SolutionRequest req, double[] k)
        {
            var res = new SolutionResponse(new double[req.RowCount], req.StartRow, req.KNum);
            for (int row = 0; row < req.RowCount; row++)
            {
                k[row] = Step * EvaluateEquation(req.X, row);
                double c = req.KNum < 3 ? 0.5 : 1.0;
                res.X[row] = req.X[row] + 0.5 * k[row];
            }

            return res;
        }
        public SolutionResponse RungeKuttaSolutionLast(SolutionRequest req, double[] initialX, List<double[]> kAll)
        {
            var res = new SolutionResponse(new double[req.RowCount], req.StartRow, req.KNum);
            var k = new double[req.RowCount];
            for (int row = 0; row < req.RowCount; row++)
            {
                k[row] = Step * EvaluateEquation(req.X, row);
            }
            kAll.Append(k);

            for (int row = 0; row < req.RowCount; row++)
            {
                // res.X[j] = (k1[j] + 2 * k2[j] + 2 * k3[j] + k4[j]) / 6.0;
                res.X[row] = 0;
                for (int num = 0; num < kAll.Count; row++)
                {
                    double c = num == 1 || num == 2 ? 2.0 : 1.0;
                    res.X[row] += kAll[num][row] * c;
                }
                res.X[row] /= 6.0;
            }
            return res;
        }

        private double EvaluateEquation(double[] x, int row)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += A[row, i] * x[i];
            }
            return sum;
        }

        public bool IsValid()
        {
            return T0 < T1 && Step != 0 && A.Length > 1 && V.Length * V.Length == A.Length;
        }
    }
}

/*

using System;
using System.Collections.Generic;

public class RungeKuttaLinear
{
    public static void Main(string[] args)
    {
        double[,] A = {
            { 0.5, -0.1, 0.2 },
            { -0.3, 0.4, 0.1 },
            { 0.2, -0.2, 0.5 }
        };
        
        double[] initialConditions = { 1, 0, 0 }; // начальные условия для x1, x2, x3
        double t0 = 0;
        double tf = 10;
        double stepSize = 0.01;

        double[] result = RungeKutta4(A, initialConditions, t0, tf, stepSize);
        Console.WriteLine("Результат: ");
        foreach (var value in result)
        {
            Console.WriteLine(value);
        }
    }

    public static double[] RungeKutta4(double[,] A, double[] y0, double t0, double tf, double h)
    {
        int n = y0.Length;
        int steps = (int)((tf - t0) / h);
        double[] y = new double[n];
        Array.Copy(y0, y, n);

        for (int i = 0; i < steps; i++)
        {
            double t = t0 + i * h;
            double[] k1 = new double[n];
            double[] k2 = new double[n];
            double[] k3 = new double[n];
            double[] k4 = new double[n];
            double[] yTemp = new double[n];

            for (int j = 0; j < n; j++)
            {
                k1[j] = h * EvaluateEquation(A, y, j);
            }

            for (int j = 0; j < n; j++)
            {
                yTemp[j] = y[j] + 0.5 * k1[j];
            }

            for (int j = 0; j < n; j++)
            {
                k2[j] = h * EvaluateEquation(A, yTemp, j);
            }

            for (int j = 0; j < n; j++)
            {
                yTemp[j] = y[j] + 0.5 * k2[j];
            }

            for (int j = 0; j < n; j++)
            {
                k3[j] = h * EvaluateEquation(A, yTemp, j);
            }

            for (int j = 0; j < n; j++)
            {
                yTemp[j] = y[j] + k3[j];
            }

            for (int j = 0; j < n; j++)
            {
                k4[j] = h * EvaluateEquation(A, yTemp, j);
            }

            for (int j = 0; j < n; j++)
            {
                y[j] += (k1[j] + 2 * k2[j] + 2 * k3[j] + k4[j]) / 6.0;
            }
        }

        return y;
    }

    public static double EvaluateEquation(double[,] A, double[] y, int j)
    {
        double sum = 0;
        for (int i = 0; i < y.Length; i++)
        {
            sum += A[j, i] * y[i];
        }
        return sum;
    }
}

 
 
 */
