namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = "3,251";
            textBox2.Text = "0,325";
            textBox3.Text = "0,0000466";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "x = " + x.ToString();

            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "y = " + y.ToString();

            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "z = " + z.ToString();

            double a = Math.Pow(2, Math.Pow(y, x)) + Math.Pow(Math.Pow(3, x), y);
            double b = y * (Math.Atan(z) - (Math.PI / 6));
            double d = Math.Abs(x) - (1 / (Math.Pow(y, 2) + 1));
            double c = a - b/d;
            textBox4.Text += Environment.NewLine + "Результат С =" + c.ToString(); 



        }
    }
}