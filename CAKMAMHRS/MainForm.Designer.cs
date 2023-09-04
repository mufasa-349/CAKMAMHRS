namespace CAKMAMHRS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Save = new Button();
            editbutton = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(94, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Randevular";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 250);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Save
            // 
            Save.Location = new Point(594, 358);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 2;
            Save.Text = "new";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // editbutton
            // 
            editbutton.Location = new Point(498, 358);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(94, 29);
            editbutton.TabIndex = 1;
            editbutton.Text = "edit";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(694, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(398, 358);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "datetable";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(editbutton);
            Controls.Add(Save);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Activated += MainForm_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button Save;
        private Button editbutton;
        private Button button1;
        private Button button2;
    }
}