
namespace Tyuiu.MotorovaDD.Sprint6.Task6.V6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxInPut_MDD = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_MDD = new System.Windows.Forms.GroupBox();
            this.textBoxInput_MDD = new System.Windows.Forms.TextBox();
            this.textBoxOut_MDD = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MDD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_MDD = new System.Windows.Forms.Button();
            this.buttonDone_MDD = new System.Windows.Forms.Button();
            this.buttonOpenFile_MDD = new System.Windows.Forms.Button();
            this.labelTask_MDD = new System.Windows.Forms.Label();
            this.labelTask6_MDD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxInPut_MDD.SuspendLayout();
            this.groupBoxOut_MDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_MDD);
            this.panel1.Controls.Add(this.buttonDone_MDD);
            this.panel1.Controls.Add(this.buttonOpenFile_MDD);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTask6_MDD);
            this.panel2.Controls.Add(this.labelTask_MDD);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 52);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxInPut_MDD
            // 
            this.groupBoxInPut_MDD.Controls.Add(this.textBoxInput_MDD);
            this.groupBoxInPut_MDD.Location = new System.Drawing.Point(12, 143);
            this.groupBoxInPut_MDD.Name = "groupBoxInPut_MDD";
            this.groupBoxInPut_MDD.Size = new System.Drawing.Size(409, 298);
            this.groupBoxInPut_MDD.TabIndex = 2;
            this.groupBoxInPut_MDD.TabStop = false;
            this.groupBoxInPut_MDD.Text = "Ввод";
            // 
            // groupBoxOut_MDD
            // 
            this.groupBoxOut_MDD.Controls.Add(this.textBoxOut_MDD);
            this.groupBoxOut_MDD.Location = new System.Drawing.Point(460, 143);
            this.groupBoxOut_MDD.Name = "groupBoxOut_MDD";
            this.groupBoxOut_MDD.Size = new System.Drawing.Size(409, 298);
            this.groupBoxOut_MDD.TabIndex = 3;
            this.groupBoxOut_MDD.TabStop = false;
            this.groupBoxOut_MDD.Text = "Вывод";
            // 
            // textBoxInput_MDD
            // 
            this.textBoxInput_MDD.Location = new System.Drawing.Point(7, 22);
            this.textBoxInput_MDD.Multiline = true;
            this.textBoxInput_MDD.Name = "textBoxInput_MDD";
            this.textBoxInput_MDD.Size = new System.Drawing.Size(383, 270);
            this.textBoxInput_MDD.TabIndex = 0;
            // 
            // textBoxOut_MDD
            // 
            this.textBoxOut_MDD.Location = new System.Drawing.Point(20, 28);
            this.textBoxOut_MDD.Multiline = true;
            this.textBoxOut_MDD.Name = "textBoxOut_MDD";
            this.textBoxOut_MDD.Size = new System.Drawing.Size(383, 270);
            this.textBoxOut_MDD.TabIndex = 1;
            // 
            // openFileDialogTask_MDD
            // 
            this.openFileDialogTask_MDD.FileName = "openFileDialog1";
            // 
            // buttonHelp_MDD
            // 
            this.buttonHelp_MDD.Image = global::Tyuiu.MotorovaDD.Sprint6.Task6.V6.Properties.Resources.help_1_;
            this.buttonHelp_MDD.Location = new System.Drawing.Point(763, 3);
            this.buttonHelp_MDD.Name = "buttonHelp_MDD";
            this.buttonHelp_MDD.Size = new System.Drawing.Size(68, 54);
            this.buttonHelp_MDD.TabIndex = 2;
            this.buttonHelp_MDD.UseVisualStyleBackColor = true;
            this.buttonHelp_MDD.Click += new System.EventHandler(this.buttonHelp_MDD_Click);
            // 
            // buttonDone_MDD
            // 
            this.buttonDone_MDD.Image = global::Tyuiu.MotorovaDD.Sprint6.Task6.V6.Properties.Resources.page_white_go_1_;
            this.buttonDone_MDD.Location = new System.Drawing.Point(92, 2);
            this.buttonDone_MDD.Name = "buttonDone_MDD";
            this.buttonDone_MDD.Size = new System.Drawing.Size(68, 54);
            this.buttonDone_MDD.TabIndex = 1;
            this.buttonDone_MDD.UseVisualStyleBackColor = true;
            this.buttonDone_MDD.Click += new System.EventHandler(this.buttonDone_MDD_Click);
            // 
            // buttonOpenFile_MDD
            // 
            this.buttonOpenFile_MDD.Image = global::Tyuiu.MotorovaDD.Sprint6.Task6.V6.Properties.Resources.folder_page_2_;
            this.buttonOpenFile_MDD.Location = new System.Drawing.Point(7, 3);
            this.buttonOpenFile_MDD.Name = "buttonOpenFile_MDD";
            this.buttonOpenFile_MDD.Size = new System.Drawing.Size(68, 54);
            this.buttonOpenFile_MDD.TabIndex = 0;
            this.buttonOpenFile_MDD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MDD.Click += new System.EventHandler(this.buttonOpenFile_MDD_Click);
            // 
            // labelTask_MDD
            // 
            this.labelTask_MDD.AutoSize = true;
            this.labelTask_MDD.Location = new System.Drawing.Point(4, 4);
            this.labelTask_MDD.Name = "labelTask_MDD";
            this.labelTask_MDD.Size = new System.Drawing.Size(0, 17);
            this.labelTask_MDD.TabIndex = 0;
            // 
            // labelTask6_MDD
            // 
            this.labelTask6_MDD.AutoSize = true;
            this.labelTask6_MDD.Location = new System.Drawing.Point(4, 4);
            this.labelTask6_MDD.Name = "labelTask6_MDD";
            this.labelTask6_MDD.Size = new System.Drawing.Size(777, 34);
            this.labelTask6_MDD.TabIndex = 1;
            this.labelTask6_MDD.Text = resources.GetString("labelTask6_MDD.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.groupBoxOut_MDD);
            this.Controls.Add(this.groupBoxInPut_MDD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 6| Моторова.Д.Д";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxInPut_MDD.ResumeLayout(false);
            this.groupBoxInPut_MDD.PerformLayout();
            this.groupBoxOut_MDD.ResumeLayout(false);
            this.groupBoxOut_MDD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_MDD;
        private System.Windows.Forms.Button buttonDone_MDD;
        private System.Windows.Forms.Button buttonOpenFile_MDD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxInPut_MDD;
        private System.Windows.Forms.TextBox textBoxInput_MDD;
        private System.Windows.Forms.GroupBox groupBoxOut_MDD;
        private System.Windows.Forms.TextBox textBoxOut_MDD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MDD;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelTask6_MDD;
        private System.Windows.Forms.Label labelTask_MDD;
    }
}

