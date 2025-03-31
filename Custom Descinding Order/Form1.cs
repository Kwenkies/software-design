namespace Custom_Descinding_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
            private void SortDescending(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] < arr[j + 1]) 
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

                SortDescending(numbers); 

                listBoxResults.DataSource = null; 
                listBoxResults.DataSource = numbers; 
            }
        }
    }



    

