
using System;

namespace Tyuiu.MotorovaDD.Sprint6.Task5.V1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_MDD = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart_MDD = new System.Windows.Forms.Button();
            this.buttonOpen_MDD = new System.Windows.Forms.Button();
            this.buttonHepl_MDD = new System.Windows.Forms.Button();
            this.panelLeft_MDD = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_MDD = new System.Windows.Forms.DataGridView();
            this.panelFill_MDD = new System.Windows.Forms.Panel();
            this.chartResult_MDD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_MDD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelLeft_MDD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MDD)).BeginInit();
            this.panelFill_MDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_MDD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_MDD
            // 
            this.panelTop_MDD.Controls.Add(this.groupBox1);
            this.panelTop_MDD.Controls.Add(this.buttonStart_MDD);
            this.panelTop_MDD.Controls.Add(this.buttonOpen_MDD);
            this.panelTop_MDD.Controls.Add(this.buttonHepl_MDD);
            this.panelTop_MDD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MDD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MDD.Name = "panelTop_MDD";
            this.panelTop_MDD.Size = new System.Drawing.Size(782, 102);
            this.panelTop_MDD.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прочитать данные из файла InPutFileTask5V1.txt. Вывести в \r\ndataGridView. Вывести" +
    " все положительные числа.";
            // 
            // buttonStart_MDD
            // 
            this.buttonStart_MDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart_MDD.Location = new System.Drawing.Point(485, 24);
            this.buttonStart_MDD.Name = "buttonStart_MDD";
            this.buttonStart_MDD.Size = new System.Drawing.Size(91, 72);
            this.buttonStart_MDD.TabIndex = 2;
            this.buttonStart_MDD.Text = "Выполнить";
            this.buttonStart_MDD.UseVisualStyleBackColor = false;
            this.buttonStart_MDD.Click += new System.EventHandler(this.ButtonStartOne_MDD_Click);
            // 
            // buttonOpen_MDD
            // 
            this.buttonOpen_MDD.BackColor = System.Drawing.Color.Blue;
            this.buttonOpen_MDD.Location = new System.Drawing.Point(582, 24);
            this.buttonOpen_MDD.Name = "buttonOpen_MDD";
            this.buttonOpen_MDD.Size = new System.Drawing.Size(91, 72);
            this.buttonOpen_MDD.TabIndex = 1;
            this.buttonOpen_MDD.Text = "Открыть\r\nфайл";
            this.buttonOpen_MDD.UseVisualStyleBackColor = false;
            this.buttonOpen_MDD.Click += new System.EventHandler(this.ButtonOpenTwo_MDD_Click);
            // 
            // buttonHepl_MDD
            // 
            this.buttonHepl_MDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHepl_MDD.Location = new System.Drawing.Point(679, 24);
            this.buttonHepl_MDD.Name = "buttonHepl_MDD";
            this.buttonHepl_MDD.Size = new System.Drawing.Size(91, 72);
            this.buttonHepl_MDD.TabIndex = 0;
            this.buttonHepl_MDD.Text = "Справка";
            this.buttonHepl_MDD.UseVisualStyleBackColor = false;
            this.buttonHepl_MDD.Click += new System.EventHandler(this.buttonHepl_MDD_Click);
            // 
            // panelLeft_MDD
            // 
            this.panelLeft_MDD.Controls.Add(this.groupBox2);
            this.panelLeft_MDD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MDD.Location = new System.Drawing.Point(0, 102);
            this.panelLeft_MDD.Name = "panelLeft_MDD";
            this.panelLeft_MDD.Size = new System.Drawing.Size(181, 301);
            this.panelLeft_MDD.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewResult_MDD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 301);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewResult_MDD
            // 
            this.dataGridViewResult_MDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_MDD.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewResult_MDD.Name = "dataGridViewResult_MDD";
            this.dataGridViewResult_MDD.RowHeadersWidth = 51;
            this.dataGridViewResult_MDD.RowTemplate.Height = 24;
            this.dataGridViewResult_MDD.Size = new System.Drawing.Size(163, 274);
            this.dataGridViewResult_MDD.TabIndex = 0;
            // 
            // panelFill_MDD
            // 
            this.panelFill_MDD.Controls.Add(this.chartResult_MDD);
            this.panelFill_MDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_MDD.Location = new System.Drawing.Point(181, 102);
            this.panelFill_MDD.Name = "panelFill_MDD";
            this.panelFill_MDD.Size = new System.Drawing.Size(601, 301);
            this.panelFill_MDD.TabIndex = 2;
            // 
            // chartResult_MDD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_MDD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_MDD.Legends.Add(legend1);
            this.chartResult_MDD.Location = new System.Drawing.Point(86, 3);
            this.chartResult_MDD.Name = "chartResult_MDD";
            this.chartResult_MDD.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_MDD.Series.Add(series1);
            this.chartResult_MDD.Size = new System.Drawing.Size(449, 300);
            this.chartResult_MDD.TabIndex = 0;
            this.chartResult_MDD.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.panelFill_MDD);
            this.Controls.Add(this.panelLeft_MDD);
            this.Controls.Add(this.panelTop_MDD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5| Вариант 1 |Моторова Д.Д";
            this.panelTop_MDD.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLeft_MDD.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MDD)).EndInit();
            this.panelFill_MDD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_MDD)).EndInit();
            this.ResumeLayout(false);

        }

        private void ButtonStart_MDD_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonOpen_MDD_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MDD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart_MDD;
        private System.Windows.Forms.Button buttonOpen_MDD;
        private System.Windows.Forms.Button buttonHepl_MDD;
        private System.Windows.Forms.Panel panelLeft_MDD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewResult_MDD;
        private System.Windows.Forms.Panel panelFill_MDD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_MDD;
    }
}

