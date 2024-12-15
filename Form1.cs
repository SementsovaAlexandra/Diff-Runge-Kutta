using System.ComponentModel;
using System.Data;

namespace Curs2
{
    public partial class Form1 : Form
    {
        const string workersFile = "workers";

        private int n;
        private DataTable? dataA;
        private DataTable? dataV;
        private DataTable? dataSolution;
        private BackgroundWorker backgroundWorker;

        public Form1()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_Completed;
        }

        private void NewMatrix(int size)
        {
            n = size;
            dataA = new DataTable();
            dataV = new DataTable();
            dataSolution = new DataTable();

            for (int c = 0; c < n; c++)
            {
                dataA.Columns.Add("");
                dataSolution.Columns.Add("");
            }

            dataV.Columns.Add("");

            for (int r = 0; r < n; r++)
            {
                var rowA = dataA.NewRow();
                for (int c = 0; c < n; c++)
                {
                    rowA[c] = (double)0;
                }
                dataA.Rows.Add(rowA);

                var rowV = dataV.NewRow();
                rowV[0] = (double)0;
                dataV.Rows.Add(rowV);
            }


            var rowX = dataSolution.NewRow();
            for (int c = 0; c < n; c++)
            {
                rowX[c] = (double)0;
            }
            dataSolution.Rows.Add(rowX);

            viewA.DataSource = dataA;
            viewV.DataSource = dataV;
            viewSolution.DataSource = dataSolution;

            startButton.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            NewMatrix((int)inputN.Value);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            NewMatrix((int)inputN.Value);
            UpdateProblem(Problem.Random((int)inputN.Value));
        }

        private Problem FillProblem()
        {
            var a = new double[n, n];
            var v = new double[n];
            double step, t0, t1;
            if (!double.TryParse(inputStep.Text, out step))
                step = 0.01;
            if (!double.TryParse(inputT0.Text, out t0))
                t0 = 0.0;
            if (!double.TryParse(inputT1.Text, out t1))
                t1 = 1.0;

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    a[r, c] = GetDouble(dataA!.Rows[r][c]);
                }
                v[r] = GetDouble(dataV!.Rows[r][0]);
            }

            return new Problem(a, v, t0, t1, step);
        }

        private void UpdateProblem(Problem problem)
        {
            for (int r = 0; r < problem.V.Length; r++)
            {
                dataV!.Rows[r][0] = problem.V[r];
                for (int c = 0; c < problem.V.Length; c++)
                {
                    dataA!.Rows[r][c] = problem.A[r,c];
                }
                inputT0.Text = problem.T0.ToString();
                inputT1.Text = problem.T1.ToString();
                inputStep.Text = problem.Step.ToString();
            }
            progressSolution.Value = 0;
        }

        private void UpdateSolution(SolutionRequest solution)
        {
            for (int r = 0; r < solution.X.Length; r++)
            {
                var ind = r + solution.StartRow;
                var x = solution.X[ind];
                dataSolution!.Rows[0][ind] = x.ToString("F10");
            }
        }

        static private double GetDouble(object? cell)
        {
            if (cell is null)
                return 0;
            if (cell is double)
                return (double)cell;

            double res;
            if (!double.TryParse(cell as string, out res))
                return 0;

            return res;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return; //backgroundWorker.CancelAsync();
            else
            {
                var problem = FillProblem();
                if (!problem.IsValid())
                {
                    MessageBox.Show("Неверные параметры задачи");
                    return;
                }
                backgroundWorker.RunWorkerAsync(problem);
            }
        }

        private void inputStep_TextChanged(object sender, EventArgs e)
        {
            double step;
            if (!double.TryParse(inputStep.Text, out step))
            {
                inputStep.Text = "0.01";
            }
        }

        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (sender as BackgroundWorker)!;

            try
            {
                var problem = (e.Argument as Problem)!;
                var solver = new Solver(workersFile);
                solver.Solve(problem, (prog, current) => {
                    worker.ReportProgress(prog, current);
                });
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            var xs = (SolutionRequest)e.UserState!;
            UpdateSolution(xs);
            progressSolution.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_Completed(object? sender, RunWorkerCompletedEventArgs e)
        {
            progressSolution.Value = 0;
        }
        
    }
}
