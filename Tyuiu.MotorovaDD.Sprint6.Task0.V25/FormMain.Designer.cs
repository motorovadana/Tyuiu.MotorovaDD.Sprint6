
namespace Tyuiu.MotorovaDD.Sprint6.Task0.V25
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
            this.buttonHelpMe_MDD = new System.Windows.Forms.Button();
            this.groupBox_MDD = new System.Windows.Forms.GroupBox();
            this.buttonDone_MDD = new System.Windows.Forms.Button();
            this.groupBoxInPut_MDD = new System.Windows.Forms.GroupBox();
            this.labelVarX_MDD = new System.Windows.Forms.Label();
            this.textBoxVarX_MDD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_MDD = new System.Windows.Forms.GroupBox();
            this.labelRezult_MDD = new System.Windows.Forms.Label();
            this.textBoxRezult_MDD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut_MDD.SuspendLayout();
            this.groupBoxOut_MDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelpMe_MDD
            // 
            this.buttonHelpMe_MDD.Location = new System.Drawing.Point(604, 378);
            this.buttonHelpMe_MDD.Name = "buttonHelpMe_MDD";
            this.buttonHelpMe_MDD.Size = new System.Drawing.Size(43, 35);
            this.buttonHelpMe_MDD.TabIndex = 0;
            this.buttonHelpMe_MDD.Text = "? ";
            this.buttonHelpMe_MDD.UseVisualStyleBackColor = true;
            this.buttonHelpMe_MDD.Click += new System.EventHandler(this.buttonHelpMe_MDD_Click);
            // 
            // groupBox_MDD
            // 
            this.groupBox_MDD.Location = new System.Drawing.Point(26, 30);
            this.groupBox_MDD.Name = "groupBox_MDD";
            this.groupBox_MDD.Size = new System.Drawing.Size(286, 113);
            this.groupBox_MDD.TabIndex = 1;
            this.groupBox_MDD.TabStop = false;
            this.groupBox_MDD.Text = "Вычислить выражение";
            // 
            // buttonDone_MDD
            // 
            this.buttonDone_MDD.Location = new System.Drawing.Point(673, 383);
            this.buttonDone_MDD.Name = "buttonDone_MDD";
            this.buttonDone_MDD.Size = new System.Drawing.Size(101, 30);
            this.buttonDone_MDD.TabIndex = 2;
            this.buttonDone_MDD.Text = "Выполнить";
            this.buttonDone_MDD.UseVisualStyleBackColor = true;
            this.buttonDone_MDD.Click += new System.EventHandler(this.buttonDone_MDD_Click);
            // 
            // groupBoxInPut_MDD
            // 
            this.groupBoxInPut_MDD.Controls.Add(this.labelVarX_MDD);
            this.groupBoxInPut_MDD.Controls.Add(this.textBoxVarX_MDD);
            this.groupBoxInPut_MDD.Location = new System.Drawing.Point(12, 276);
            this.groupBoxInPut_MDD.Name = "groupBoxInPut_MDD";
            this.groupBoxInPut_MDD.Size = new System.Drawing.Size(332, 107);
            this.groupBoxInPut_MDD.TabIndex = 3;
            this.groupBoxInPut_MDD.TabStop = false;
            this.groupBoxInPut_MDD.Text = "Ввод данных";
            // 
            // labelVarX_MDD
            // 
            this.labelVarX_MDD.AutoSize = true;
            this.labelVarX_MDD.Location = new System.Drawing.Point(1, 18);
            this.labelVarX_MDD.Name = "labelVarX_MDD";
            this.labelVarX_MDD.Size = new System.Drawing.Size(17, 17);
            this.labelVarX_MDD.TabIndex = 1;
            this.labelVarX_MDD.Text = "X";
            // 
            // textBoxVarX_MDD
            // 
            this.textBoxVarX_MDD.Location = new System.Drawing.Point(1, 41);
            this.textBoxVarX_MDD.Name = "textBoxVarX_MDD";
            this.textBoxVarX_MDD.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_MDD.TabIndex = 0;
            this.textBoxVarX_MDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxVarX_MDD);
            // 
            // groupBoxOut_MDD
            // 
            this.groupBoxOut_MDD.Controls.Add(this.labelRezult_MDD);
            this.groupBoxOut_MDD.Controls.Add(this.textBoxRezult_MDD);
            this.groupBoxOut_MDD.Location = new System.Drawing.Point(556, 224);
            this.groupBoxOut_MDD.Name = "groupBoxOut_MDD";
            this.groupBoxOut_MDD.Size = new System.Drawing.Size(232, 102);
            this.groupBoxOut_MDD.TabIndex = 4;
            this.groupBoxOut_MDD.TabStop = false;
            this.groupBoxOut_MDD.Text = "Вывод данных";
            // 
            // labelRezult_MDD
            // 
            this.labelRezult_MDD.AutoSize = true;
            this.labelRezult_MDD.Location = new System.Drawing.Point(0, 29);
            this.labelRezult_MDD.Name = "labelRezult_MDD";
            this.labelRezult_MDD.Size = new System.Drawing.Size(76, 17);
            this.labelRezult_MDD.TabIndex = 1;
            this.labelRezult_MDD.Text = "Результат";
            // 
            // textBoxRezult_MDD
            // 
            this.textBoxRezult_MDD.Location = new System.Drawing.Point(0, 52);
            this.textBoxRezult_MDD.Name = "textBoxRezult_MDD";
            this.textBoxRezult_MDD.Size = new System.Drawing.Size(100, 22);
            this.textBoxRezult_MDD.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 78);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_MDD);
            this.Controls.Add(this.groupBoxOut_MDD);
            this.Controls.Add(this.groupBoxInPut_MDD);
            this.Controls.Add(this.buttonDone_MDD);
            this.Controls.Add(this.buttonHelpMe_MDD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 25 | Моторова Д.Д";
            this.groupBoxInPut_MDD.ResumeLayout(false);
            this.groupBoxInPut_MDD.PerformLayout();
            this.groupBoxOut_MDD.ResumeLayout(false);
            this.groupBoxOut_MDD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelpMe_MDD;
        private System.Windows.Forms.GroupBox groupBox_MDD;
        private System.Windows.Forms.Button buttonDone_MDD;
        private System.Windows.Forms.GroupBox groupBoxInPut_MDD;
        private System.Windows.Forms.Label labelVarX_MDD;
        private System.Windows.Forms.TextBox textBoxVarX_MDD;
        private System.Windows.Forms.GroupBox groupBoxOut_MDD;
        private System.Windows.Forms.Label labelRezult_MDD;
        private System.Windows.Forms.TextBox textBoxRezult_MDD;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

