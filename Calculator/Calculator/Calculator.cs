using System.Data;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private string calculate = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonClick(object sender, EventArgs e)
        {
            calculate += (sender as Button).Text;
            display.Text = calculate;
        }
        private void EqualButton(object sender, EventArgs e)
        {
            string finalCalculation = calculate.ToString();

            try
            {
                display.Text = new DataTable().Compute(finalCalculation, null).ToString();
                calculate = display.Text;
            }
            catch (Exception ex)
            {
                display.Text = "0";
                calculate = "";
            }
        }
        private void ClearButton(object sender, EventArgs e)
        {
            display.Text = "0";
            calculate = "";
        }
        private void ClearEntry(object sender, EventArgs e)
        {
            if (calculate.Length > 0)
            {
                calculate = calculate.Remove(calculate.Length - 1, 1);
            }
            display.Text = calculate;
        }
        private void display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}