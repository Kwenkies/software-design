namespace Recursive_Power_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double PowerCalculation(double x, double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return x * PowerCalculation(x, n - 1);
            }
            else
            {
                return 1 / (x * PowerCalculation(x, -n - 1));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX.Text);
            double n = Convert.ToInt32(textBoxN.Text);
            double result = PowerCalculation(x, n);
            labelResult.Text = $"Result : {result}";
        }

    }
}
