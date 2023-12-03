using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MotorovaDD.Sprint6.Task1.V5.Lib;

namespace Tyuiu.MotorovaDD.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_MDD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = int.Parse(textBoxStart_MDD.Text);
                int stopStep = int.Parse(textBoxStop_MDD.Text);
                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxRezult_MDD.Text = "";
                textBoxRezult_MDD.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRezult_MDD.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRezult_MDD.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxRezult_MDD.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxRezult_MDD.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxRezult_MDD_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonHelp_MDD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Моторова Дана Дмитриевна", "Сообщение");
        }

        private void TextBoxStart_MDD(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }


        }
    }
}
    

