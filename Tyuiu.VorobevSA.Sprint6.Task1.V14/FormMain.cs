using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VorobevSA.Sprint6.Task1.V14.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task1.V14
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
                int stopStep= Convert.ToInt32(textBoxStopValue_VSA.Text);

                string strLine;

                int len = service1.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = service1.GetMassFunction(startStep, stopStep);
                textBoxRezult_VSA.Text = "";
                textBoxRezult_VSA.AppendText("+-------+------------+" + Environment.NewLine);
                textBoxRezult_VSA.AppendText(" |   X   |  f(x)      |" + Environment.NewLine);
                textBoxRezult_VSA.AppendText("+-------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format(" |{0,5:d}   | {1,7:f2}|", startStep, valueArray[i]);
                    textBoxRezult_VSA.AppendText(strLine + Environment.NewLine);
                    startStep ++;               
                }
                textBoxRezult_VSA.AppendText("+-------+------------+" + Environment.NewLine);

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
