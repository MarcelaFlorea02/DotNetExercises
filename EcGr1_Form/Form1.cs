namespace EcGr1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(textBox1.Text);
            if (a == 0)
            {
                MessageBox.Show("a nu poate fi 0!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                decimal b = decimal.Parse(textBox2.Text);

                var x = -b / a;

                var t="abc";

                MessageBox.Show($"Solutia ecuatiei este x={x}");
            }
        }

 
    }
}
