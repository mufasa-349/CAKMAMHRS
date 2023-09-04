namespace CAKMAMHRS
{
    partial class editAppointment
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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            text1 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(500, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 93);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 17;
            label3.Text = "choose room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 171);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 16;
            label2.Text = "choose doctor name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 259);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 15;
            label1.Text = "yourname:";
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(29, 26);
            text1.Name = "text1";
            text1.Size = new Size(93, 20);
            text1.TabIndex = 14;
            text1.Text = "choose date:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(29, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(408, 27);
            textBox5.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(408, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(408, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 351);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(408, 27);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 328);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 20;
            label4.Text = "status:";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(400, 382);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // editAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "editAppointment";
            Text = "editAppointment";
            Load += editAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label text1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
    }
}