namespace HospitalManagementSystem
{
    partial class Doctor_Information_Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Information_Editing));
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 30);
            textBox2.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 184);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 34;
            label4.Text = "National :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 30);
            textBox1.TabIndex = 33;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(167, 179);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(165, 30);
            maskedTextBox1.TabIndex = 32;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 97);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 31;
            label3.Text = "Surname :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 58);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 30;
            label2.Text = "Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 227);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 37;
            label6.Text = "Password :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 30);
            textBox3.TabIndex = 36;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(220, 290);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 38;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 33);
            comboBox1.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 142);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 41;
            label5.Text = "Department :";
            // 
            // Doctor_Information_Editing
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(382, 381);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Doctor_Information_Editing";
            Text = "Doctor Information Change";
            Load += Doctor_Information_Editing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox textBox3;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
    }
}