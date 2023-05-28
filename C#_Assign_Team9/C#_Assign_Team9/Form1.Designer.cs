namespace C__Assign_Team9
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            startButton = new Button();
            label1 = new Label();
            label2 = new Label();
            CharacterImage1 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.Transparent;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.ForeColor = SystemColors.ControlText;
            startButton.Image = (Image)resources.GetObject("startButton.Image");
            startButton.Location = new Point(345, 292);
            startButton.Name = "startButton";
            startButton.Size = new Size(284, 92);
            startButton.TabIndex = 0;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(853, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "코인 표시창";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("맑은 고딕", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(362, 69);
            label2.Name = "label2";
            label2.Size = new Size(267, 131);
            label2.TabIndex = 4;
            label2.Text = "신라무스메\r\n(프리티더비)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CharacterImage1
            // 
            CharacterImage1.AccessibleRole = AccessibleRole.None;
            CharacterImage1.BackColor = Color.Transparent;
            CharacterImage1.Image = Properties.Resources.RunningMan;
            CharacterImage1.Location = new Point(2, 276);
            CharacterImage1.Name = "CharacterImage1";
            CharacterImage1.Size = new Size(303, 283);
            CharacterImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            CharacterImage1.TabIndex = 5;
            CharacterImage1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.RunningMan_R;
            pictureBox1.Location = new Point(681, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(pictureBox1);
            Controls.Add(CharacterImage1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label label1;
        private Label label2;
        private PictureBox CharacterImage1;
        private PictureBox pictureBox1;
    }
}