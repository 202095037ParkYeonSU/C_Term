namespace C__Assign_Team9
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            CharacterImage1 = new PictureBox();
            CharacterImage2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            FinishLine = new Label();
            progressBar2 = new ProgressBar();
            panel1 = new Panel();
            Naration = new Label();
            label2 = new Label();
            BetToChar1 = new RadioButton();
            BetToChar2 = new RadioButton();
            BetMoney = new TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CharacterImage2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.MenuText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(354, 22);
            button1.Name = "button1";
            button1.Size = new Size(284, 95);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(880, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(100, 285);
            progressBar1.Maximum = 10000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 3);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // CharacterImage1
            // 
            CharacterImage1.AccessibleRole = AccessibleRole.None;
            CharacterImage1.BackColor = Color.Transparent;
            CharacterImage1.Image = Properties.Resources.RunningDog;
            CharacterImage1.Location = new Point(100, 238);
            CharacterImage1.Name = "CharacterImage1";
            CharacterImage1.Size = new Size(80, 40);
            CharacterImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            CharacterImage1.TabIndex = 4;
            CharacterImage1.TabStop = false;
            CharacterImage1.Click += CharacterImage1_Click;
            // 
            // CharacterImage2
            // 
            CharacterImage2.AccessibleRole = AccessibleRole.None;
            CharacterImage2.BackColor = Color.Transparent;
            CharacterImage2.Image = Properties.Resources.RunningDog;
            CharacterImage2.Location = new Point(100, 335);
            CharacterImage2.Name = "CharacterImage2";
            CharacterImage2.Size = new Size(80, 40);
            CharacterImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            CharacterImage2.TabIndex = 5;
            CharacterImage2.TabStop = false;
            CharacterImage2.Click += CharacterImage2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FinishLine
            // 
            FinishLine.BackColor = Color.Gainsboro;
            FinishLine.Location = new Point(900, 209);
            FinishLine.Name = "FinishLine";
            FinishLine.Size = new Size(10, 240);
            FinishLine.TabIndex = 7;
            FinishLine.Click += label2_Click_1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(100, 381);
            progressBar2.Maximum = 10000;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(800, 3);
            progressBar2.Step = 1;
            progressBar2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(Naration);
            panel1.Location = new Point(255, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 138);
            panel1.TabIndex = 9;
            // 
            // Naration
            // 
            Naration.BackColor = Color.Transparent;
            Naration.Location = new Point(141, 30);
            Naration.Name = "Naration";
            Naration.Size = new Size(188, 76);
            Naration.TabIndex = 10;
            Naration.Text = "Nothing";
            Naration.TextAlign = ContentAlignment.MiddleCenter;
            Naration.Click += Naration_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(824, 22);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "소지금 :";
            label2.Click += label2_Click_2;
            // 
            // BetToChar1
            // 
            BetToChar1.AutoSize = true;
            BetToChar1.Location = new Point(-1, 256);
            BetToChar1.Name = "BetToChar1";
            BetToChar1.Size = new Size(50, 19);
            BetToChar1.TabIndex = 11;
            BetToChar1.TabStop = true;
            BetToChar1.Text = "BetA";
            BetToChar1.UseVisualStyleBackColor = true;
            BetToChar1.CheckedChanged += BetToChar1_CheckedChanged_1;
            // 
            // BetToChar2
            // 
            BetToChar2.AutoSize = true;
            BetToChar2.Location = new Point(-1, 335);
            BetToChar2.Name = "BetToChar2";
            BetToChar2.Size = new Size(49, 19);
            BetToChar2.TabIndex = 12;
            BetToChar2.TabStop = true;
            BetToChar2.Text = "Bet2";
            BetToChar2.UseVisualStyleBackColor = true;
            BetToChar2.CheckedChanged += BetToChar2_CheckedChanged;
            // 
            // BetMoney
            // 
            BetMoney.Location = new Point(-1, 297);
            BetMoney.Name = "BetMoney";
            BetMoney.Size = new Size(100, 23);
            BetMoney.TabIndex = 13;
            BetMoney.TextChanged += BetMoney_TextChanged;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(984, 561);
            Controls.Add(BetMoney);
            Controls.Add(BetToChar2);
            Controls.Add(BetToChar1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(progressBar2);
            Controls.Add(FinishLine);
            Controls.Add(CharacterImage2);
            Controls.Add(CharacterImage1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = Color.Transparent;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CharacterImage2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ProgressBar progressBar1;
        private PictureBox CharacterImage1;
        private PictureBox CharacterImage2;
        private System.Windows.Forms.Timer timer1;
        private Label FinishLine;
        private ProgressBar progressBar2;
        private Panel panel1;
        private Label Naration;
        private Label label2;
        private RadioButton BetToChar1;
        private RadioButton BetToChar2;
        private TextBox BetMoney;
        private System.Windows.Forms.Timer timer2;
    }
}