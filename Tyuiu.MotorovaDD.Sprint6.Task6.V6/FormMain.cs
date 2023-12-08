﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MotorovaDD.Sprint6.Task6.V6.Lib;

namespace Tyuiu.MotorovaDD.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_MDD_Click(object sender, EventArgs e)
        {

            openFileDialogTask_MDD.ShowDialog();
            openFilePath = openFileDialogTask_MDD.FileName;
            textBoxInput_MDD.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_MDD.Text = groupBoxInPut_MDD.Text + " " + openFileDialogTask_MDD.FileName;
            buttonDone_MDD.Enabled = true;

        }

        private void buttonDone_MDD_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOut_MDD.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_MDD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
