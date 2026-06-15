namespace project_algorithm_2
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            openFileDialog1 = new OpenFileDialog();
            notifyIcon1 = new NotifyIcon(components);
            openFileDialog2 = new OpenFileDialog();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            process1 = new System.Diagnostics.Process();
            printPreviewDialog2 = new PrintPreviewDialog();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // process1
            // 
            process1.StartInfo.CreateNewProcessGroup = false;
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog2.ClientSize = new Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            // 
            // chart1
            // 
            chart1.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(201, 98);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "SelectionSeries";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PointWidth=1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "InsertionSeries";
            series3.ChartArea = "ChartArea1";
            series3.CustomProperties = "PointWidth=1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "MergeSeries";
            series4.ChartArea = "ChartArea1";
            series4.CustomProperties = "PointWidth=1";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "QuickSeries";
            series5.ChartArea = "ChartArea1";
            series5.CustomProperties = "PointWidth=1";
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "BubbleSeries";
            series6.ChartArea = "ChartArea1";
            series6.CustomProperties = "PixelPointWidth=1";
            series6.Legend = "Legend1";
            series6.Name = "BakirSeries";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Series.Add(series4);
            chart1.Series.Add(series5);
            chart1.Series.Add(series6);
            chart1.Size = new Size(737, 558);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(chart1);
            Name = "ChartForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private NotifyIcon notifyIcon1;
        private OpenFileDialog openFileDialog2;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Diagnostics.Process process1;
        private PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}