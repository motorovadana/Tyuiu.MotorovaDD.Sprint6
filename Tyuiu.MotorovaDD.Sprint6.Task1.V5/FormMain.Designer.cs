
using System;

namespace Tyuiu.MotorovaDD.Sprint6.Task1.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_MDD = new System.Windows.Forms.Button();
            this.buttonHelp_MDD = new System.Windows.Forms.Button();
            this.groupBox_MDD = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_MDD = new System.Windows.Forms.GroupBox();
            this.labelVar2_MDD = new System.Windows.Forms.Label();
            this.labelVar1_MDD = new System.Windows.Forms.Label();
            this.textBoxStop_MDD = new System.Windows.Forms.TextBox();
            this.textBoxStart_MDD = new System.Windows.Forms.TextBox();
            this.groupBoxStop_MDD = new System.Windows.Forms.GroupBox();
            this.textBoxRezult_MDD = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox_MDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.textBox_MDD.SuspendLayout();
            this.groupBoxStop_MDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_MDD
            // 
            this.buttonDone_MDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_MDD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_MDD.Location = new System.Drawing.Point(446, 378);
            this.buttonDone_MDD.Name = "buttonDone_MDD";
            this.buttonDone_MDD.Size = new System.Drawing.Size(126, 44);
            this.buttonDone_MDD.TabIndex = 0;
            this.buttonDone_MDD.Text = "Выполнить ";
            this.buttonDone_MDD.UseVisualStyleBackColor = false;
            this.buttonDone_MDD.Click += new System.EventHandler(this.buttonDone_MDD_Click);
            // 
            // buttonHelp_MDD
            // 
            this.buttonHelp_MDD.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_MDD.Location = new System.Drawing.Point(353, 378);
            this.buttonHelp_MDD.Name = "buttonHelp_MDD";
            this.buttonHelp_MDD.Size = new System.Drawing.Size(87, 44);
            this.buttonHelp_MDD.TabIndex = 1;
            this.buttonHelp_MDD.Text = "Справка";
            this.buttonHelp_MDD.UseVisualStyleBackColor = false;
            this.buttonHelp_MDD.Click += new System.EventHandler(this.buttonHelp_MDD_Click);
            // 
            // groupBox_MDD
            // 
            this.groupBox_MDD.Controls.Add(this.pictureBox1);
            this.groupBox_MDD.Location = new System.Drawing.Point(12, 12);
            this.groupBox_MDD.Name = "groupBox_MDD";
            this.groupBox_MDD.Size = new System.Drawing.Size(482, 334);
            this.groupBox_MDD.TabIndex = 2;
            this.groupBox_MDD.TabStop = false;
            this.groupBox_MDD.Text = "Написать программу,которая выводит таблицу значений функции";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 53);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_MDD
            // 
            this.textBox_MDD.Controls.Add(this.labelVar2_MDD);
            this.textBox_MDD.Controls.Add(this.labelVar1_MDD);
            this.textBox_MDD.Controls.Add(this.textBoxStop_MDD);
            this.textBox_MDD.Controls.Add(this.textBoxStart_MDD);
            this.textBox_MDD.Location = new System.Drawing.Point(3, 352);
            this.textBox_MDD.Name = "textBox_MDD";
            this.textBox_MDD.Size = new System.Drawing.Size(311, 86);
            this.textBox_MDD.TabIndex = 3;
            this.textBox_MDD.TabStop = false;
            this.textBox_MDD.Text = "Ввод данных";
            // 
            // labelVar2_MDD
            // 
            this.labelVar2_MDD.AutoSize = true;
            this.labelVar2_MDD.Location = new System.Drawing.Point(132, 21);
            this.labelVar2_MDD.Name = "labelVar2_MDD";
            this.labelVar2_MDD.Size = new System.Drawing.Size(49, 17);
            this.labelVar2_MDD.TabIndex = 3;
            this.labelVar2_MDD.Text = "Конец";
            // 
            // labelVar1_MDD
            // 
            this.labelVar1_MDD.AutoSize = true;
            this.labelVar1_MDD.Location = new System.Drawing.Point(0, 22);
            this.labelVar1_MDD.Name = "labelVar1_MDD";
            this.labelVar1_MDD.Size = new System.Drawing.Size(47, 17);
            this.labelVar1_MDD.TabIndex = 2;
            this.labelVar1_MDD.Text = "Старт";
            // 
            // textBoxStop_MDD
            // 
            this.textBoxStop_MDD.Location = new System.Drawing.Point(132, 35);
            this.textBoxStop_MDD.Name = "textBoxStop_MDD";
            this.textBoxStop_MDD.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_MDD.TabIndex = 1;
            // 
            // textBoxStart_MDD
            // 
            this.textBoxStart_MDD.Location = new System.Drawing.Point(10, 35);
            this.textBoxStart_MDD.Name = "textBoxStart_MDD";
            this.textBoxStart_MDD.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_MDD.TabIndex = 0;
            this.textBoxStart_MDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxStart_MDD);
            // 
            // groupBoxStop_MDD
            // 
            this.groupBoxStop_MDD.Controls.Add(this.textBoxRezult_MDD);
            this.groupBoxStop_MDD.Controls.Add(this.vScrollBar1);
            this.groupBoxStop_MDD.Location = new System.Drawing.Point(529, 12);
            this.groupBoxStop_MDD.Name = "groupBoxStop_MDD";
            this.groupBoxStop_MDD.Size = new System.Drawing.Size(259, 320);
            this.groupBoxStop_MDD.TabIndex = 4;
            this.groupBoxStop_MDD.TabStop = false;
            this.groupBoxStop_MDD.Text = "Вывод данных";
            // 
            // textBoxRezult_MDD
            // 
            this.textBoxRezult_MDD.Location = new System.Drawing.Point(6, 40);
            this.textBoxRezult_MDD.Multiline = true;
            this.textBoxRezult_MDD.Name = "textBoxRezult_MDD";
            this.textBoxRezult_MDD.Size = new System.Drawing.Size(221, 256);
            this.textBoxRezult_MDD.TabIndex = 1;
            this.textBoxRezult_MDD.TextChanged += new System.EventHandler(this.textBoxRezult_MDD_TextChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(230, 15);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 302);
            this.vScrollBar1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxStop_MDD);
            this.Controls.Add(this.textBox_MDD);
            this.Controls.Add(this.groupBox_MDD);
            this.Controls.Add(this.buttonHelp_MDD);
            this.Controls.Add(this.buttonDone_MDD);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox_MDD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.textBox_MDD.ResumeLayout(false);
            this.textBox_MDD.PerformLayout();
            this.groupBoxStop_MDD.ResumeLayout(false);
            this.groupBoxStop_MDD.PerformLayout();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.Button buttonDone_MDD;
        private System.Windows.Forms.Button buttonHelp_MDD;
        private System.Windows.Forms.GroupBox groupBox_MDD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox textBox_MDD;
        private System.Windows.Forms.TextBox textBoxStop_MDD;
        private System.Windows.Forms.TextBox textBoxStart_MDD;
        private System.Windows.Forms.GroupBox groupBoxStop_MDD;
        private System.Windows.Forms.Label labelVar2_MDD;
        private System.Windows.Forms.Label labelVar1_MDD;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textBoxRezult_MDD;
    }
}

