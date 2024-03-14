namespace Hotel_Management_System
{
    partial class ManageRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRooms));
            panel1 = new Panel();
            Room_Type = new DomainUpDown();
            label8 = new Label();
            Describtion = new TextBox();
            label5 = new Label();
            label3 = new Label();
            Price_In_Day = new TextBox();
            label2 = new Label();
            Room_Phone = new TextBox();
            label1 = new Label();
            label7 = new Label();
            Add_New_Room = new Button();
            Clear_Fields = new Button();
            Edit = new Button();
            Remove = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Room_Type);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Describtion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Price_In_Day);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Room_Phone);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 415);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Room_Type
            // 
            Room_Type.Items.Add("1");
            Room_Type.Items.Add("2");
            Room_Type.Items.Add("3");
            Room_Type.Items.Add("4");
            Room_Type.Items.Add("5");
            Room_Type.Items.Add("6");
            Room_Type.Items.Add("7");
            Room_Type.Location = new Point(196, 69);
            Room_Type.Name = "Room_Type";
            Room_Type.Size = new Size(184, 27);
            Room_Type.TabIndex = 13;
            Room_Type.Text = "Choose";
            Room_Type.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(44, 198);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 12;
            label8.Text = "Price in Day";
            // 
            // Describtion
            // 
            Describtion.Location = new Point(58, 299);
            Describtion.Multiline = true;
            Describtion.Name = "Describtion";
            Describtion.Size = new Size(353, 94);
            Describtion.TabIndex = 9;
            Describtion.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(58, 64);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 8;
            label5.Text = "Room Type";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 258);
            label3.Name = "label3";
            label3.Size = new Size(193, 28);
            label3.TabIndex = 4;
            label3.Text = "Room Describtion :";
            // 
            // Price_In_Day
            // 
            Price_In_Day.Location = new Point(196, 198);
            Price_In_Day.Multiline = true;
            Price_In_Day.Name = "Price_In_Day";
            Price_In_Day.Size = new Size(178, 39);
            Price_In_Day.TabIndex = 3;
            Price_In_Day.TextChanged += Price_In_Day_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 134);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 2;
            label2.Text = "Room Phone";
            // 
            // Room_Phone
            // 
            Room_Phone.Location = new Point(196, 126);
            Room_Phone.Multiline = true;
            Room_Phone.Name = "Room_Phone";
            Room_Phone.Size = new Size(184, 36);
            Room_Phone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 121);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(385, 9);
            label7.Name = "label7";
            label7.Size = new Size(246, 41);
            label7.TabIndex = 12;
            label7.Text = "Manage Rooms";
            label7.Click += label7_Click;
            // 
            // Add_New_Room
            // 
            Add_New_Room.BackColor = Color.ForestGreen;
            Add_New_Room.ForeColor = Color.White;
            Add_New_Room.Location = new Point(27, 466);
            Add_New_Room.Margin = new Padding(4);
            Add_New_Room.Name = "Add_New_Room";
            Add_New_Room.Size = new Size(176, 49);
            Add_New_Room.TabIndex = 16;
            Add_New_Room.Text = "Add New Room";
            Add_New_Room.UseVisualStyleBackColor = false;
            Add_New_Room.Click += button4_Click;
            // 
            // Clear_Fields
            // 
            Clear_Fields.BackColor = Color.ForestGreen;
            Clear_Fields.ForeColor = Color.White;
            Clear_Fields.Location = new Point(27, 523);
            Clear_Fields.Margin = new Padding(4);
            Clear_Fields.Name = "Clear_Fields";
            Clear_Fields.Size = new Size(426, 50);
            Clear_Fields.TabIndex = 15;
            Clear_Fields.Text = "Clear Fields";
            Clear_Fields.UseVisualStyleBackColor = false;
            Clear_Fields.Click += button3_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.ForestGreen;
            Edit.ForeColor = Color.WhiteSmoke;
            Edit.Location = new Point(207, 466);
            Edit.Margin = new Padding(4);
            Edit.Name = "Edit";
            Edit.Size = new Size(122, 49);
            Edit.TabIndex = 14;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += button2_Click;
            // 
            // Remove
            // 
            Remove.BackColor = Color.FromArgb(192, 0, 0);
            Remove.ForeColor = Color.White;
            Remove.Location = new Point(337, 466);
            Remove.Margin = new Padding(4);
            Remove.Name = "Remove";
            Remove.Size = new Size(116, 49);
            Remove.TabIndex = 13;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(515, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(448, 465);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.PanWest;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(2, 4);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(95, 43);
            button5.TabIndex = 17;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ManageRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 587);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(Add_New_Room);
            Controls.Add(Clear_Fields);
            Controls.Add(Edit);
            Controls.Add(Remove);
            Controls.Add(label7);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "ManageRooms";
            Text = "ManageRoomsFormcs";
            Load += ManageRoomsFormcs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox Describtion;
        private Label label5;
        private Label label3;
        private TextBox Price_In_Day;
        private Label label2;
        private TextBox Room_Phone;
        private Label label1;
        private Label label7;
        private Label label8;
        private DomainUpDown Room_Type;
        private Button Add_New_Room;
        private Button Clear_Fields;
        private Button Edit;
        private Button Remove;
        private DataGridView dataGridView1;
        private Button button5;
    }
}