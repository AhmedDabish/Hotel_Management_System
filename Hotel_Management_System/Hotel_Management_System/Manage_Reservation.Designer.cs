namespace Hotel_Management_System.Models
{
    partial class Manage_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Reservation));
            panel1 = new Panel();
            Date_out = new DateTimePicker();
            Date_in = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Pay_up = new TextBox();
            Room_num = new TextBox();
            Client_id = new TextBox();
            New_Reservation = new Button();
            Clear = new Button();
            Edit = new Button();
            Remove = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Date_out);
            panel1.Controls.Add(Date_in);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Pay_up);
            panel1.Controls.Add(Room_num);
            panel1.Controls.Add(Client_id);
            panel1.Location = new Point(60, 27);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 401);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // Date_out
            // 
            Date_out.CustomFormat = "dd/mm/yyyy";
            Date_out.Format = DateTimePickerFormat.Short;
            Date_out.Location = new Point(164, 232);
            Date_out.Name = "Date_out";
            Date_out.Size = new Size(275, 27);
            Date_out.TabIndex = 15;
            Date_out.Value = new DateTime(2024, 3, 11, 0, 0, 0, 0);
            // 
            // Date_in
            // 
            Date_in.CustomFormat = "dd/mm/yyyy";
            Date_in.Format = DateTimePickerFormat.Short;
            Date_in.Location = new Point(164, 168);
            Date_in.Name = "Date_in";
            Date_in.Size = new Size(275, 27);
            Date_in.TabIndex = 14;
            Date_in.Value = new DateTime(2024, 3, 11, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(21, 93);
            label5.Name = "label5";
            label5.Size = new Size(136, 31);
            label5.TabIndex = 11;
            label5.Text = "Room Num";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(40, 164);
            label4.Name = "label4";
            label4.Size = new Size(91, 31);
            label4.TabIndex = 10;
            label4.Text = "Date In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(40, 228);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 9;
            label3.Text = "Data Out";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(56, 288);
            label2.Name = "label2";
            label2.Size = new Size(88, 31);
            label2.TabIndex = 8;
            label2.Text = "Pay Up";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 36);
            label1.Name = "label1";
            label1.Size = new Size(104, 31);
            label1.TabIndex = 7;
            label1.Text = "Client Id";
            // 
            // Pay_up
            // 
            Pay_up.ForeColor = SystemColors.WindowFrame;
            Pay_up.Location = new Point(164, 288);
            Pay_up.Margin = new Padding(4);
            Pay_up.Multiline = true;
            Pay_up.Name = "Pay_up";
            Pay_up.Size = new Size(275, 31);
            Pay_up.TabIndex = 5;
            Pay_up.TextChanged += Pay_up_TextChanged;
            // 
            // Room_num
            // 
            Room_num.ForeColor = SystemColors.WindowFrame;
            Room_num.Location = new Point(164, 93);
            Room_num.Margin = new Padding(4);
            Room_num.Multiline = true;
            Room_num.Name = "Room_num";
            Room_num.Size = new Size(275, 31);
            Room_num.TabIndex = 3;
            Room_num.TextChanged += Room_num_TextChanged;
            // 
            // Client_id
            // 
            Client_id.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Client_id.ForeColor = SystemColors.WindowFrame;
            Client_id.Location = new Point(164, 38);
            Client_id.Margin = new Padding(4);
            Client_id.Multiline = true;
            Client_id.Name = "Client_id";
            Client_id.Size = new Size(275, 34);
            Client_id.TabIndex = 0;
            Client_id.TextChanged += textBox1_TextChanged;
            // 
            // New_Reservation
            // 
            New_Reservation.BackColor = Color.ForestGreen;
            New_Reservation.ForeColor = Color.White;
            New_Reservation.Location = new Point(60, 436);
            New_Reservation.Margin = new Padding(4);
            New_Reservation.Name = "New_Reservation";
            New_Reservation.Size = new Size(186, 49);
            New_Reservation.TabIndex = 11;
            New_Reservation.Text = "New Reservation";
            New_Reservation.UseVisualStyleBackColor = false;
            New_Reservation.Click += button4_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.ForestGreen;
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(60, 493);
            Clear.Margin = new Padding(4);
            Clear.Name = "Clear";
            Clear.Size = new Size(348, 50);
            Clear.TabIndex = 10;
            Clear.Text = "Clear Fields";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.ForestGreen;
            Edit.ForeColor = Color.WhiteSmoke;
            Edit.Location = new Point(254, 436);
            Edit.Margin = new Padding(4);
            Edit.Name = "Edit";
            Edit.Size = new Size(146, 49);
            Edit.TabIndex = 9;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Remove
            // 
            Remove.BackColor = Color.FromArgb(192, 0, 0);
            Remove.ForeColor = Color.White;
            Remove.Location = new Point(408, 436);
            Remove.Margin = new Padding(4);
            Remove.Name = "Remove";
            Remove.Size = new Size(116, 49);
            Remove.TabIndex = 8;
            Remove.Text = "End";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(577, 27);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(422, 511);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(408, 494);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(116, 49);
            button1.TabIndex = 12;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.PanWest;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(95, 43);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Manage_Reservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1115, 593);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(New_Reservation);
            Controls.Add(Clear);
            Controls.Add(Edit);
            Controls.Add(Remove);
            Controls.Add(dataGridView1);
            Name = "Manage_Reservation";
            Text = "Manage_Reservation";
            Load += Manage_Reservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox Room_num;
        private TextBox Client_id;
        private Button New_Reservation;
        private Button Clear;
        private Button Edit;
        private Button Remove;
        private DataGridView dataGridView1;
        private TextBox Pay_up;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker Date_in;
        private DateTimePicker Date_out;
        private Button button1;
        private Button button5;
    }
}