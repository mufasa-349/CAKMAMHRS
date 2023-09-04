namespace CAKMAMHRS
{
    partial class newtableappointment
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
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            text1 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(182, 263);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 13;
            button2.Text = "cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(282, 263);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 14;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 66);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 18;
            label3.Text = "choose room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 132);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 17;
            label2.Text = "choose doctor name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 185);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 16;
            label1.Text = "yourname:";
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(8, 6);
            text1.Name = "text1";
            text1.Size = new Size(74, 15);
            text1.TabIndex = 15;
            text1.Text = "choose date:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(8, 84);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(358, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(7, 149);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(358, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 202);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 24);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // newtableappointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 290);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "newtableappointment";
            Text = "newtableappointment";
            Load += newtableappointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label text1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}