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
    public partial class tablica : Form
    {
        public tablica()
        {
            InitializeComponent();
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main s = new main();
            s.Show();
            Hide();//переход в меню
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int li, na, ka, rb, cs, fr;//обхявление глобальной перемене

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox4.Text);
            int mass = 0;
            try { mass = Convert.ToInt32(textBox4.Text); }
            catch { MessageBox.Show("Масса должна быть числового типа"); }
            if (mass >= 0)
            {
                for (int i = 0; i < n; i++) { fr= fr + mass * 223; }
                label4.Text = "Кол. Вещества " + fr.ToString();
            }
            else { MessageBox.Show("Масса не может быть отрицательной"); }
            //расчет и проверка правильности ввода данных
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox4.Text);
            int mass = 0;
            try { mass = Convert.ToInt32(textBox4.Text); }
            catch { MessageBox.Show("Масса должна быть числового типа"); }
            if (mass >= 0)
            {
                for (int i = 0; i < n; i++) { cs = cs + mass * 133; }
                label4.Text = "Кол. Вещества " + cs.ToString();
            }
            else { MessageBox.Show("Масса не может быть отрицательной"); }
            //расчет и проверка правильности ввода данных
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int res=0;
            if (checkBox1.Checked == true) { res = res + li; }
            if (checkBox2.Checked == true) { res = res + na; }
            if (checkBox3.Checked == true) { res = res + ka; }
            if (checkBox4.Checked == true) { res = res + rb; }
            if (checkBox5.Checked == true) { res = res + cs; }
            if (checkBox6.Checked == true) { res = res + fr; }
            label16.Text = "Итого" + res.ToString();//длинный коментарий
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox5.Text);
            int mass = 0;
            try { mass = Convert.ToInt32(textBox4.Text); }
            catch { MessageBox.Show("Масса должна быть числового типа"); }
            if (mass >= 0)
            {
                for (int i = 0; i < n; i++) { cs = cs + mass * 85; }
                label13.Text = "Кол. Вещества " + cs.ToString();
            }
            else { MessageBox.Show("Масса не может быть отрицательной"); }
            //расчет и проверка правильности ввода данных
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox3.Text);
            int mass = 0;
            try { mass = Convert.ToInt32(textBox3.Text); }
            catch { MessageBox.Show("Масса должна быть числового типа"); }
            if (mass >= 0)
            {
                for (int i = 0; i < n; i++) { ka = ka + mass * 40; }
                label3.Text = "Кол. Вещества " + ka.ToString();
            }
            else { MessageBox.Show("Масса не может быть отрицательной"); }
            //расчет и проверка правильности ввода данных
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox2.Text);
            int mass = 0;
            try { mass = Convert.ToInt32(textBox2.Text); }
            catch { MessageBox.Show("Масса должна быть числового типа"); }
            if (mass >= 0)
            {
                for (int i = 0; i < n; i++) { na = na + mass * 23; }
                label7.Text = "Кол. Вещества " + na.ToString();
            }
            else { MessageBox.Show("Масса не может быть отрицательной"); }
            //расчет и проверка правильности ввода данных
        }

        private void tablica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { //расчет и проверка правильности ввода данных
            int n = Convert.ToInt32(comboBox1.Text);
            int mass=0;
            try { mass = Convert.ToInt32(textBox1.Text); }
            catch { MessageBox.Show("Масса должна быть числового типа"); }
            if (mass >= 0) 
            {
                for (int i = 0; i < n; i++) { li = li + mass * 7; }
                label4.Text = "Кол. Вещества " + li.ToString();
            }
            else { MessageBox.Show("Масса не может быть отрицательной"); }

        }
    }
}
