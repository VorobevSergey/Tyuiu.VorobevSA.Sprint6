using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VorobevSA.Sprint6.Task3.V5.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        int[,] matrix={ { 30,-20,7,-8,9},
                        { 32,17,-14,-7,33},
                        { 19,-19,-13,14,-20},
                        { 11,30,-1,26,6},
                        { 30,-15,-20,-5,15} };
        DataService service1 = new DataService();
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewFunction_VSA.RowCount = matrix.GetLength(0);
            dataGridViewFunction_VSA.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < dataGridViewFunction_VSA.ColumnCount; i++)
            {
                dataGridViewFunction_VSA.Columns[i].Width = 25;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewFunction_VSA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        
        private void buttonDane_VSA_Click(object sender, EventArgs e)
        {
            matrix = service1.Calculate(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewFunction_VSA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonHelp_VSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Выполнил студент группы ПКТб 23-2 Воробьев Сергей Александрович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
