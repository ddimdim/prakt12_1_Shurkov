using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            string fio = textBox1.Text;
            if (fio == "")
                MessageBox.Show("Введите фимилию и имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (fio != "")
            {
                foreach (char k in textBox1.Text)
                {
                    if (!char.IsLetter(k) && !char.IsWhiteSpace(k))
                    {
                        MessageBox.Show("Вводите буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        num++;
                        break;
                    }
                }
            }
            if (num==0 && fio != "")
            {
                Student stud = new Student();
                stud.name = textBox1.Text;
                stud.rost = (int)numericUpDown1.Value;
                double eda;
                MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()), "На данный момент");
                eda = 1;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()), "Съел 1 кг");
                eda = 5;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()), "Съел 5 кг");
                eda = 7;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()), "Съел 7 кг");
                eda = 11;
                stud.SetEat(eda);
                MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()), "Съел 11 кг");
            }
        }
    }
}
