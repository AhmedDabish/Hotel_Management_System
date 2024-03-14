namespace Hotel_Management_System
{
    partial class Paying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paying));
            pay = new TextBox();
            label1 = new Label();
            paym = new Button();
            Money = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // pay
            // 
            pay.Font = new Font("Simple Outline Pat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pay.Location = new Point(263, 184);
            pay.Name = "pay";
            pay.PlaceholderText = "Room Number";
            pay.Size = new Size(265, 33);
            pay.TabIndex = 5;
            pay.TextAlign = HorizontalAlignment.Center;
            pay.TextChanged += pay_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(331, 146);
            label1.Name = "label1";
            label1.Size = new Size(125, 35);
            label1.TabIndex = 4;
            label1.Text = "Paying";
            // 
            // paym
            // 
            paym.BackColor = Color.Firebrick;
            paym.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            paym.ForeColor = Color.White;
            paym.Location = new Point(306, 263);
            paym.Name = "paym";
            paym.Size = new Size(168, 45);
            paym.TabIndex = 3;
            paym.Text = "Done";
            paym.UseVisualStyleBackColor = false;
            paym.Click += paym_Click;
            // 
            // Money
            // 
            Money.Font = new Font("Simple Outline Pat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Money.Location = new Point(263, 224);
            Money.Name = "Money";
            Money.PlaceholderText = "Money";
            Money.Size = new Size(265, 33);
            Money.TabIndex = 6;
            Money.TextAlign = HorizontalAlignment.Center;
            Money.TextChanged += Money_TextChanged;
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
            // Paying
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images4;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(Money);
            Controls.Add(pay);
            Controls.Add(label1);
            Controls.Add(paym);
            Name = "Paying";
            Text = "Paying";
            Load += Paying_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pay;
        private Label label1;
        private Button paym;
        private TextBox Money;
        private Button button5;
    }
}