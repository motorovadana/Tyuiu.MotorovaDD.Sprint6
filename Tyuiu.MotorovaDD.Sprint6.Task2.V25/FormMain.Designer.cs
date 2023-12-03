
namespace Tyuiu.MotorovaDD.Sprint6.Task2.V25
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox_MDD = new System.Windows.Forms.GroupBox();
            this.groupBoxTwo_MDD = new System.Windows.Forms.GroupBox();
            this.textBoxstart_MDD = new System.Windows.Forms.TextBox();
            this.textBoxstop_MDD = new System.Windows.Forms.TextBox();
            this.buttonDone_MDD = new System.Windows.Forms.Button();
            this.buttonHelp_MDD = new System.Windows.Forms.Button();
            this.dataGridViewOne_MDD = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartOne_MDD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTwo_MDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOne_MDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOne_MDD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_MDD
            // 
            this.groupBox_MDD.Location = new System.Drawing.Point(13, 13);
            this.groupBox_MDD.Name = "groupBox_MDD";
            this.groupBox_MDD.Size = new System.Drawing.Size(411, 305);
            this.groupBox_MDD.TabIndex = 0;
            this.groupBox_MDD.TabStop = false;
            this.groupBox_MDD.Text = "Написать программу,которая выводит таблицу значений функции";
            // 
            // groupBoxTwo_MDD
            // 
            this.groupBoxTwo_MDD.Controls.Add(this.textBoxstop_MDD);
            this.groupBoxTwo_MDD.Controls.Add(this.textBoxstart_MDD);
            this.groupBoxTwo_MDD.Location = new System.Drawing.Point(12, 338);
            this.groupBoxTwo_MDD.Name = "groupBoxTwo_MDD";
            this.groupBoxTwo_MDD.Size = new System.Drawing.Size(353, 100);
            this.groupBoxTwo_MDD.TabIndex = 1;
            this.groupBoxTwo_MDD.TabStop = false;
            this.groupBoxTwo_MDD.Text = "Ввод данных";
            // 
            // textBoxstart_MDD
            // 
            this.textBoxstart_MDD.Location = new System.Drawing.Point(7, 35);
            this.textBoxstart_MDD.Name = "textBoxstart_MDD";
            this.textBoxstart_MDD.Size = new System.Drawing.Size(100, 22);
            this.textBoxstart_MDD.TabIndex = 0;
            // 
            // textBoxstop_MDD
            // 
            this.textBoxstop_MDD.Location = new System.Drawing.Point(160, 35);
            this.textBoxstop_MDD.Name = "textBoxstop_MDD";
            this.textBoxstop_MDD.Size = new System.Drawing.Size(100, 22);
            this.textBoxstop_MDD.TabIndex = 1;
            // 
            // buttonDone_MDD
            // 
            this.buttonDone_MDD.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MDD.Location = new System.Drawing.Point(469, 390);
            this.buttonDone_MDD.Name = "buttonDone_MDD";
            this.buttonDone_MDD.Size = new System.Drawing.Size(95, 48);
            this.buttonDone_MDD.TabIndex = 2;
            this.buttonDone_MDD.Text = "Выполнить";
            this.buttonDone_MDD.UseVisualStyleBackColor = false;
            this.buttonDone_MDD.Click += new System.EventHandler(this.buttonDone_MDD_Click);
            this.buttonDone_MDD.MouseEnter += new System.EventHandler(this.buttonDone_MDD_MouseEnter);
            this.buttonDone_MDD.MouseLeave += new System.EventHandler(this.buttonDone_MDD_Leave);
            this.buttonDone_MDD.MouseHover += new System.EventHandler(this.buttonDone_MDD_MouseHover);
            // 
            // buttonHelp_MDD
            // 
            this.buttonHelp_MDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_MDD.Location = new System.Drawing.Point(371, 390);
            this.buttonHelp_MDD.Name = "buttonHelp_MDD";
            this.buttonHelp_MDD.Size = new System.Drawing.Size(92, 48);
            this.buttonHelp_MDD.TabIndex = 3;
            this.buttonHelp_MDD.Text = "Справка";
            this.buttonHelp_MDD.UseVisualStyleBackColor = false;
            this.buttonHelp_MDD.Click += new System.EventHandler(this.buttonHelp_MDD_Click);
            // 
            // dataGridViewOne_MDD
            // 
            this.dataGridViewOne_MDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOne_MDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column2});
            this.dataGridViewOne_MDD.Location = new System.Drawing.Point(440, 64);
            this.dataGridViewOne_MDD.Name = "dataGridViewOne_MDD";
            this.dataGridViewOne_MDD.RowHeadersVisible = false;
            this.dataGridViewOne_MDD.RowHeadersWidth = 51;
            this.dataGridViewOne_MDD.RowTemplate.Height = 24;
            this.dataGridViewOne_MDD.Size = new System.Drawing.Size(107, 238);
            this.dataGridViewOne_MDD.TabIndex = 5;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "F(X)";
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // chartOne_MDD
            // 
            chartArea8.Name = "ChartArea1";
            this.chartOne_MDD.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartOne_MDD.Legends.Add(legend8);
            this.chartOne_MDD.Location = new System.Drawing.Point(599, 48);
            this.chartOne_MDD.Name = "chartOne_MDD";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartOne_MDD.Series.Add(series8);
            this.chartOne_MDD.Size = new System.Drawing.Size(394, 300);
            this.chartOne_MDD.TabIndex = 6;
            this.chartOne_MDD.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.chartOne_MDD);
            this.Controls.Add(this.dataGridViewOne_MDD);
            this.Controls.Add(this.buttonHelp_MDD);
            this.Controls.Add(this.buttonDone_MDD);
            this.Controls.Add(this.groupBoxTwo_MDD);
            this.Controls.Add(this.groupBox_MDD);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 25| Моторова Д.Д";
            this.groupBoxTwo_MDD.ResumeLayout(false);
            this.groupBoxTwo_MDD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOne_MDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOne_MDD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_MDD;
        private System.Windows.Forms.GroupBox groupBoxTwo_MDD;
        private System.Windows.Forms.TextBox textBoxstop_MDD;
        private System.Windows.Forms.TextBox textBoxstart_MDD;
        private System.Windows.Forms.Button buttonDone_MDD;
        private System.Windows.Forms.Button buttonHelp_MDD;
        private System.Windows.Forms.DataGridView dataGridViewOne_MDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOne_MDD;
    }
}

