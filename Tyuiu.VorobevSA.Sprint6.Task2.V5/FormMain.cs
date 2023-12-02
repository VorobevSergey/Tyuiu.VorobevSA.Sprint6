using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VorobevSA.Sprint6.Task2.V5.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task2.V5
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
                int startStep = Convert.ToInt32(textBoxStartValue_VSA.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_VSA.Text);
                int len = service1.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = service1.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функции");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for(int i=0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_VSA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Выполнил студент группы ПКТб 23-2 Воробьев Сергей Александрович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
