namespace Bai2_TinhTongN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int sum = 0;
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                result += i.ToString();
                if (i < n)
                {
                    result += "+";
                }
            }
            txtDetail.Text = result;
            txtSum.Text = sum.ToString();
        }
    }
}
