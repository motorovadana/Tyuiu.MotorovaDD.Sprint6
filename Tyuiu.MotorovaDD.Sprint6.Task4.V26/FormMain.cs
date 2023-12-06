using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MotorovaDD.Sprint6.Task4.V26.Lib;

namespace Tyuiu.MotorovaDD.Sprint6.Task4.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonClick_MDD(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_MDD.Text);
                int stopStep = Convert.ToInt32(textBoxStop_MDD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxOut_MDD.Text = "";
                chartstart_MDD.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartstart_MDD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOut_MDD.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ButtonSave_MDD(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOut_MDD.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n  Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonHelp_MDD(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 V26 выполнил студен группы СМАРТб-23-1 Моторова Дана Дмитриевна ", "Сообщение");
        }
    }
    
 }
    

