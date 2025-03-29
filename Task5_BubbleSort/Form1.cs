namespace Task5_BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] BubbleSort(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();
            int n = sortedNumbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedNumbers[j] > sortedNumbers[j + 1])
                    {
                        int temp = sortedNumbers[j];
                        sortedNumbers[j] = sortedNumbers[j + 1];
                        sortedNumbers[j + 1] = temp;
                    }
                }
            }
            return sortedNumbers;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            int[] sortedNumbers = BubbleSort(numbers);
            listBoxResult.Items.Clear();
            foreach (int num in sortedNumbers)
            {
                listBoxResult.Items.Add(num);
            }
        }
    }
}
