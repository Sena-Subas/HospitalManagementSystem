namespace HospitalManagementSystem
{
    partial class SecretaryDoctorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryDoctorPanel));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Doctor Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 30);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 81);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 4;
            label2.Text = "Doctor Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 126);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 5;
            label3.Text = "Department :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 30);
            textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 33);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 171);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 8;
            label4.Text = "National :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(189, 171);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(205, 30);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 216);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 10;
            label5.Text = "Password :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 30);
            textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(628, 292);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(23, 284);
            button1.Name = "button1";
            button1.Size = new Size(110, 46);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(294, 284);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(410, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 321);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(157, 284);
            button3.Name = "button3";
            button3.Size = new Size(116, 46);
            button3.TabIndex = 15;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SecretaryDoctorPanel
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1046, 360);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SecretaryDoctorPanel";
            Text = "Quick Access Doctor Panel";
            Load += SecretaryDoctorPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
    }
}