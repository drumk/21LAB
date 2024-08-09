namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Input n", "Data Input", "0");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Input n", "Data Input", "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(textBox1.Text);
            double s = 1;

            for (int i = 0; i <= n; i++)
            {
                double m = Math.Pow(-1, i) * Math.Pow(i, 3);
                s *= m;
            }

            MessageBox.Show("S = " + Convert.ToString(s), "Результат:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }
    }
}