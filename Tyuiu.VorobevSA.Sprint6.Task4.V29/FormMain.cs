using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.VorobevSA.Sprint6.Task4.V29.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task4.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService service1 = new DataService();

        private void buttonDane_VSA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_VSA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_VSA.Text);

                int len = service1.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = service1.GetMassFunction(startValue, stopValue);

                this.chartFunction_VSA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VSA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_VSA.Text = "";

                chartFunction_VSA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_VSA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult_VSA.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_VSA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V29.txt";
                File.WriteAllText(path, textBoxResult_VSA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dialogResult== DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.Start();

                }

            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Выполнил студент группы ПКТб 23-2 Воробьев Сергей Александрович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
