namespace Task3_RecursiveFibonacciSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Function for Fibonacci 
        public int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtFibonacciInput.Text);
            int result = RecursiveFibonacci(n);
            lblFibonacciResult.Text = $"Fibonacci: {result}";
        }

        // Function to calculate x^n 
        public int RecursivePower(int x, int n)
        {
            if (n == 0) return 1;
            return x * RecursivePower(x, n - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtBaseInput.Text);
            int n = Convert.ToInt32(txtExponentInput.Text);
            int result = RecursivePower(x, n);
            lblPowerResult.Text = $"Power: {result}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
