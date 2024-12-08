using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.GulienkoPO.Sprint6.Task1.V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxData_NVI = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_NVI = new System.Windows.Forms.TextBox();
            this.textBoxStart_NVI = new System.Windows.Forms.TextBox();
            this.labelForEnd_NVI = new System.Windows.Forms.Label();
            this.labelForStart_NVI = new System.Windows.Forms.Label();
            this.buttonHelp_NVI = new System.Windows.Forms.Button();
            this.groupBoxTask_NVi = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxResult_NVI = new System.Windows.Forms.GroupBox();
            this.labelResult_NVI = new System.Windows.Forms.Label();
            this.textBoxResult_NVI = new System.Windows.Forms.TextBox();
            this.buttonDone_NVI = new System.Windows.Forms.Button();
            this.groupBoxData_NVI.SuspendLayout();
            this.groupBoxTask_NVi.SuspendLayout();
            this.groupBoxResult_NVI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData_NVI
            // 
            this.groupBoxData_NVI.Controls.Add(this.textBoxEnd_NVI);
            this.groupBoxData_NVI.Controls.Add(this.textBoxStart_NVI);
            this.groupBoxData_NVI.Controls.Add(this.labelForEnd_NVI);
            this.groupBoxData_NVI.Controls.Add(this.labelForStart_NVI);
            this.groupBoxData_NVI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxData_NVI.Location = new System.Drawing.Point(12, 278);
            this.groupBoxData_NVI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxData_NVI.Name = "groupBoxData_NVI";
            this.groupBoxData_NVI.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxData_NVI.Size = new System.Drawing.Size(336, 78);
            this.groupBoxData_NVI.TabIndex = 0;
            this.groupBoxData_NVI.TabStop = false;
            this.groupBoxData_NVI.Text = "Ввод данных";
            // 
            // textBoxEnd_NVI
            // 
            this.textBoxEnd_NVI.Location = new System.Drawing.Point(162, 50);
            this.textBoxEnd_NVI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnd_NVI.Name = "textBoxEnd_NVI";
            this.textBoxEnd_NVI.Size = new System.Drawing.Size(125, 27);
            this.textBoxEnd_NVI.TabIndex = 3;
            this.textBoxEnd_NVI.Text = "5";
            // 
            // textBoxStart_NVI
            // 
            this.textBoxStart_NVI.Location = new System.Drawing.Point(21, 50);
            this.textBoxStart_NVI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStart_NVI.Name = "textBoxStart_NVI";
            this.textBoxStart_NVI.Size = new System.Drawing.Size(125, 27);
            this.textBoxStart_NVI.TabIndex = 2;
            this.textBoxStart_NVI.Text = "-5";
            // 
            // labelForEnd_NVI
            // 
            this.labelForEnd_NVI.AutoSize = true;
            this.labelForEnd_NVI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForEnd_NVI.Location = new System.Drawing.Point(162, 29);
            this.labelForEnd_NVI.Name = "labelForEnd_NVI";
            this.labelForEnd_NVI.Size = new System.Drawing.Size(91, 20);
            this.labelForEnd_NVI.TabIndex = 1;
            this.labelForEnd_NVI.Text = "Конец шага";
            // 
            // labelForStart_NVI
            // 
            this.labelForStart_NVI.AutoSize = true;
            this.labelForStart_NVI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForStart_NVI.Location = new System.Drawing.Point(21, 29);
            this.labelForStart_NVI.Name = "labelForStart_NVI";
            this.labelForStart_NVI.Size = new System.Drawing.Size(85, 20);
            this.labelForStart_NVI.TabIndex = 0;
            this.labelForStart_NVI.Text = "Старт шага";
            // 
            // buttonHelp_NVI
            // 
            this.buttonHelp_NVI.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_NVI.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonHelp_NVI.FlatAppearance.BorderSize = 2;
            this.buttonHelp_NVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_NVI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHelp_NVI.Location = new System.Drawing.Point(354, 286);
            this.buttonHelp_NVI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp_NVI.Name = "buttonHelp_NVI";
            this.buttonHelp_NVI.Size = new System.Drawing.Size(96, 70);
            this.buttonHelp_NVI.TabIndex = 1;
            this.buttonHelp_NVI.Text = "Справка";
            this.buttonHelp_NVI.UseVisualStyleBackColor = false;
            // 
            // groupBoxTask_NVi
            // 
            this.groupBoxTask_NVi.Controls.Add(this.textBox1);
            this.groupBoxTask_NVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxTask_NVi.Location = new System.Drawing.Point(12, 10);
            this.groupBoxTask_NVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_NVi.Name = "groupBoxTask_NVi";
            this.groupBoxTask_NVi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_NVi.Size = new System.Drawing.Size(567, 272);
            this.groupBoxTask_NVi.TabIndex = 2;
            this.groupBoxTask_NVi.TabStop = false;
            this.groupBoxTask_NVi.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(21, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(540, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в виде таблицы";
            // 
            // groupBoxResult_NVI
            // 
            this.groupBoxResult_NVI.Controls.Add(this.labelResult_NVI);
            this.groupBoxResult_NVI.Controls.Add(this.textBoxResult_NVI);
            this.groupBoxResult_NVI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxResult_NVI.Location = new System.Drawing.Point(585, 10);
            this.groupBoxResult_NVI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResult_NVI.Name = "groupBoxResult_NVI";
            this.groupBoxResult_NVI.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResult_NVI.Size = new System.Drawing.Size(281, 347);
            this.groupBoxResult_NVI.TabIndex = 3;
            this.groupBoxResult_NVI.TabStop = false;
            this.groupBoxResult_NVI.Text = "Вывод данных";
            // 
            // labelResult_NVI
            // 
            this.labelResult_NVI.AutoSize = true;
            this.labelResult_NVI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResult_NVI.Location = new System.Drawing.Point(6, 18);
            this.labelResult_NVI.Name = "labelResult_NVI";
            this.labelResult_NVI.Size = new System.Drawing.Size(75, 20);
            this.labelResult_NVI.TabIndex = 1;
            this.labelResult_NVI.Text = "Результат";
            // 
            // textBoxResult_NVI
            // 
            this.textBoxResult_NVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_NVI.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_NVI.Location = new System.Drawing.Point(6, 37);
            this.textBoxResult_NVI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxResult_NVI.Multiline = true;
            this.textBoxResult_NVI.Name = "textBoxResult_NVI";
            this.textBoxResult_NVI.ReadOnly = true;
            this.textBoxResult_NVI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NVI.Size = new System.Drawing.Size(269, 298);
            this.textBoxResult_NVI.TabIndex = 0;
            // 
            // buttonDone_NVI
            // 
            this.buttonDone_NVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_NVI.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDone_NVI.FlatAppearance.BorderSize = 2;
            this.buttonDone_NVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_NVI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDone_NVI.Location = new System.Drawing.Point(456, 286);
            this.buttonDone_NVI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDone_NVI.Name = "buttonDone_NVI";
            this.buttonDone_NVI.Size = new System.Drawing.Size(114, 70);
            this.buttonDone_NVI.TabIndex = 4;
            this.buttonDone_NVI.Text = "Выполнить";
            this.buttonDone_NVI.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 360);
            this.Controls.Add(this.buttonDone_NVI);
            this.Controls.Add(this.groupBoxResult_NVI);
            this.Controls.Add(this.groupBoxTask_NVi);
            this.Controls.Add(this.buttonHelp_NVI);
            this.Controls.Add(this.groupBoxData_NVI);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 3 | Гулиенко. П. О.";
            this.groupBoxData_NVI.ResumeLayout(false);
            this.groupBoxData_NVI.PerformLayout();
            this.groupBoxTask_NVi.ResumeLayout(false);
            this.groupBoxTask_NVi.PerformLayout();
            this.groupBoxResult_NVI.ResumeLayout(false);
            this.groupBoxResult_NVI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxData_NVI;
        private Label labelForEnd_NVI;
        private Label labelForStart_NVI;
        private TextBox textBoxEnd_NVI;
        private TextBox textBoxStart_NVI;
        private Button buttonHelp_NVI;
        private GroupBox groupBoxTask_NVi;
        private TextBox textBox1;
        private GroupBox groupBoxResult_NVI;
        private TextBox textBoxResult_NVI;
        private Label labelResult_NVI;
        private Button buttonDone_NVI;
    }
}