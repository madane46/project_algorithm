using System.Diagnostics;
namespace project_algorithm_2
{
    public partial class Form1 : Form
    {
        internal static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }
        }
        void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }

                a[j + 1] = key;
            }
        }
        void Merge(int[] a, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = a[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = a[mid + 1 + j];

            int x = 0, y = 0;
            int k = left;

            while (x < n1 && y < n2)
            {
                if (L[x] <= R[y])
                {
                    a[k] = L[x];
                    x++;
                }
                else
                {
                    a[k] = R[y];
                    y++;
                }
                k++;
            }

            while (x < n1)
            {
                a[k] = L[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                a[k] = R[y];
                y++;
                k++;
            }
        }
        void MergeSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(a, left, mid);
                MergeSort(a, mid + 1, right);

                Merge(a, left, mid, right);
            }
        }
        int Partition(int[] a, int low, int high)
        {
            int pivot = a[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (a[j] < pivot)
                {
                    i++;

                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }

            int temp2 = a[i + 1];
            a[i + 1] = a[high];
            a[high] = temp2;

            return i + 1;
        }
        void QuickSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(a, low, high);

                QuickSort(a, low, pi - 1);
                QuickSort(a, pi + 1, high);
            }
        }
        //void BakirSort(int[] a)
        //{

        //    int max = a[0];
        //    for (int i = 1; i < a.Length; i++)
        //    {
        //        if (a[i] > max) max = a[i];
        //    }

        //    int[] count = new int[max + 1];

        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        count[a[i]]++;
        //    }

        //    int[] result = new int[a.Length];
        //    int index = 0;

        //    for (int i = 0; i < count.Length; i++)
        //    {
        //        for (int j = 0; j < count[i]; j++)
        //        {
        //            result[index] = i;
        //            index++;
        //        }
        //    }
        //}
        void BakirSort(int[] a)
        {

            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
            }

            int[] count = new int[max + 1];

            for (int i = 0; i < a.Length; i++)
            {
                count[a[i]]++;
            }

            int[] result = new int[a.Length];
            int index = 0;

            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    result[index] = i;
                    index++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = (int)numElements.Value;
            a = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                a[i] = rand.Next(1,1000);

            }
            lblViewMessege.Visible = true;
            lblViewMessege.Text = "✔️ تم توليد المصفوفة";
        }

        private int[] a = null!;
        // المتغيرات العامة التي ستحتفظ بالوقت وتمرره للفورم الثاني
        private double bubbleTime, selectionTime, insertionTime, mergeTime, quickTime, bakirTime;

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (a == null || a.Length == 0)
            {
                MessageBox.Show("الرجاء توليد المصفوفة العشوائية أولا");
                return;
            }

            lblViewMessege.Visible = false;
            btnTest.Text = "جاري المقارنة...";
            btnTest.Enabled = false;
            Application.DoEvents();
            Stopwatch sw = new Stopwatch();

            // اختبار Bubble Sort
            int[] arryForBubble = (int[])a.Clone();
            sw.Restart();
            BubbleSort(arryForBubble);
            sw.Stop();
            bubbleTime = Math.Round(sw.Elapsed.TotalMilliseconds, 4);
            lbl_Bubble_Time.Text = bubbleTime.ToString() + " ms";
            Console.WriteLine($"Bubble: {bubbleTime} ms"); // للتأكد من القيمة

            // اختبار Selection Sort
            int[] arryForSelection = (int[])a.Clone();
            sw.Restart();
            SelectionSort(arryForSelection);
            sw.Stop();
            selectionTime = Math.Round(sw.Elapsed.TotalMilliseconds, 4);
            lbl_Selection_Time.Text = selectionTime.ToString() + " ms";
            Console.WriteLine($"Selection: {selectionTime} ms");

            // اختبار Insertion Sort
            int[] arryForInsertion = (int[])a.Clone();
            sw.Restart();
            InsertionSort(arryForInsertion);
            sw.Stop();
            insertionTime = Math.Round(sw.Elapsed.TotalMilliseconds, 4);
            lbl_Insertion_Time.Text = insertionTime.ToString() + " ms";
            Console.WriteLine($"Insertion: {insertionTime} ms");

            // اختبار Merge Sort
            int[] arryForMerge = (int[])a.Clone();
            sw.Restart();
            MergeSort(arryForMerge, 0, a.Length - 1);
            sw.Stop();
            mergeTime = Math.Round(sw.Elapsed.TotalMilliseconds, 4);
            lbl_Merge_Time.Text = mergeTime.ToString() + " ms";
            Console.WriteLine($"Merge: {mergeTime} ms");

            // اختبار Quick Sort
            int[] arryForQuick = (int[])a.Clone();
            sw.Restart();
            QuickSort(arryForQuick, 0, a.Length - 1);
            sw.Stop();
            quickTime = Math.Round(sw.Elapsed.TotalMilliseconds, 4);
            lbl_Quick_Time.Text = quickTime.ToString() + " ms";
            Console.WriteLine($"Quick: {quickTime} ms");

            // اختبار Bakir Sort
            int[] arryForBakir = (int[])a.Clone();
            sw.Restart();
            BakirSort(arryForBakir);
            sw.Stop();
            bakirTime = Math.Round(sw.Elapsed.TotalMilliseconds, 4);
            lbl_bakir_Time.Text = bakirTime.ToString() + " ms";
            Console.WriteLine($"Bakir: {bakirTime} ms");

            // العثور على أفضل خوارزمية
            double[] allTime = { bubbleTime, selectionTime, insertionTime, mergeTime, quickTime, bakirTime };
            string[] allNames = { "Bubble Sort", "Selection Sort", "Insertion Sort", "Merge Sort", "Quick Sort", "Bakir Sort" };

            double minTime = allTime[0];
            int bestIndex = 0;
            for (int i = 1; i < allTime.Length; i++)
            {
                if (allTime[i] < minTime)
                {
                    minTime = allTime[i];
                    bestIndex = i;
                }
            }

            lblminTime.Text = minTime.ToString() + " ms";
            lblBest.Text = allNames[bestIndex];

            btnTest.Text = "بدء المقارنة";
            btnTest.Enabled = true;
        }
        // كود حدث الضغط على زر عرض الرسم البياني الجديد
        private void btnShowChart_Click(object sender, EventArgs e)
        {
            if (bubbleTime == 0 && quickTime == 0)
            {
                MessageBox.Show("الرجاء إجراء المقارنة أولاً لحساب الأوقات!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChartForm frmChart = new ChartForm(bubbleTime, selectionTime, insertionTime, mergeTime, quickTime ,bakirTime);
            frmChart.ShowDialog();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bubbleTime == 0 && quickTime == 0)
            {
                MessageBox.Show("الرجاء الضغط على بدء المقارنة أولاً لحساب الأوقات!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // فتح فورم الرسم البياني وتمرير الأوقات المخزنة له
            ChartForm frmChart = new ChartForm(bubbleTime, selectionTime, insertionTime, mergeTime, quickTime,bakirTime);
            frmChart.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblBest_Click(object sender, EventArgs e)
        {

        }
    }
}