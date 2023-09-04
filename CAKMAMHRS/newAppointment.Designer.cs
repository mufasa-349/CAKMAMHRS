namespace CAKMAMHRS
{
    partial class newAppointment
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            text1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(408, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(408, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(63, 148);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(408, 27);
            textBox5.TabIndex = 1;
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(63, 45);
            text1.Name = "text1";
            text1.Size = new Size(93, 20);
            text1.TabIndex = 5;
            text1.Text = "choose date:";
            text1.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 283);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "yourname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 212);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 7;
            label2.Text = "choose doctor name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 125);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 8;
            label3.Text = "choose room:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(376, 387);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(262, 387);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // newAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 441);
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
            MinimizeBox = false;
            Name = "newAppointment";
            Text = "newAppointment";
            Load += newAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label text1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}