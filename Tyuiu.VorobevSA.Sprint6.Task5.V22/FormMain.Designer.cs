
namespace Tyuiu.VorobevSA.Sprint6.Task5.V22
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
            this.groupBoxUslovie_VSA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDane_VSA = new System.Windows.Forms.Button();
            this.buttonOpenFile_VSA = new System.Windows.Forms.Button();
            this.buttonHelp_VSA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartFunction_VSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewData_VSA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxUslovie_VSA.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_VSA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_VSA
            // 
            this.groupBoxUslovie_VSA.Controls.Add(this.label2);
            this.groupBoxUslovie_VSA.Controls.Add(this.label1);
            this.groupBoxUslovie_VSA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_VSA.Name = "groupBoxUslovie_VSA";
            this.groupBoxUslovie_VSA.Size = new System.Drawing.Size(554, 100);
            this.groupBoxUslovie_VSA.TabIndex = 0;
            this.groupBoxUslovie_VSA.TabStop = false;
            this.groupBoxUslovie_VSA.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в dataGridView_VSA";
            // 
            // buttonDane_VSA
            // 
            this.buttonDane_VSA.Location = new System.Drawing.Point(579, 14);
            this.buttonDane_VSA.Name = "buttonDane_VSA";
            this.buttonDane_VSA.Size = new System.Drawing.Size(105, 100);
            this.buttonDane_VSA.TabIndex = 1;
            this.buttonDane_VSA.Text = "Выполнить";
            this.buttonDane_VSA.UseVisualStyleBackColor = true;
            this.buttonDane_VSA.Click += new System.EventHandler(this.buttonDane_VSA_Click);
            // 
            // buttonOpenFile_VSA
            // 
            this.buttonOpenFile_VSA.Location = new System.Drawing.Point(690, 14);
            this.buttonOpenFile_VSA.Name = "buttonOpenFile_VSA";
            this.buttonOpenFile_VSA.Size = new System.Drawing.Size(91, 100);
            this.buttonOpenFile_VSA.TabIndex = 1;
            this.buttonOpenFile_VSA.Text = "Открыть Файл";
            this.buttonOpenFile_VSA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_VSA.Click += new System.EventHandler(this.buttonOpenFile_VSA_Click);
            // 
            // buttonHelp_VSA
            // 
            this.buttonHelp_VSA.Location = new System.Drawing.Point(787, 13);
            this.buttonHelp_VSA.Name = "buttonHelp_VSA";
            this.buttonHelp_VSA.Size = new System.Drawing.Size(91, 100);
            this.buttonHelp_VSA.TabIndex = 1;
            this.buttonHelp_VSA.Text = "Справка";
            this.buttonHelp_VSA.UseVisualStyleBackColor = true;
            this.buttonHelp_VSA.Click += new System.EventHandler(this.buttonHelp_VSA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewData_VSA);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 432);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // chartFunction_VSA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_VSA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_VSA.Legends.Add(legend2);
            this.chartFunction_VSA.Location = new System.Drawing.Point(220, 120);
            this.chartFunction_VSA.Name = "chartFunction_VSA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_VSA.Series.Add(series2);
            this.chartFunction_VSA.Size = new System.Drawing.Size(644, 432);
            this.chartFunction_VSA.TabIndex = 3;
            this.chartFunction_VSA.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "числа больше 5 и построить диаграмму с этими значениями";
            // 
            // dataGridViewData_VSA
            // 
            this.dataGridViewData_VSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_VSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewData_VSA.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewData_VSA.Name = "dataGridViewData_VSA";
            this.dataGridViewData_VSA.RowHeadersVisible = false;
            this.dataGridViewData_VSA.RowHeadersWidth = 51;
            this.dataGridViewData_VSA.RowTemplate.Height = 24;
            this.dataGridViewData_VSA.Size = new System.Drawing.Size(187, 404);
            this.dataGridViewData_VSA.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 564);
            this.Controls.Add(this.chartFunction_VSA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonHelp_VSA);
            this.Controls.Add(this.buttonOpenFile_VSA);
            this.Controls.Add(this.buttonDane_VSA);
            this.Controls.Add(this.groupBoxUslovie_VSA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 | Воробьев С.А.";
            this.groupBoxUslovie_VSA.ResumeLayout(false);
            this.groupBoxUslovie_VSA.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_VSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_VSA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDane_VSA;
        private System.Windows.Forms.Button buttonOpenFile_VSA;
        private System.Windows.Forms.Button buttonHelp_VSA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VSA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewData_VSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

