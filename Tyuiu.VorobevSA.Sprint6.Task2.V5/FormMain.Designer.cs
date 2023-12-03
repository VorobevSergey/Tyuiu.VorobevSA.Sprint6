
namespace Tyuiu.VorobevSA.Sprint6.Task2.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxUslovie_VSA = new System.Windows.Forms.GroupBox();
            this.labelUslovie2_VSA = new System.Windows.Forms.Label();
            this.labelUslovie_VSA = new System.Windows.Forms.Label();
            this.groupBoxEnterDano_VSA = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_VSA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_VSA = new System.Windows.Forms.TextBox();
            this.labelStop_VSA = new System.Windows.Forms.Label();
            this.labelStart_VSA = new System.Windows.Forms.Label();
            this.groupBoxOutResult_VSA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_VSA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRezult_VSA = new System.Windows.Forms.Label();
            this.buttonHelp_VSA = new System.Windows.Forms.Button();
            this.buttonDane_VSA = new System.Windows.Forms.Button();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxFormula_VSA = new System.Windows.Forms.PictureBox();
            this.groupBoxUslovie_VSA.SuspendLayout();
            this.groupBoxEnterDano_VSA.SuspendLayout();
            this.groupBoxOutResult_VSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_VSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VSA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_VSA
            // 
            this.groupBoxUslovie_VSA.Controls.Add(this.pictureBoxFormula_VSA);
            this.groupBoxUslovie_VSA.Controls.Add(this.labelUslovie2_VSA);
            this.groupBoxUslovie_VSA.Controls.Add(this.labelUslovie_VSA);
            this.groupBoxUslovie_VSA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_VSA.Name = "groupBoxUslovie_VSA";
            this.groupBoxUslovie_VSA.Size = new System.Drawing.Size(511, 328);
            this.groupBoxUslovie_VSA.TabIndex = 0;
            this.groupBoxUslovie_VSA.TabStop = false;
            this.groupBoxUslovie_VSA.Text = "Условие";
            // 
            // labelUslovie2_VSA
            // 
            this.labelUslovie2_VSA.AutoSize = true;
            this.labelUslovie2_VSA.Location = new System.Drawing.Point(6, 35);
            this.labelUslovie2_VSA.Name = "labelUslovie2_VSA";
            this.labelUslovie2_VSA.Size = new System.Drawing.Size(242, 17);
            this.labelUslovie2_VSA.TabIndex = 0;
            this.labelUslovie2_VSA.Text = "результат вывести в виде таблици.";
            // 
            // labelUslovie_VSA
            // 
            this.labelUslovie_VSA.AutoSize = true;
            this.labelUslovie_VSA.Location = new System.Drawing.Point(6, 18);
            this.labelUslovie_VSA.Name = "labelUslovie_VSA";
            this.labelUslovie_VSA.Size = new System.Drawing.Size(359, 17);
            this.labelUslovie_VSA.TabIndex = 0;
            this.labelUslovie_VSA.Text = "Протабулировать функцию на заданном диапазоне: ";
            // 
            // groupBoxEnterDano_VSA
            // 
            this.groupBoxEnterDano_VSA.Controls.Add(this.textBoxStopValue_VSA);
            this.groupBoxEnterDano_VSA.Controls.Add(this.textBoxStartValue_VSA);
            this.groupBoxEnterDano_VSA.Controls.Add(this.labelStop_VSA);
            this.groupBoxEnterDano_VSA.Controls.Add(this.labelStart_VSA);
            this.groupBoxEnterDano_VSA.Location = new System.Drawing.Point(12, 347);
            this.groupBoxEnterDano_VSA.Name = "groupBoxEnterDano_VSA";
            this.groupBoxEnterDano_VSA.Size = new System.Drawing.Size(276, 100);
            this.groupBoxEnterDano_VSA.TabIndex = 1;
            this.groupBoxEnterDano_VSA.TabStop = false;
            this.groupBoxEnterDano_VSA.Text = "Ввод данных";
            // 
            // textBoxStopValue_VSA
            // 
            this.textBoxStopValue_VSA.Location = new System.Drawing.Point(145, 52);
            this.textBoxStopValue_VSA.Name = "textBoxStopValue_VSA";
            this.textBoxStopValue_VSA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopValue_VSA.TabIndex = 3;
            // 
            // textBoxStartValue_VSA
            // 
            this.textBoxStartValue_VSA.Location = new System.Drawing.Point(9, 52);
            this.textBoxStartValue_VSA.Name = "textBoxStartValue_VSA";
            this.textBoxStartValue_VSA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartValue_VSA.TabIndex = 2;
            // 
            // labelStop_VSA
            // 
            this.labelStop_VSA.AutoSize = true;
            this.labelStop_VSA.Location = new System.Drawing.Point(142, 22);
            this.labelStop_VSA.Name = "labelStop_VSA";
            this.labelStop_VSA.Size = new System.Drawing.Size(85, 17);
            this.labelStop_VSA.TabIndex = 1;
            this.labelStop_VSA.Text = "Конец шага";
            // 
            // labelStart_VSA
            // 
            this.labelStart_VSA.AutoSize = true;
            this.labelStart_VSA.Location = new System.Drawing.Point(9, 22);
            this.labelStart_VSA.Name = "labelStart_VSA";
            this.labelStart_VSA.Size = new System.Drawing.Size(83, 17);
            this.labelStart_VSA.TabIndex = 0;
            this.labelStart_VSA.Text = "Старт шага";
            // 
            // groupBoxOutResult_VSA
            // 
            this.groupBoxOutResult_VSA.Controls.Add(this.dataGridViewFunction_VSA);
            this.groupBoxOutResult_VSA.Controls.Add(this.labelRezult_VSA);
            this.groupBoxOutResult_VSA.Location = new System.Drawing.Point(530, 13);
            this.groupBoxOutResult_VSA.Name = "groupBoxOutResult_VSA";
            this.groupBoxOutResult_VSA.Size = new System.Drawing.Size(211, 425);
            this.groupBoxOutResult_VSA.TabIndex = 2;
            this.groupBoxOutResult_VSA.TabStop = false;
            this.groupBoxOutResult_VSA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_VSA
            // 
            this.dataGridViewFunction_VSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_VSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_VSA.Location = new System.Drawing.Point(10, 43);
            this.dataGridViewFunction_VSA.Name = "dataGridViewFunction_VSA";
            this.dataGridViewFunction_VSA.RowHeadersVisible = false;
            this.dataGridViewFunction_VSA.RowHeadersWidth = 51;
            this.dataGridViewFunction_VSA.RowTemplate.Height = 24;
            this.dataGridViewFunction_VSA.Size = new System.Drawing.Size(195, 376);
            this.dataGridViewFunction_VSA.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // labelRezult_VSA
            // 
            this.labelRezult_VSA.AutoSize = true;
            this.labelRezult_VSA.Location = new System.Drawing.Point(7, 22);
            this.labelRezult_VSA.Name = "labelRezult_VSA";
            this.labelRezult_VSA.Size = new System.Drawing.Size(76, 17);
            this.labelRezult_VSA.TabIndex = 0;
            this.labelRezult_VSA.Text = "Результат";
            // 
            // buttonHelp_VSA
            // 
            this.buttonHelp_VSA.Location = new System.Drawing.Point(294, 356);
            this.buttonHelp_VSA.Name = "buttonHelp_VSA";
            this.buttonHelp_VSA.Size = new System.Drawing.Size(90, 91);
            this.buttonHelp_VSA.TabIndex = 3;
            this.buttonHelp_VSA.Text = "Справка";
            this.buttonHelp_VSA.UseVisualStyleBackColor = true;
            this.buttonHelp_VSA.Click += new System.EventHandler(this.buttonHelp_VSA_Click);
            // 
            // buttonDane_VSA
            // 
            this.buttonDane_VSA.Location = new System.Drawing.Point(390, 356);
            this.buttonDane_VSA.Name = "buttonDane_VSA";
            this.buttonDane_VSA.Size = new System.Drawing.Size(133, 91);
            this.buttonDane_VSA.TabIndex = 4;
            this.buttonDane_VSA.Text = "Выполнить";
            this.buttonDane_VSA.UseVisualStyleBackColor = true;
            this.buttonDane_VSA.Click += new System.EventHandler(this.buttonDane_VSA_Click);
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction.Legends.Add(legend2);
            this.chartFunction.Location = new System.Drawing.Point(749, 13);
            this.chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction.Series.Add(series2);
            this.chartFunction.Size = new System.Drawing.Size(585, 419);
            this.chartFunction.TabIndex = 5;
            this.chartFunction.Text = "chart1";
            // 
            // pictureBoxFormula_VSA
            // 
            this.pictureBoxFormula_VSA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_VSA.Image")));
            this.pictureBoxFormula_VSA.Location = new System.Drawing.Point(0, 55);
            this.pictureBoxFormula_VSA.Name = "pictureBoxFormula_VSA";
            this.pictureBoxFormula_VSA.Size = new System.Drawing.Size(287, 46);
            this.pictureBoxFormula_VSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_VSA.TabIndex = 1;
            this.pictureBoxFormula_VSA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 450);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.buttonDane_VSA);
            this.Controls.Add(this.buttonHelp_VSA);
            this.Controls.Add(this.groupBoxOutResult_VSA);
            this.Controls.Add(this.groupBoxEnterDano_VSA);
            this.Controls.Add(this.groupBoxUslovie_VSA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxUslovie_VSA.ResumeLayout(false);
            this.groupBoxUslovie_VSA.PerformLayout();
            this.groupBoxEnterDano_VSA.ResumeLayout(false);
            this.groupBoxEnterDano_VSA.PerformLayout();
            this.groupBoxOutResult_VSA.ResumeLayout(false);
            this.groupBoxOutResult_VSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_VSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_VSA;
        private System.Windows.Forms.GroupBox groupBoxEnterDano_VSA;
        private System.Windows.Forms.GroupBox groupBoxOutResult_VSA;
        private System.Windows.Forms.Label labelUslovie_VSA;
        private System.Windows.Forms.Label labelStop_VSA;
        private System.Windows.Forms.Label labelStart_VSA;
        private System.Windows.Forms.Label labelRezult_VSA;
        private System.Windows.Forms.TextBox textBoxStopValue_VSA;
        private System.Windows.Forms.TextBox textBoxStartValue_VSA;
        private System.Windows.Forms.Button buttonHelp_VSA;
        private System.Windows.Forms.Button buttonDane_VSA;
        private System.Windows.Forms.Label labelUslovie2_VSA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction_VSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBoxFormula_VSA;
    }
}

