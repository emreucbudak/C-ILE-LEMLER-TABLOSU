namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b,toplam,cikarma,bolme,carpma;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            toplam = a + b;
            cikarma = a - b;
            bolme = a / b;
            carpma = a * b;
            label3.Text = toplam.ToString();
            label8.Text = cikarma.ToString();
            label9.Text = bolme.ToString();
            label10.Text = carpma.ToString();
            MessageBox.Show("Ýþlemler Baþarýyla Gerçekleþti");

        }
    }
}
