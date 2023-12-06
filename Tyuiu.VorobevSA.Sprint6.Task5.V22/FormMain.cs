using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VorobevSA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService service1 = new DataService();
        private static readonly string path = @"C:\DataSprint5\InPutFileTask5V22.txt";
        private void buttonDane_VSA_Click(object sender, EventArgs e)
        {

            dataGridViewData_VSA.Rows.Clear();
            chartFunction_VSA.Series[0].Points.Clear();

            dataGridViewData_VSA.ColumnCount = 2;
            dataGridViewData_VSA.Columns[0].Width = 20;
            dataGridViewData_VSA.Columns[1].Width = 50;

            chartFunction_VSA.ChartAreas[0].AxisX.Title = "Ось X";
            chartFunction_VSA.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] serviceArray = service1.LoadFromDataFile(path);
            for (int i = 0; i < serviceArray.Length; i++)
            {
                dataGridViewData_VSA.Rows.Add(i + 1, serviceArray[i]);
                chartFunction_VSA.Series[0].Points.AddXY(i, serviceArray[i]);
            }
        }

        private void buttonOpenFile_VSA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_VSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб 23-2 Воробьев С.А.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
