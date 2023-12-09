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
using Tyuiu.MotorovaDD.Sprint6.Task7.V16.Lib;

namespace Tyuiu.MotorovaDD.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            
            InitializeComponent(); 
            openFileDialog_MDD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_MDD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_MDD_Click(object sender, EventArgs e)
        {
            openFileDialog_MDD.ShowDialog();
            openFile = openFileDialog_MDD.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInput_MDD.RowCount = rows;
            dataGridViewInput_MDD.ColumnCount = columns;
            dataGridViewOut_MDD.RowCount = rows;
            dataGridViewOut_MDD.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_MDD.Columns[i].Width = 50;
                dataGridViewOut_MDD.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_MDD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_MDD.Enabled = true;
        }

        private void buttonDone_MDD_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_MDD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_MDD.Enabled = true;
        }

        private void buttonDone_MDD_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_MDD.ToolTipTitle = "Открыть файл";
        }

        private void buttonSave_MDD_Click(object sender, EventArgs e)
        {
            saveFileDialog_MDD.FileName = "OutPutFileTask7.csv";
            saveFileDialog_MDD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MDD.ShowDialog();

            string path = saveFileDialog_MDD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_MDD.RowCount;
            int columns = dataGridViewOut_MDD.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInput_MDD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInput_MDD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_MDD_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_MDD.ToolTipTitle = "Открыть файл";
        }

        private void buttonSave_MDD_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_MDD.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_MDD_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
           formabout.ShowDialog();
        }

        private void buttonHelp_MDD_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_MDD.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_MDD.RowCount = 50;
            dataGridViewOut_MDD.RowCount = 50;

            dataGridViewInput_MDD.ColumnCount = 50;
            dataGridViewOut_MDD.ColumnCount = 50;

            panelLeft_MDD.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_MDD.Columns[i].Width = 25;
                dataGridViewOut_MDD.Columns[i].Width = 25;
            }
        }
    }
    
}

