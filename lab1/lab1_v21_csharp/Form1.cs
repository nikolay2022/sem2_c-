namespace lab1_v21_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox3.Text;
        }
    }
}