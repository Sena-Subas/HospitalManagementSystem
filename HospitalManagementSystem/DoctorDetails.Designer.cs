namespace HospitalManagementSystem
{
    partial class DoctorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDetails));
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doctor Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 155);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 4;
            label5.Text = "Doctor Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 115);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 3;
            label3.Text = "Null...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 2;
            label4.Text = "Doctor Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "514...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "National :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(6, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 262);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Appointment Details";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(197, 70);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(166, 120);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 70);
            label8.Name = "label8";
            label8.Size = new Size(162, 25);
            label8.TabIndex = 0;
            label8.Text = "Chief Complaint :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(422, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1150, 650);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Appointment List";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1144, 621);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(6, 510);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(397, 152);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Quick Access";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Location = new Point(197, 65);
            button2.Name = "button2";
            button2.Size = new Size(166, 41);
            button2.TabIndex = 1;
            button2.Text = "Announcements";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(25, 65);
            button1.Name = "button1";
            button1.Size = new Size(166, 41);
            button1.TabIndex = 0;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DoctorDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1578, 674);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DoctorDetails";
            Text = "Doctor Details";
            Load += DoctorDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox4;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
    }
}