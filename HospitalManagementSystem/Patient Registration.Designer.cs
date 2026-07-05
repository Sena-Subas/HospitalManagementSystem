namespace HospitalManagementSystem
{
    partial class Patient_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Registration));
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 30);
            textBox1.TabIndex = 1;
            textBox1.UseWaitCursor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(209, 134);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(165, 30);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.UseWaitCursor = true;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 89);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 9;
            label3.Text = "Surname :";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 41);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 8;
            label2.Text = "Name :";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 187);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 13;
            label1.Text = "Phone Number :";
            label1.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 134);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 12;
            label4.Text = "National :";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 289);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 15;
            label5.Text = "Gender :";
            label5.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 30);
            textBox2.TabIndex = 2;
            textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 30);
            textBox3.TabIndex = 5;
            textBox3.UseSystemPasswordChar = true;
            textBox3.UseWaitCursor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(209, 187);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(165, 30);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female", "Male" });
            comboBox1.Location = new Point(209, 286);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 33);
            comboBox1.TabIndex = 6;
            comboBox1.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 240);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 20;
            label6.Text = "Password :";
            label6.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(272, 336);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 21;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // Patient_Registration
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(608, 390);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Patient_Registration";
            Text = "Patient Registration Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Button button1;
    }
}