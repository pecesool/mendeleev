using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mendeleev
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablica s = new tablica();
            s.Show();
            Hide();//переход на другую форму
        }

        private void button2_Click(object sender, EventArgs e)
        {//изменение шрифта
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//изменение цвет а шрифта
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {//справка о программе
            richTextBox1.Text = "Здравствуйте " + name.neme + "\n\n" + "Приложение было реализовано для расчета количества вещества элементов из группы щелочных металлов. \nЩелочны́е мета́ллы — элементы 1 - й группы периодической таблицы химических элементов.При растворении щелочных металлов в воде образуются растворимые гидроксиды, называемые щелочами. \n\nПрограмма реализована в Visual Studio 2019 \nВерсия программы 1.0 ";
        }
    }
}
