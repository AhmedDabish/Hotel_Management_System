namespace Hotel_Management_System
{
    partial class EndRservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndRservation));
            Roomnum = new TextBox();
            label1 = new Label();
            End = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // Roomnum
            // 
            Roomnum.Font = new Font("Simple Outline Pat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Roomnum.Location = new Point(268, 201);
            Roomnum.Name = "Roomnum";
            Roomnum.PlaceholderText = "Room Number";
            Roomnum.Size = new Size(265, 33);
            Roomnum.TabIndex = 5;
            Roomnum.TextAlign = HorizontalAlignment.Center;
            Roomnum.TextChanged += Roomnum_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(268, 148);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 4;
            label1.Text = "End Reservation";
            // 
            // End
            // 
            End.BackColor = Color.Firebrick;
            End.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            End.ForeColor = Color.White;
            End.Location = new Point(306, 263);
            End.Name = "End";
            End.Size = new Size(168, 45);
            End.TabIndex = 3;
            End.Text = "End";
            End.UseVisualStyleBackColor = false;
            End.Click += End_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.PanWest;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(27, 395);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(95, 43);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // EndRservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images4;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(868, 450);
            Controls.Add(button5);
            Controls.Add(Roomnum);
            Controls.Add(label1);
            Controls.Add(End);
            Name = "EndRservation";
            Text = "EndRservation";
            Load += EndRservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Roomnum;
        private Label label1;
        private Button End;
        private Button button5;
    }
}