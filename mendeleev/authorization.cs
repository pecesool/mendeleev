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
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();//выход
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")//проверка логина и пароля
            {
                name.neme = textBox1.Text;//сохранение в глобальную переменную логина пользователя для отображения его в другой форме
                axWindowsMediaPlayer1.Ctlcontrols.play();//запуск медиа плеера
                main s = new main();
                s.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста повторите попытку", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = String.Empty;//уведомление об ошибке и очистка полей
                textBox2.Text = String.Empty;
                
            }
        }

        private void authorization_Load(object sender, EventArgs e)
        {

        }
    }
    static class name//объявление глобальной перменной
    {
        public static string neme { get; set; }

    }
}
