namespace Hotel_Management_System
{
    partial class deleteroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteroom));
            button5 = new Button();
            num = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.PanWest;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(47, 385);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(95, 43);
            button5.TabIndex = 11;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // num
            // 
            num.Font = new Font("Simple Outline Pat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            num.Location = new Point(286, 201);
            num.Name = "num";
            num.PlaceholderText = "Room Number";
            num.Size = new Size(265, 33);
            num.TabIndex = 10;
            num.TextAlign = HorizontalAlignment.Center;
            num.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 138);
            label1.Name = "label1";
            label1.Size = new Size(215, 35);
            label1.TabIndex = 9;
            label1.Text = "Delete Room";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(329, 258);
            button1.Name = "button1";
            button1.Size = new Size(168, 45);
            button1.TabIndex = 8;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // deleteroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images4;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(num);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "deleteroom";
            Text = "deleteroom";
            Load += deleteroom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox num;
        private Label label1;
        private Button button1;
    }
}