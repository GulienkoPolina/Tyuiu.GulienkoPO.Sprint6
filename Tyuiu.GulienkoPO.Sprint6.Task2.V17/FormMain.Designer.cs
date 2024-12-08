using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.GulienkoPO.Sprint6.Task2.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
          
            groupBoxTask_SYP = new GroupBox();
            pictureBox1 = new PictureBox();
            labelTask_SYP = new Label();
            groupBoxInPutVarStep = new GroupBox();
            labelStopStep_SYP = new Label();
            labelStartEnd_SYP = new Label();
            textBoxInPutStartStep_SYP = new TextBox();
            textBoxInPutStopStep_SYP = new TextBox();
            buttonDoHelp_SYP = new Button();
            buttonDoResult_SYP = new Button();
            dataGridViewFunction_SYP = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Function = new DataGridViewTextBoxColumn();
            groupBoxOutPutResult_SYP = new GroupBox();
            chartFunction_SYP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInPutVarStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_SYP).BeginInit();
            groupBoxOutPutResult_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SYP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(pictureBox1);
            groupBoxTask_SYP.Controls.Add(labelTask_SYP);
            groupBoxTask_SYP.Location = new Point(12, 12);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(464, 277);
            groupBoxTask_SYP.TabIndex = 1;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = " Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 38);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask_SYP
            // 
            labelTask_SYP.AutoSize = true;
            labelTask_SYP.Location = new Point(6, 19);
            labelTask_SYP.Name = "labelTask_SYP";
            labelTask_SYP.Size = new Size(382, 150);
            labelTask_SYP.TabIndex = 0;
            labelTask_SYP.Text = resources.GetString("labelTask_SYP.Text");
            // 
            // groupBoxInPutVarStep
            // 
            groupBoxInPutVarStep.Controls.Add(labelStopStep_SYP);
            groupBoxInPutVarStep.Controls.Add(labelStartEnd_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStartStep_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStopStep_SYP);
            groupBoxInPutVarStep.Location = new Point(12, 295);
            groupBoxInPutVarStep.Name = "groupBoxInPutVarStep";
            groupBoxInPutVarStep.Size = new Size(243, 64);
            groupBoxInPutVarStep.TabIndex = 2;
            groupBoxInPutVarStep.TabStop = false;
            groupBoxInPutVarStep.Text = "Ввод данных";
            // 
            // labelStopStep_SYP
            // 
            labelStopStep_SYP.AutoSize = true;
            labelStopStep_SYP.Location = new Point(143, 19);
            labelStopStep_SYP.Name = "labelStopStep_SYP";
            labelStopStep_SYP.Size = new Size(75, 15);
            labelStopStep_SYP.TabIndex = 4;
            labelStopStep_SYP.Text = "Конец шага:";
            // 
            // labelStartEnd_SYP
            // 
            labelStartEnd_SYP.AutoSize = true;
            labelStartEnd_SYP.Location = new Point(24, 19);
            labelStartEnd_SYP.Name = "labelStartEnd_SYP";
            labelStartEnd_SYP.Size = new Size(72, 15);
            labelStartEnd_SYP.TabIndex = 3;
            labelStartEnd_SYP.Text = "Старт шага:";
            // 
            // textBoxInPutStartStep_SYP
            // 
            textBoxInPutStartStep_SYP.Location = new Point(6, 35);
            textBoxInPutStartStep_SYP.Name = "textBoxInPutStartStep_SYP";
            textBoxInPutStartStep_SYP.Size = new Size(110, 23);
            textBoxInPutStartStep_SYP.TabIndex = 2;
            textBoxInPutStartStep_SYP.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // textBoxInPutStopStep_SYP
            // 
            textBoxInPutStopStep_SYP.Location = new Point(127, 35);
            textBoxInPutStopStep_SYP.Name = "textBoxInPutStopStep_SYP";
            textBoxInPutStopStep_SYP.Size = new Size(110, 23);
            textBoxInPutStopStep_SYP.TabIndex = 1;
            textBoxInPutStopStep_SYP.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // buttonDoHelp_SYP
            // 
            buttonDoHelp_SYP.BackColor = Color.DodgerBlue;
            buttonDoHelp_SYP.Location = new Point(261, 302);
            buttonDoHelp_SYP.Name = "buttonDoHelp_SYP";
            buttonDoHelp_SYP.Size = new Size(95, 57);
            buttonDoHelp_SYP.TabIndex = 3;
            buttonDoHelp_SYP.Text = "Справка";
            buttonDoHelp_SYP.UseVisualStyleBackColor = false;
            buttonDoHelp_SYP.Click += buttonHelp_Click;
            // 
            // buttonDoResult_SYP
            // 
            buttonDoResult_SYP.BackColor = Color.Green;
            buttonDoResult_SYP.Location = new Point(358, 302);
            buttonDoResult_SYP.Name = "buttonDoResult_SYP";
            buttonDoResult_SYP.Size = new Size(118, 57);
            buttonDoResult_SYP.TabIndex = 4;
            buttonDoResult_SYP.Text = "Выполнить";
            buttonDoResult_SYP.UseVisualStyleBackColor = false;
            buttonDoResult_SYP.Click += buttonDone_Click;
            buttonDoResult_SYP.MouseDown += buttonDone_MouseDown;
            buttonDoResult_SYP.MouseEnter += buttonDone_MouseEnter;
            buttonDoResult_SYP.MouseLeave += buttonDone_MouseLeave;
            // 
            // dataGridViewFunction_SYP
            // 
            dataGridViewFunction_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_SYP.Columns.AddRange(new DataGridViewColumn[] { X, Function });
            dataGridViewFunction_SYP.Location = new Point(21, 37);
            dataGridViewFunction_SYP.Name = "dataGridViewFunction_SYP";
            dataGridViewFunction_SYP.RowHeadersVisible = false;
            dataGridViewFunction_SYP.Size = new Size(121, 240);
            dataGridViewFunction_SYP.TabIndex = 5;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Function
            // 
            Function.HeaderText = "F(X)";
            Function.Name = "Function";
            Function.Width = 50;
            // 
            // groupBoxOutPutResult_SYP
            // 
            groupBoxOutPutResult_SYP.Controls.Add(chartFunction_SYP);
            groupBoxOutPutResult_SYP.Controls.Add(dataGridViewFunction_SYP);
            groupBoxOutPutResult_SYP.Location = new Point(482, 12);
            groupBoxOutPutResult_SYP.Name = "groupBoxOutPutResult_SYP";
            groupBoxOutPutResult_SYP.Size = new Size(698, 347);
            groupBoxOutPutResult_SYP.TabIndex = 6;
            groupBoxOutPutResult_SYP.TabStop = false;
            groupBoxOutPutResult_SYP.Text = "Вывод данных";
            // 
            // chartFunction_SYP
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_SYP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_SYP.Legends.Add(legend1);
            chartFunction_SYP.Location = new Point(216, 22);
            chartFunction_SYP.Name = "chartFunction_SYP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_SYP.Series.Add(series1);
            chartFunction_SYP.Size = new Size(461, 300);
            chartFunction_SYP.TabIndex = 6;
            chartFunction_SYP.Text = "График функции";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 366);
            Controls.Add(buttonDoResult_SYP);
            Controls.Add(buttonDoHelp_SYP);
            Controls.Add(groupBoxInPutVarStep);
            Controls.Add(groupBoxTask_SYP);
            Controls.Add(groupBoxOutPutResult_SYP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 |  Гулиенко П. О. ";
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInPutVarStep.ResumeLayout(false);
            groupBoxInPutVarStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_SYP).EndInit();
            groupBoxOutPutResult_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_SYP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SYP;
        private Label labelTask_SYP;
        private PictureBox pictureBox1;
        private GroupBox groupBoxInPutVarStep;
        private Label labelStopStep_SYP;
        private Label labelStartEnd_SYP;
        private TextBox textBoxInPutStartStep_SYP;
        private TextBox textBoxInPutStopStep_SYP;
        private Button buttonDoHelp_SYP;
        private Button buttonDoResult_SYP;
        private DataGridView dataGridViewFunction_SYP;
        private GroupBox groupBoxOutPutResult_SYP;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Function;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SYP;
    }
}