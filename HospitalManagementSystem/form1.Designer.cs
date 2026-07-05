namespace HospitalManagementSystem
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.MenuBar;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Corbel", 13.8F);
            button1.Location = new Point(71, 229);
            button1.Name = "button1";
            button1.Size = new Size(254, 157);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.MenuBar;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Corbel", 13.8F);
            button2.Location = new Point(341, 229);
            button2.Name = "button2";
            button2.Size = new Size(254, 157);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.MenuBar;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Corbel", 13.8F);
            button3.Location = new Point(613, 229);
            button3.Name = "button3";
            button3.Size = new Size(254, 157);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(152, 405);
            label1.Name = "label1";
            label1.Size = new Size(105, 35);
            label1.TabIndex = 3;
            label1.Text = "Patient";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(417, 405);
            label2.Name = "label2";
            label2.Size = new Size(99, 35);
            label2.TabIndex = 4;
            label2.Text = "Doctor";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.InactiveCaptionText;
            label3.Location = new Point(683, 405);
            label3.Name = "label3";
            label3.Size = new Size(130, 35);
            label3.TabIndex = 5;
            label3.Text = "Secretary";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(248, 73);
            label4.Name = "label4";
            label4.Size = new Size(451, 54);
            label4.TabIndex = 6;
            label4.Text = "Hospital Login System";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(71, 179);
            label5.Name = "label5";
            label5.Size = new Size(337, 22);
            label5.TabIndex = 7;
            label5.Text = "・Please choose how you'd like to sign in.";
            // 
            // form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(935, 503);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System Login Panel";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
