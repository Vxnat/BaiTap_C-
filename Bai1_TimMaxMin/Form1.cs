namespace Bai1_TimMaxMin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNumber1.Text);
            int b = int.Parse(txtNumber2.Text);
            int c = int.Parse(txtNumber3.Text);

            int[]number = { a, b, c };

            int min = number.Min();
            int max = number.Max();

            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();
        }
    }
}
