using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace project_algorithm_2
{
    public partial class ChartForm : Form
    {
        public ChartForm(double bubble, double selection, double insertion, double merge, double quick, double bakir)
        {
            InitializeComponent();

            // 1. تنظيف البيانات الوهمية التي يضعها الفيجوال ستوديو تلقائياً
            chart1.Series["BubbleSeries"].Points.Clear();
            chart1.Series["SelectionSeries"].Points.Clear();
            chart1.Series["InsertionSeries"].Points.Clear();
            chart1.Series["MergeSeries"].Points.Clear();
            chart1.Series["QuickSeries"].Points.Clear();
            chart1.Series["BakirSeries"].Points.Clear();

            // 2. تفعيل ظهور الأرقام فوق الأعمدة
            chart1.Series["BubbleSeries"].IsValueShownAsLabel = true;
            chart1.Series["SelectionSeries"].IsValueShownAsLabel = true;
            chart1.Series["InsertionSeries"].IsValueShownAsLabel = true;
            chart1.Series["MergeSeries"].IsValueShownAsLabel = true;
            chart1.Series["QuickSeries"].IsValueShownAsLabel = true;
            chart1.Series["BakirSeries"].IsValueShownAsLabel = true;

            // 3. الحل: تمرير اسم الخوارزمية كقيمة للمحور X ليفصل البرنامج بين الأعمدة
            chart1.Series["BubbleSeries"].Points.AddXY(" ",bubble);
            chart1.Series["SelectionSeries"].Points.AddXY("Selection", selection);
            chart1.Series["InsertionSeries"].Points.AddXY("Insertion", insertion);
            chart1.Series["MergeSeries"].Points.AddXY("Merge", merge);
            chart1.Series["QuickSeries"].Points.AddXY("Quick", quick);
            chart1.Series["BakirSeries"].Points.AddXY("Bakir", bakir);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
