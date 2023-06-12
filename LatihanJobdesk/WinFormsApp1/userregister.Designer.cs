namespace WinFormsApp1
{
    partial class userregister
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(250, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 35);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 1;
            label1.Text = "User Register Form";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 110);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 159);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 23);
            textBox2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 374);
            label7.Name = "label7";
            label7.Size = new Size(130, 15);
            label7.TabIndex = 12;
            label7.Text = "Already Have Account?";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 209);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 13;
            label5.Text = "Nama Ortu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 258);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 14;
            label6.Text = "Tgl Lahir Ortu";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(250, 206);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(314, 23);
            textBox4.TabIndex = 15;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(250, 252);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 23);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // userregister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "userregister";
            Text = "userregister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
    }
}