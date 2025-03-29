namespace Task5_CustomDescendingOrder
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 5, 8, 9, 4, 1, 3, 2, 7 };
            listBoxResult.DataSource = ArraySorter.SortDescending(numbers);
        }
        public static class ArraySorter
        {
            public static int[] SortDescending(int[] numbers)
            {
                return numbers.OrderByDescending(x => x).ToArray();
            }
        }
    }
}
