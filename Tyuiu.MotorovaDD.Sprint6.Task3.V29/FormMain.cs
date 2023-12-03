using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MotorovaDD.Sprint6.Task3.V29.Lib;

namespace Tyuiu.MotorovaDD.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            {
                DataService ds = new DataService();
                int[,] matrix = new int[5, 5] { {-2, -13, -15, -9, -17},
                                            {13,-20, -15,  27,  18 },
                                            {-12, -1, -20, 13, 0 },
                                            {15, 32, 18, -12, -18},
                                            {16, 5, 3,-5, -8 }};
            }
        }
        DataService ds = new DataService();
        private int[,] matrix;

        private void buttonDone_MDD_Click(object sender, EventArgs e)
            
          {
            int[,] matres = ds.Calculate(matrix);
            int n = matres.GetLength(0);
            int M = matres.GetLength(1);
            dataGridViewRes_MDD.ColumnCount = M;
            dataGridViewRes_MDD.RowCount = n;
            for (int i = 0; i < M; i++)
            {
                dataGridViewRes_MDD.Columns[i].Width = 25;
            }
            for ( int i =0; i <n;i++)
            {
                for (int j = 0; i < M; j++)
                {
                    dataGridViewRes_MDD.Rows[i].Cells[j].Value = Convert.ToString(matres[i, j]);
                }
            }
          }

          private void buttonHelp_MDD_Click(object sender, EventArgs e)
          {

            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Моторова Дана Дмитриевна");
          }

          private void FormMain_Load(object sender, EventArgs e)
          {
            int n = matrix.GetLength(0);
            int M = matrix.GetLength(1);
            dataGridViewRes_MDD.ColumnCount = M;
            dataGridViewRes_MDD.RowCount = n;
            for (int i = 0; i < M; i++)
            {
                dataGridViewRes_MDD.Columns[i].Width = 25;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < M; i++)
                {
                    dataGridViewRes_MDD.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

          }
     }
        
}


