namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 5, 8, 9, 4, 1, 3, 2, 7 };
            int[] sortNumbers = proceduralSort(numbers);
            listBoxResult.DataSource = sortNumbers;
        }
        public int[] proceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

    }
}
