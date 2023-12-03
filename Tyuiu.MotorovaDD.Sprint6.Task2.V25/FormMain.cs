using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MotorovaDD.Sprint6.Task2.V25.Lib;
namespace Tyuiu.MotorovaDD.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_MDD_Click(object sender, EventArgs e)
        {
            try
            {

                int startStep = Convert.ToInt32(textBoxstart_MDD.Text);
                int stopStep = Convert.ToInt32(textBoxstop_MDD.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartOne_MDD.Titles.Add("График функции");
                this.chartOne_MDD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOne_MDD.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOne_MDD.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartOne_MDD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonDone_MDD_MouseHover(object sender, EventArgs e)
        {
            buttonDone_MDD.BackColor = Color.Blue;
        }

        private void buttonDone_MDD_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MDD.BackColor = Color.Red;
        }

        private void buttonDone_MDD_Leave(object sender, EventArgs e)
        {
            buttonDone_MDD.BackColor = Color.Green;
        }

        private void buttonHelp_MDD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-23-1 Моторова Дана Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
        

