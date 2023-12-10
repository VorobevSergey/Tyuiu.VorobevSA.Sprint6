
namespace Tyuiu.VorobevSA.Sprint6.Task6.V6
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
            this.buttonOpenFail_VSA = new System.Windows.Forms.Button();
            this.buttonDane_VSA = new System.Windows.Forms.Button();
            this.buttonHelp_VSA = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxUslovie_VSA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxResult_VSA = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_VSA.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFail_VSA
            // 
            this.buttonOpenFail_VSA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFail_VSA.Image")));
            this.buttonOpenFail_VSA.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFail_VSA.Name = "buttonOpenFail_VSA";
            this.buttonOpenFail_VSA.Size = new System.Drawing.Size(75, 75);
            this.buttonOpenFail_VSA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpenFail_VSA, "Нажми чтобы выбрать файл");
            this.buttonOpenFail_VSA.UseVisualStyleBackColor = true;
            this.buttonOpenFail_VSA.Click += new System.EventHandler(this.buttonOpenFail_VSA_Click);
            // 
            // buttonDane_VSA
            // 
            this.buttonDane_VSA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDane_VSA.Image")));
            this.buttonDane_VSA.Location = new System.Drawing.Point(94, 12);
            this.buttonDane_VSA.Name = "buttonDane_VSA";
            this.buttonDane_VSA.Size = new System.Drawing.Size(75, 75);
            this.buttonDane_VSA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonDane_VSA, "Запустить выполнение условия");
            this.buttonDane_VSA.UseVisualStyleBackColor = true;
            this.buttonDane_VSA.Click += new System.EventHandler(this.buttonDane_VSA_Click);
            // 
            // buttonHelp_VSA
            // 
            this.buttonHelp_VSA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_VSA.Image")));
            this.buttonHelp_VSA.Location = new System.Drawing.Point(713, 12);
            this.buttonHelp_VSA.Name = "buttonHelp_VSA";
            this.buttonHelp_VSA.Size = new System.Drawing.Size(75, 75);
            this.buttonHelp_VSA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonHelp_VSA, "Информация о производителе");
            this.buttonHelp_VSA.UseVisualStyleBackColor = true;
            this.buttonHelp_VSA.Click += new System.EventHandler(this.buttonHelp_VSA_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // groupBoxUslovie_VSA
            // 
            this.groupBoxUslovie_VSA.Controls.Add(this.label1);
            this.groupBoxUslovie_VSA.Location = new System.Drawing.Point(13, 95);
            this.groupBoxUslovie_VSA.Name = "groupBoxUslovie_VSA";
            this.groupBoxUslovie_VSA.Size = new System.Drawing.Size(775, 79);
            this.groupBoxUslovie_VSA.TabIndex = 1;
            this.groupBoxUslovie_VSA.TabStop = false;
            this.groupBoxUslovie_VSA.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Location = new System.Drawing.Point(16, 180);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(385, 258);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(7, 22);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(378, 236);
            this.textBoxInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxResult_VSA);
            this.groupBox2.Location = new System.Drawing.Point(407, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // textBoxResult_VSA
            // 
            this.textBoxResult_VSA.Location = new System.Drawing.Point(0, 22);
            this.textBoxResult_VSA.Multiline = true;
            this.textBoxResult_VSA.Name = "textBoxResult_VSA";
            this.textBoxResult_VSA.ReadOnly = true;
            this.textBoxResult_VSA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_VSA.Size = new System.Drawing.Size(381, 236);
            this.textBoxResult_VSA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxUslovie_VSA);
            this.Controls.Add(this.buttonHelp_VSA);
            this.Controls.Add(this.buttonDane_VSA);
            this.Controls.Add(this.buttonOpenFail_VSA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 6 | Воробьев С.А.";
            this.groupBoxUslovie_VSA.ResumeLayout(false);
            this.groupBoxUslovie_VSA.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFail_VSA;
        private System.Windows.Forms.Button buttonDane_VSA;
        private System.Windows.Forms.Button buttonHelp_VSA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.GroupBox groupBoxUslovie_VSA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxResult_VSA;
    }
}

