
namespace Tyuiu.VorobevSA.Sprint6.Task0.V24
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
            this.groupBoxUslovie_VSA = new System.Windows.Forms.GroupBox();
            this.labelUslovie = new System.Windows.Forms.Label();
            this.groupBoxEnterDano_VSA = new System.Windows.Forms.GroupBox();
            this.labelVarA_VSA = new System.Windows.Forms.Label();
            this.textBoxVarX_VSA = new System.Windows.Forms.TextBox();
            this.groupBoxOutResult_VSA = new System.Windows.Forms.GroupBox();
            this.textBoxResaut_VSA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDane_VSA = new System.Windows.Forms.Button();
            this.buttonHelp_VSA = new System.Windows.Forms.Button();
            this.groupBoxUslovie_VSA.SuspendLayout();
            this.groupBoxEnterDano_VSA.SuspendLayout();
            this.groupBoxOutResult_VSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_VSA
            // 
            this.groupBoxUslovie_VSA.Controls.Add(this.labelUslovie);
            this.groupBoxUslovie_VSA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_VSA.Name = "groupBoxUslovie_VSA";
            this.groupBoxUslovie_VSA.Size = new System.Drawing.Size(486, 196);
            this.groupBoxUslovie_VSA.TabIndex = 0;
            this.groupBoxUslovie_VSA.TabStop = false;
            this.groupBoxUslovie_VSA.Text = "Условие";
            // 
            // labelUslovie
            // 
            this.labelUslovie.AutoSize = true;
            this.labelUslovie.Location = new System.Drawing.Point(6, 18);
            this.labelUslovie.Name = "labelUslovie";
            this.labelUslovie.Size = new System.Drawing.Size(241, 17);
            this.labelUslovie.TabIndex = 1;
            this.labelUslovie.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxEnterDano_VSA
            // 
            this.groupBoxEnterDano_VSA.Controls.Add(this.labelVarA_VSA);
            this.groupBoxEnterDano_VSA.Controls.Add(this.textBoxVarX_VSA);
            this.groupBoxEnterDano_VSA.Location = new System.Drawing.Point(13, 216);
            this.groupBoxEnterDano_VSA.Name = "groupBoxEnterDano_VSA";
            this.groupBoxEnterDano_VSA.Size = new System.Drawing.Size(486, 163);
            this.groupBoxEnterDano_VSA.TabIndex = 1;
            this.groupBoxEnterDano_VSA.TabStop = false;
            this.groupBoxEnterDano_VSA.Text = "Ввод данных";
            // 
            // labelVarA_VSA
            // 
            this.labelVarA_VSA.AutoSize = true;
            this.labelVarA_VSA.Location = new System.Drawing.Point(6, 47);
            this.labelVarA_VSA.Name = "labelVarA_VSA";
            this.labelVarA_VSA.Size = new System.Drawing.Size(25, 17);
            this.labelVarA_VSA.TabIndex = 1;
            this.labelVarA_VSA.Text = "X=";
            // 
            // textBoxVarX_VSA
            // 
            this.textBoxVarX_VSA.Location = new System.Drawing.Point(37, 44);
            this.textBoxVarX_VSA.Name = "textBoxVarX_VSA";
            this.textBoxVarX_VSA.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_VSA.TabIndex = 0;
            this.textBoxVarX_VSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_VSA_KeyPress);
            // 
            // groupBoxOutResult_VSA
            // 
            this.groupBoxOutResult_VSA.Controls.Add(this.textBoxResaut_VSA);
            this.groupBoxOutResult_VSA.Location = new System.Drawing.Point(506, 216);
            this.groupBoxOutResult_VSA.Name = "groupBoxOutResult_VSA";
            this.groupBoxOutResult_VSA.Size = new System.Drawing.Size(282, 163);
            this.groupBoxOutResult_VSA.TabIndex = 2;
            this.groupBoxOutResult_VSA.TabStop = false;
            this.groupBoxOutResult_VSA.Text = "Вывод данных";
            // 
            // textBoxResaut_VSA
            // 
            this.textBoxResaut_VSA.Location = new System.Drawing.Point(6, 44);
            this.textBoxResaut_VSA.Name = "textBoxResaut_VSA";
            this.textBoxResaut_VSA.ReadOnly = true;
            this.textBoxResaut_VSA.Size = new System.Drawing.Size(100, 22);
            this.textBoxResaut_VSA.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDane_VSA
            // 
            this.buttonDane_VSA.Location = new System.Drawing.Point(563, 386);
            this.buttonDane_VSA.Name = "buttonDane_VSA";
            this.buttonDane_VSA.Size = new System.Drawing.Size(225, 52);
            this.buttonDane_VSA.TabIndex = 3;
            this.buttonDane_VSA.Text = "Выполнить";
            this.buttonDane_VSA.UseVisualStyleBackColor = true;
            this.buttonDane_VSA.Click += new System.EventHandler(this.buttonDane_VSA_Click);
            // 
            // buttonHelp_VSA
            // 
            this.buttonHelp_VSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_VSA.Location = new System.Drawing.Point(506, 386);
            this.buttonHelp_VSA.Name = "buttonHelp_VSA";
            this.buttonHelp_VSA.Size = new System.Drawing.Size(51, 52);
            this.buttonHelp_VSA.TabIndex = 4;
            this.buttonHelp_VSA.Text = "?";
            this.buttonHelp_VSA.UseVisualStyleBackColor = true;
            this.buttonHelp_VSA.Click += new System.EventHandler(this.buttonHelp_VSA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_VSA);
            this.Controls.Add(this.buttonDane_VSA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxOutResult_VSA);
            this.Controls.Add(this.groupBoxEnterDano_VSA);
            this.Controls.Add(this.groupBoxUslovie_VSA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант24 | Воробьев С.А.";
            this.groupBoxUslovie_VSA.ResumeLayout(false);
            this.groupBoxUslovie_VSA.PerformLayout();
            this.groupBoxEnterDano_VSA.ResumeLayout(false);
            this.groupBoxEnterDano_VSA.PerformLayout();
            this.groupBoxOutResult_VSA.ResumeLayout(false);
            this.groupBoxOutResult_VSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_VSA;
        private System.Windows.Forms.GroupBox groupBoxEnterDano_VSA;
        private System.Windows.Forms.GroupBox groupBoxOutResult_VSA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUslovie;
        private System.Windows.Forms.Label labelVarA_VSA;
        private System.Windows.Forms.TextBox textBoxVarX_VSA;
        private System.Windows.Forms.TextBox textBoxResaut_VSA;
        private System.Windows.Forms.Button buttonDane_VSA;
        private System.Windows.Forms.Button buttonHelp_VSA;
    }
}

