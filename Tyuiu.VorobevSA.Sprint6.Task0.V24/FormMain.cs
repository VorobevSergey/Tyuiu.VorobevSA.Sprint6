using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VorobevSA.Sprint6.Task0.V24.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDane_VSA_Click(object sender, EventArgs e)
        {
            DataService service1 = new DataService();
            try
            {
                textBoxResaut_VSA.Text = Convert.ToString(service1.Calculate(Convert.ToInt32(textBoxVarX_VSA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_VSA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 45) && (e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_VSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Выполнил студент группы ПКТб 23-2 Воробьев Сергей Александрович", "Сообщение",MessageBoxButtons.OK);
        }
    }
}
