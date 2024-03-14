namespace Hotel_Management_System
{
    partial class Manage_Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Clients));
            panel1 = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(283, 36);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 412);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.WindowFrame;
            textBox5.Location = new Point(40, 338);
            textBox5.Margin = new Padding(4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Address";
            textBox5.Size = new Size(275, 40);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.WindowFrame;
            textBox4.Location = new Point(40, 106);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "National ID";
            textBox4.Size = new Size(275, 38);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(40, 181);
            textBox3.Margin = new Padding(4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Phone";
            textBox3.Size = new Size(275, 36);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(40, 264);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Email";
            textBox2.Size = new Size(275, 32);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(40, 36);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Full Name";
            textBox1.Size = new Size(275, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(703, 36);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(451, 511);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(579, 456);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(116, 64);
            button1.TabIndex = 2;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(425, 456);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(146, 64);
            button2.TabIndex = 3;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.ForeColor = Color.White;
            button3.Location = new Point(231, 528);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(463, 50);
            button3.TabIndex = 4;
            button3.Text = "Clear Fields";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.ForeColor = Color.White;
            button4.Location = new Point(231, 456);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(186, 64);
            button4.TabIndex = 5;
            button4.Text = "Add New Client";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.PanWest;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(2, 535);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(95, 43);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Manage_Clients
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1181, 586);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Manage_Clients";
            Text = "Manage_Clients";
            Load += Manage_Clients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}