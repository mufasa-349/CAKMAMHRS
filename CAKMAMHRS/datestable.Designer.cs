namespace CAKMAMHRS
{
    partial class datestable
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
            dataGridViewDateTAble = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDateTAble).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDateTAble
            // 
            dataGridViewDateTAble.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDateTAble.Location = new Point(19, 53);
            dataGridViewDateTAble.Margin = new Padding(5, 5, 5, 5);
            dataGridViewDateTAble.Name = "dataGridViewDateTAble";
            dataGridViewDateTAble.RowHeadersWidth = 51;
            dataGridViewDateTAble.RowTemplate.Height = 29;
            dataGridViewDateTAble.Size = new Size(1261, 480);
            dataGridViewDateTAble.TabIndex = 0;
            dataGridViewDateTAble.CellContentClick += dataGridViewDateTAble_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 579);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(852, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 542);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 2;
            label1.Text = "appointment date";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1082, 576);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 47);
            button1.TabIndex = 3;
            button1.Text = "display date";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(902, 579);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(171, 47);
            button2.TabIndex = 4;
            button2.Text = "newAppo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // datestable
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewDateTAble);
            Margin = new Padding(5, 5, 5, 5);
            Name = "datestable";
            Text = "datestable";
            Load += datestable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDateTAble).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDateTAble;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}