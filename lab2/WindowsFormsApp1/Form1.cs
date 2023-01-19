using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double x, y, z;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X
            textBox1.Text = "17,421";
            // Начальное значение Y
            textBox2.Text = "0,010365";
            // Начальное значение Z
            textBox3.Text = "82800";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch
            { MessageBox.Show("Некорректное значение x. Попробуйте еще раз."); }

            try
            {

                y = Convert.ToDouble(textBox2.Text);
            }
            catch { MessageBox.Show("Некорректное значение y. Попробуйте еще раз."); }
         
            try
            {
                z = Convert.ToDouble(textBox3.Text);
            }
            catch { MessageBox.Show("Некорректное значение z. Попробуйте еще раз."); }

            double f = (Math.Pow(y + Math.Pow(x-1,1.0/3.0),1.0/4.0)) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z),2) + Math.Tan(z))) ;
    
           


            if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")) // проверка на то введены ли значения
            {
                textBox4.Text += Environment.NewLine + "Значение x = " + x.ToString();
                textBox4.Text += Environment.NewLine + "Значение y = " + y.ToString();
                textBox4.Text += Environment.NewLine + "Значение z = " + z.ToString();
                textBox4.Text += Environment.NewLine + "Результат f = " + f.ToString();
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми");
            }
            
        }
    }
}
