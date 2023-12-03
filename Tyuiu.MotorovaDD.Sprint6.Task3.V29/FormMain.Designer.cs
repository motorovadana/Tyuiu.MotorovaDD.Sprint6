
using System;

namespace Tyuiu.MotorovaDD.Sprint6.Task3.V29
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
            this.groupBoxOne_MDD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRes_MDD = new System.Windows.Forms.DataGridView();
            this.groupBoxRes_MDD = new System.Windows.Forms.GroupBox();
            this.textBoxRes_MDD = new System.Windows.Forms.TextBox();
            this.buttonDone_MDD = new System.Windows.Forms.Button();
            this.buttonHelp_MDD = new System.Windows.Forms.Button();
            this.groupBoxOne_MDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MDD)).BeginInit();
            this.groupBoxRes_MDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_MDD
            // 
            this.groupBoxOne_MDD.Controls.Add(this.label1);
            this.groupBoxOne_MDD.Location = new System.Drawing.Point(3, 2);
            this.groupBoxOne_MDD.Name = "groupBoxOne_MDD";
            this.groupBoxOne_MDD.Size = new System.Drawing.Size(306, 450);
            this.groupBoxOne_MDD.TabIndex = 0;
            this.groupBoxOne_MDD.TabStop = false;
            this.groupBoxOne_MDD.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 187);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дан массив 5 на 5 элементов\r\nВыполнить сортировку\r\n -2 -13 -15  -9 -17\r\n\r\n  13 -2" +
    "0 -15  27  18\r\n\r\n -12  -1 -20  13   0\r\n\r\n  15  32  18 -12 -18\r\n\r\n  16   5   3  -" +
    "5  -8\r\n";
            // 
            // dataGridViewRes_MDD
            // 
            this.dataGridViewRes_MDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MDD.Location = new System.Drawing.Point(315, 12);
            this.dataGridViewRes_MDD.Name = "dataGridViewRes_MDD";
            this.dataGridViewRes_MDD.RowHeadersWidth = 51;
            this.dataGridViewRes_MDD.RowTemplate.Height = 24;
            this.dataGridViewRes_MDD.Size = new System.Drawing.Size(240, 331);
            this.dataGridViewRes_MDD.TabIndex = 1;
   
            // 
            // groupBoxRes_MDD
            // 
            this.groupBoxRes_MDD.Controls.Add(this.textBoxRes_MDD);
            this.groupBoxRes_MDD.Location = new System.Drawing.Point(588, 25);
            this.groupBoxRes_MDD.Name = "groupBoxRes_MDD";
            this.groupBoxRes_MDD.Size = new System.Drawing.Size(200, 100);
            this.groupBoxRes_MDD.TabIndex = 2;
            this.groupBoxRes_MDD.TabStop = false;
            this.groupBoxRes_MDD.Text = "Вывод данных";
            // 
            // textBoxRes_MDD
            // 
            this.textBoxRes_MDD.Location = new System.Drawing.Point(0, 41);
            this.textBoxRes_MDD.Name = "textBoxRes_MDD";
            this.textBoxRes_MDD.Size = new System.Drawing.Size(100, 22);
            this.textBoxRes_MDD.TabIndex = 0;
            // 
            // buttonDone_MDD
            // 
            this.buttonDone_MDD.Location = new System.Drawing.Point(674, 409);
            this.buttonDone_MDD.Name = "buttonDone_MDD";
            this.buttonDone_MDD.Size = new System.Drawing.Size(115, 29);
            this.buttonDone_MDD.TabIndex = 3;
            this.buttonDone_MDD.Text = "Запустить";
            this.buttonDone_MDD.UseVisualStyleBackColor = true;
            this.buttonDone_MDD.Click += new System.EventHandler(this.buttonDone_MDD_Click);
            // 
            // buttonHelp_MDD
            // 
            this.buttonHelp_MDD.Location = new System.Drawing.Point(593, 412);
            this.buttonHelp_MDD.Name = "buttonHelp_MDD";
            this.buttonHelp_MDD.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_MDD.TabIndex = 4;
            this.buttonHelp_MDD.Text = "?";
            this.buttonHelp_MDD.UseVisualStyleBackColor = true;
            
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_MDD);
            this.Controls.Add(this.buttonDone_MDD);
            this.Controls.Add(this.groupBoxRes_MDD);
            this.Controls.Add(this.dataGridViewRes_MDD);
            this.Controls.Add(this.groupBoxOne_MDD);
            this.Name = "FormMain";
            this.Text = "Спринт 6| Таск 3 | Вариант 29 |Моторова.Д.Д";
            
            this.groupBoxOne_MDD.ResumeLayout(false);
            this.groupBoxOne_MDD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MDD)).EndInit();
            this.groupBoxRes_MDD.ResumeLayout(false);
            this.groupBoxRes_MDD.PerformLayout();
            this.ResumeLayout(false);

        }


   

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_MDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRes_MDD;
        private System.Windows.Forms.GroupBox groupBoxRes_MDD;
        private System.Windows.Forms.TextBox textBoxRes_MDD;
        private System.Windows.Forms.Button buttonDone_MDD;
        private System.Windows.Forms.Button buttonHelp_MDD;
    }
}

