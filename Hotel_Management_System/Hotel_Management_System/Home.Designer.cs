namespace Hotel_Management_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(360, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 286);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(60, 194);
            button3.Name = "button3";
            button3.Size = new Size(217, 54);
            button3.TabIndex = 3;
            button3.Text = "Manage Reservations";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(60, 26);
            button1.Name = "button1";
            button1.Size = new Size(217, 54);
            button1.TabIndex = 2;
            button1.Text = "Manage Clients";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(60, 114);
            button2.Name = "button2";
            button2.Size = new Size(217, 54);
            button2.TabIndex = 1;
            button2.Text = "Manage Rooms";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5bd363505a760_wallpaper_preview;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1073, 542);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}