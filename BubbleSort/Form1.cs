namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };

            BubbleSort(numbers); // Sort the array

            listBoxResults.DataSource = null; // Clear previous data binding
            listBoxResults.DataSource = numbers; // Display sorted array
        }
    }
}
