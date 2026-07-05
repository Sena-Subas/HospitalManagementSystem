namespace HospitalManagementSystem
{
    partial class ChangeInformationfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInformationfrm));
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(275, 334);
            button1.Name = "button1";
            button1.Size = new Size(103, 37);
            button1.TabIndex = 34;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 235);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 33;
            label6.Text = "Password :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female", "Male" });
            comboBox1.Location = new Point(213, 284);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 33);
            comboBox1.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(213, 184);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(165, 30);
            maskedTextBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 30);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 30);
            textBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 284);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 28;
            label5.Text = "Gender :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 186);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 27;
            label1.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 137);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 26;
            label4.Text = "National :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 30);
            textBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(213, 134);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(165, 30);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 88);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 23;
            label3.Text = "Surname :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 22;
            label2.Text = "Name :";
            // 
            // ChangeInformationfrm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(466, 395);
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
            Name = "ChangeInformationfrm";
            Text = "Patient Information Update";
            Load += ChangeInformationfrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
    }
}