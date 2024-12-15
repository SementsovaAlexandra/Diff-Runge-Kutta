using System.ComponentModel;

namespace Curs2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputT0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputT1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputStep = new System.Windows.Forms.TextBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.matrixPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewV = new System.Windows.Forms.DataGridView();
            this.viewA = new System.Windows.Forms.DataGridView();
            this.solutionPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewSolution = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressSolution = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).BeginInit();
            this.matrixPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewA)).BeginInit();
            this.solutionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputT0);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.inputT1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.inputStep);
            this.panel1.Controls.Add(this.randomButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.inputN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 46);
            this.panel1.TabIndex = 0;
            // 
            // inputT0
            // 
            this.inputT0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputT0.Location = new System.Drawing.Point(794, 9);
            this.inputT0.Name = "inputT0";
            this.inputT0.Size = new System.Drawing.Size(50, 27);
            this.inputT0.TabIndex = 12;
            this.inputT0.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(766, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "t0";
            // 
            // inputT1
            // 
            this.inputT1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputT1.Location = new System.Drawing.Point(888, 9);
            this.inputT1.Name = "inputT1";
            this.inputT1.Size = new System.Drawing.Size(50, 27);
            this.inputT1.TabIndex = 10;
            this.inputT1.Text = "1";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(860, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "t1";
            // 
            // inputStep
            // 
            this.inputStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputStep.Location = new System.Drawing.Point(975, 9);
            this.inputStep.Name = "inputStep";
            this.inputStep.Size = new System.Drawing.Size(71, 27);
            this.inputStep.TabIndex = 8;
            this.inputStep.Text = "0.01";
            this.inputStep.TextChanged += new System.EventHandler(this.inputStep_TextChanged);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(429, 7);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(174, 29);
            this.randomButton.TabIndex = 7;
            this.randomButton.Text = "Случайная матрица";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(1052, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 29);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Вычислить решение";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(758, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 33);
            this.panel2.TabIndex = 5;
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(156, 9);
            this.inputN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(96, 27);
            this.inputN.TabIndex = 1;
            this.inputN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(944, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "шаг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер матрицы A";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(258, 6);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(149, 29);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать матрицу";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // matrixPanel
            // 
            this.matrixPanel.Controls.Add(this.label5);
            this.matrixPanel.Controls.Add(this.label4);
            this.matrixPanel.Controls.Add(this.viewV);
            this.matrixPanel.Controls.Add(this.viewA);
            this.matrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixPanel.Location = new System.Drawing.Point(0, 46);
            this.matrixPanel.Name = "matrixPanel";
            this.matrixPanel.Size = new System.Drawing.Size(1228, 675);
            this.matrixPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1072, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "v (нач. значения)";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "A (матрица коэффициентов)";
            this.toolTip1.SetToolTip(this.label4, "Пример системы дифф. уравнений:\r\n\r\ndx1/dt ​​= A11​⋅x1​+A12​⋅x2​+A13​⋅x3​\r\ndx2/dt " +
        "​​= A21​⋅x1​+A22​⋅x2​+A23​⋅x3​\r\ndx3/dt ​​= A31​⋅x1​+A32​⋅x2​+A33​⋅x3​\r\n");
            // 
            // viewV
            // 
            this.viewV.AllowUserToAddRows = false;
            this.viewV.AllowUserToDeleteRows = false;
            this.viewV.AllowUserToResizeColumns = false;
            this.viewV.AllowUserToResizeRows = false;
            this.viewV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewV.ColumnHeadersVisible = false;
            this.viewV.Location = new System.Drawing.Point(1072, 29);
            this.viewV.Name = "viewV";
            this.viewV.RowHeadersVisible = false;
            this.viewV.RowHeadersWidth = 51;
            this.viewV.RowTemplate.Height = 29;
            this.viewV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.viewV.Size = new System.Drawing.Size(153, 539);
            this.viewV.TabIndex = 1;
            // 
            // viewA
            // 
            this.viewA.AllowUserToAddRows = false;
            this.viewA.AllowUserToDeleteRows = false;
            this.viewA.AllowUserToResizeColumns = false;
            this.viewA.AllowUserToResizeRows = false;
            this.viewA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewA.ColumnHeadersVisible = false;
            this.viewA.Location = new System.Drawing.Point(3, 29);
            this.viewA.Name = "viewA";
            this.viewA.RowHeadersVisible = false;
            this.viewA.RowHeadersWidth = 51;
            this.viewA.RowTemplate.Height = 29;
            this.viewA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.viewA.Size = new System.Drawing.Size(1063, 539);
            this.viewA.TabIndex = 0;
            // 
            // solutionPanel
            // 
            this.solutionPanel.Controls.Add(this.progressSolution);
            this.solutionPanel.Controls.Add(this.label6);
            this.solutionPanel.Controls.Add(this.label3);
            this.solutionPanel.Controls.Add(this.viewSolution);
            this.solutionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.solutionPanel.Location = new System.Drawing.Point(0, 620);
            this.solutionPanel.Name = "solutionPanel";
            this.solutionPanel.Size = new System.Drawing.Size(1228, 101);
            this.solutionPanel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "vi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Решение";
            // 
            // viewSolution
            // 
            this.viewSolution.AllowUserToAddRows = false;
            this.viewSolution.AllowUserToDeleteRows = false;
            this.viewSolution.AllowUserToResizeColumns = false;
            this.viewSolution.AllowUserToResizeRows = false;
            this.viewSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSolution.ColumnHeadersVisible = false;
            this.viewSolution.Location = new System.Drawing.Point(80, 16);
            this.viewSolution.Name = "viewSolution";
            this.viewSolution.ReadOnly = true;
            this.viewSolution.RowHeadersVisible = false;
            this.viewSolution.RowHeadersWidth = 51;
            this.viewSolution.RowTemplate.Height = 29;
            this.viewSolution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.viewSolution.Size = new System.Drawing.Size(1145, 55);
            this.viewSolution.TabIndex = 0;
            // 
            // progressSolution
            // 
            this.progressSolution.Location = new System.Drawing.Point(82, 73);
            this.progressSolution.Name = "progressSolution";
            this.progressSolution.Size = new System.Drawing.Size(1143, 25);
            this.progressSolution.Step = 1;
            this.progressSolution.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 721);
            this.Controls.Add(this.solutionPanel);
            this.Controls.Add(this.matrixPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "Form1";
            this.Text = "Решение системы дифф. уравнений методом Рунге-Кутта";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).EndInit();
            this.matrixPanel.ResumeLayout(false);
            this.matrixPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewA)).EndInit();
            this.solutionPanel.ResumeLayout(false);
            this.solutionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button createButton;
        private Label label1;
        private NumericUpDown inputN;
        private Panel matrixPanel;
        private DataGridView viewV;
        private DataGridView viewA;
        private Panel solutionPanel;
        private Label label3;
        private DataGridView viewSolution;
        private Label label5;
        private Label label4;
        private Button startButton;
        private Panel panel2;
        private Label label6;
        private Button randomButton;
        private Label label2;
        private TextBox inputStep;
        private TextBox inputT0;
        private Label label9;
        private TextBox inputT1;
        private Label label8;
        private ToolTip toolTip1;
        private ProgressBar progressSolution;
    }
}