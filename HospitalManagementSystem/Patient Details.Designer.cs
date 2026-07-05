namespace HospitalManagementSystem
{
    partial class Patient_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Details));
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(3, 591);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1766, 280);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Appointments History";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1760, 251);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 116);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 9;
            label2.Text = "Patient FullName :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 63);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 10;
            label1.Text = "514...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 63);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 11;
            label4.Text = "Patient National :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 116);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 12;
            label3.Text = "Null";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(23, 338);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(229, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Change Your Information";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(187, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(276, 33);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(262, 272);
            button1.Name = "button1";
            button1.Size = new Size(203, 52);
            button1.TabIndex = 4;
            button1.Text = "Appointment Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 109);
            label9.Name = "label9";
            label9.Size = new Size(137, 25);
            label9.TabIndex = 13;
            label9.Text = "Doctor Name :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(187, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 156);
            label8.Name = "label8";
            label8.Size = new Size(162, 25);
            label8.TabIndex = 9;
            label8.Text = "Chief Complaint :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(189, 153);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(276, 92);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 62);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 11;
            label6.Text = "Department :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(6, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 380);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Appointment Panel";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1266, 554);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 197);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Information";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(497, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1272, 583);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Active Appointments";
            // 
            // Patient_Details
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1773, 874);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Patient_Details";
            Text = "Patient Details";
            Load += Patient_Details_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel1;
        private ComboBox comboBox2;
        private Button button1;
        private Label label9;
        private ComboBox comboBox1;
        private Label label8;
        private RichTextBox richTextBox1;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
    }
}