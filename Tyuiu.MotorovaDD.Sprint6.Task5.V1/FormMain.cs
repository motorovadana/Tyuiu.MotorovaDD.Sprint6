using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MotorovaDD.Sprint6.Task5.V1.Lib;
namespace Tyuiu.MotorovaDD.Sprint6.Task5.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V1.txt";

        private void buttonHepl_MDD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-23-1 Моторова Дана Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonStartOne_MDD_Click(object sender, EventArgs e)
        {
            dataGridViewResult_MDD.ColumnCount = 2;
            dataGridViewResult_MDD.Columns[0].Width = 20;
            dataGridViewResult_MDD.Columns[1].Width = 50;

            this.chartResult_MDD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_MDD.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_MDD.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_MDD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_MDD.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void ButtonOpenTwo_MDD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }

 

      
  }
    

