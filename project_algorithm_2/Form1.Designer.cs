namespace project_algorithm_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            lblViewMessege = new Label();
            numElements = new NumericUpDown();
            btnGenerate = new Button();
            label2 = new Label();
            panel10 = new Panel();
            label5 = new Label();
            lblminTime = new Label();
            lblBest = new Label();
            label17 = new Label();
            btnTest = new Button();
            panel4 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lbl_Bubble_Time = new Label();
            lblBubbleSort = new Label();
            panel6 = new Panel();
            lbl_Selection_Time = new Label();
            lblSelectionSort = new Label();
            panel7 = new Panel();
            lbl_Insertion_Time = new Label();
            lblIsertionSort = new Label();
            panel8 = new Panel();
            lbl_Merge_Time = new Label();
            lblMergeSort = new Label();
            panel3 = new Panel();
            panel9 = new Panel();
            lbl_Quick_Time = new Label();
            lblQuickSort = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numElements).BeginInit();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(464, 7);
            label1.Name = "label1";
            label1.Size = new Size(298, 64);
            label1.TabIndex = 0;
            label1.Text = "مقارنة خوارزميات الترتيب 📊\r\n\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblViewMessege);
            panel2.Controls.Add(numElements);
            panel2.Controls.Add(btnGenerate);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 62);
            panel2.TabIndex = 1;
            // 
            // lblViewMessege
            // 
            lblViewMessege.AutoSize = true;
            lblViewMessege.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViewMessege.ForeColor = Color.FromArgb(0, 0, 192);
            lblViewMessege.Location = new Point(48, 18);
            lblViewMessege.Name = "lblViewMessege";
            lblViewMessege.Size = new Size(0, 26);
            lblViewMessege.TabIndex = 3;
            // 
            // numElements
            // 
            numElements.BackColor = SystemColors.GradientActiveCaption;
            numElements.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numElements.Location = new Point(720, 15);
            numElements.Margin = new Padding(4);
            numElements.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numElements.Name = "numElements";
            numElements.Size = new Size(163, 34);
            numElements.TabIndex = 2;
            numElements.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.White;
            btnGenerate.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(336, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(290, 49);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "🔁  توليد المصفوفة العشوائية";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(890, 17);
            label2.Name = "label2";
            label2.Size = new Size(193, 32);
            label2.TabIndex = 0;
            label2.Text = " :  عدد العناصر     \r\n";
            // 
            // panel10
            // 
            panel10.BackColor = Color.GhostWhite;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(button1);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(lblminTime);
            panel10.Controls.Add(lblBest);
            panel10.Controls.Add(label17);
            panel10.Location = new Point(62, 505);
            panel10.Name = "panel10";
            panel10.Size = new Size(1076, 103);
            panel10.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.GhostWhite;
            label5.Font = new Font("Simplified Arabic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(479, 4);
            label5.Name = "label5";
            label5.Size = new Size(197, 47);
            label5.TabIndex = 6;
            label5.Text = "⏳ أقل زمن تنفيذ";
            // 
            // lblminTime
            // 
            lblminTime.AutoSize = true;
            lblminTime.Font = new Font("Simplified Arabic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblminTime.Location = new Point(504, 51);
            lblminTime.Name = "lblminTime";
            lblminTime.Size = new Size(95, 46);
            lblminTime.TabIndex = 5;
            lblminTime.Text = "-----";
            // 
            // lblBest
            // 
            lblBest.AutoSize = true;
            lblBest.BackColor = Color.GhostWhite;
            lblBest.Font = new Font("Simplified Arabic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBest.Location = new Point(828, 53);
            lblBest.Name = "lblBest";
            lblBest.Size = new Size(95, 46);
            lblBest.TabIndex = 2;
            lblBest.Text = "-----";
            // 
            // label17
            // 
            label17.BackColor = Color.GhostWhite;
            label17.Font = new Font("Simplified Arabic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Blue;
            label17.Location = new Point(789, 4);
            label17.Name = "label17";
            label17.Size = new Size(213, 47);
            label17.TabIndex = 1;
            label17.Text = "🏆 أفضل خوارزمية";
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.None;
            btnTest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTest.BackColor = Color.Transparent;
            btnTest.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest.ForeColor = Color.Blue;
            btnTest.Location = new Point(706, 127);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(279, 53);
            btnTest.TabIndex = 4;
            btnTest.Text = "⌛   بدء المقارنة";
            btnTest.UseCompatibleTextRendering = true;
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1075, 46);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(784, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 38);
            label3.TabIndex = 0;
            label3.Text = "الخوارزميات\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(183, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 38);
            label4.TabIndex = 1;
            label4.Text = "Time (ms)";
            // 
            // panel5
            // 
            panel5.BackColor = Color.GhostWhite;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lbl_Bubble_Time);
            panel5.Controls.Add(lblBubbleSort);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(1075, 46);
            panel5.TabIndex = 2;
            // 
            // lbl_Bubble_Time
            // 
            lbl_Bubble_Time.AutoSize = true;
            lbl_Bubble_Time.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Bubble_Time.Location = new Point(183, 4);
            lbl_Bubble_Time.Name = "lbl_Bubble_Time";
            lbl_Bubble_Time.Size = new Size(32, 38);
            lbl_Bubble_Time.TabIndex = 1;
            lbl_Bubble_Time.Text = "0";
            // 
            // lblBubbleSort
            // 
            lblBubbleSort.AutoSize = true;
            lblBubbleSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBubbleSort.ForeColor = Color.Black;
            lblBubbleSort.Location = new Point(784, 0);
            lblBubbleSort.Name = "lblBubbleSort";
            lblBubbleSort.Size = new Size(172, 38);
            lblBubbleSort.TabIndex = 0;
            lblBubbleSort.Text = "Bubble sort ";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(lbl_Selection_Time);
            panel6.Controls.Add(lblSelectionSort);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 92);
            panel6.Name = "panel6";
            panel6.Size = new Size(1075, 46);
            panel6.TabIndex = 3;
            // 
            // lbl_Selection_Time
            // 
            lbl_Selection_Time.AutoSize = true;
            lbl_Selection_Time.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Selection_Time.Location = new Point(183, 6);
            lbl_Selection_Time.Name = "lbl_Selection_Time";
            lbl_Selection_Time.Size = new Size(32, 38);
            lbl_Selection_Time.TabIndex = 2;
            lbl_Selection_Time.Text = "0";
            // 
            // lblSelectionSort
            // 
            lblSelectionSort.AutoSize = true;
            lblSelectionSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectionSort.Location = new Point(784, 0);
            lblSelectionSort.Name = "lblSelectionSort";
            lblSelectionSort.Size = new Size(190, 38);
            lblSelectionSort.TabIndex = 0;
            lblSelectionSort.Text = "Selection sort\r\n";
            // 
            // panel7
            // 
            panel7.BackColor = Color.GhostWhite;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(lbl_Insertion_Time);
            panel7.Controls.Add(lblIsertionSort);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 138);
            panel7.Name = "panel7";
            panel7.Size = new Size(1075, 46);
            panel7.TabIndex = 4;
            // 
            // lbl_Insertion_Time
            // 
            lbl_Insertion_Time.AutoSize = true;
            lbl_Insertion_Time.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Insertion_Time.Location = new Point(183, 3);
            lbl_Insertion_Time.Name = "lbl_Insertion_Time";
            lbl_Insertion_Time.Size = new Size(32, 38);
            lbl_Insertion_Time.TabIndex = 2;
            lbl_Insertion_Time.Text = "0";
            // 
            // lblIsertionSort
            // 
            lblIsertionSort.AutoSize = true;
            lblIsertionSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsertionSort.Location = new Point(784, 0);
            lblIsertionSort.Name = "lblIsertionSort";
            lblIsertionSort.Size = new Size(187, 38);
            lblIsertionSort.TabIndex = 0;
            lblIsertionSort.Text = "Insertion sort";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(lbl_Merge_Time);
            panel8.Controls.Add(lblMergeSort);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 184);
            panel8.Name = "panel8";
            panel8.Size = new Size(1075, 51);
            panel8.TabIndex = 5;
            // 
            // lbl_Merge_Time
            // 
            lbl_Merge_Time.AutoSize = true;
            lbl_Merge_Time.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Merge_Time.Location = new Point(183, 7);
            lbl_Merge_Time.Name = "lbl_Merge_Time";
            lbl_Merge_Time.Size = new Size(32, 38);
            lbl_Merge_Time.TabIndex = 2;
            lbl_Merge_Time.Text = "0";
            // 
            // lblMergeSort
            // 
            lblMergeSort.AutoSize = true;
            lblMergeSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMergeSort.Location = new Point(789, 3);
            lblMergeSort.Name = "lblMergeSort";
            lblMergeSort.Size = new Size(158, 38);
            lblMergeSort.TabIndex = 0;
            lblMergeSort.Text = "Merge sort";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(61, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(1077, 290);
            panel3.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.GhostWhite;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(lbl_Quick_Time);
            panel9.Controls.Add(lblQuickSort);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 235);
            panel9.Name = "panel9";
            panel9.Size = new Size(1075, 54);
            panel9.TabIndex = 6;
            // 
            // lbl_Quick_Time
            // 
            lbl_Quick_Time.AutoSize = true;
            lbl_Quick_Time.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Quick_Time.Location = new Point(183, 3);
            lbl_Quick_Time.Name = "lbl_Quick_Time";
            lbl_Quick_Time.Size = new Size(32, 38);
            lbl_Quick_Time.TabIndex = 2;
            lbl_Quick_Time.Text = "0";
            // 
            // lblQuickSort
            // 
            lblQuickSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickSort.Location = new Point(789, 1);
            lblQuickSort.Name = "lblQuickSort";
            lblQuickSort.Size = new Size(147, 38);
            lblQuickSort.TabIndex = 0;
            lblQuickSort.Text = "Quick sort";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Simplified Arabic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(65, 16);
            button1.Name = "button1";
            button1.Size = new Size(223, 66);
            button1.TabIndex = 7;
            button1.Text = "عرض الرسم البياني ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1182, 653);
            Controls.Add(btnTest);
            Controls.Add(panel10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "مقارنة خوارزميات الترتيب ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numElements).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnGenerate;
        private NumericUpDown numElements;
        private Panel panel10;
        private Label label17;
        private Label lblBest;
        private Label lblminTime;
        private Button btnTest;
        private Label label5;
        private Label lblViewMessege;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private Panel panel5;
        private Label lbl_Bubble_Time;
        private Label lblBubbleSort;
        private Panel panel6;
        private Label lbl_Selection_Time;
        private Label lblSelectionSort;
        private Panel panel7;
        private Label lbl_Insertion_Time;
        private Label lblIsertionSort;
        private Panel panel8;
        private Label lbl_Merge_Time;
        private Label lblMergeSort;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel9;
        private Label lbl_Quick_Time;
        private Label lblQuickSort;
        private Button button1;
    }
}
