namespace Hotel_Management_System
{
    partial class deleteclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteclient));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(296, 270);
            button1.Name = "button1";
            button1.Size = new Size(168, 45);
            button1.TabIndex = 0;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(279, 150);
            label1.Name = "label1";
            label1.Size = new Size(200, 35);
            label1.TabIndex = 1;
            label1.Text = "Delete Item";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Simple Outline Pat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(258, 208);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "National ID";
            textBox1.Size = new Size(265, 33);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.PanWest;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 395);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(95, 43);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // deleteclient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images4;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "deleteclient";
            Text = "deleteclient";
            Load += deleteclient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
    }
}