namespace ToDoList
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
            panel1 = new Panel();
            listField = new Panel();
            listView1 = new ListView();
            startDate = new ColumnHeader();
            deadline = new ColumnHeader();
            teg = new ColumnHeader();
            comments = new ColumnHeader();
            priority = new ColumnHeader();
            menu = new Panel();
            sort_Panel = new Panel();
            sort_priority = new RadioButton();
            sort_startDate = new RadioButton();
            sort_deadline = new RadioButton();
            sort_name = new RadioButton();
            sort_default = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            addBTN = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            removeBTN = new Button();
            panel7 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            sortBTN = new Button();
            panel1.SuspendLayout();
            listField.SuspendLayout();
            menu.SuspendLayout();
            sort_Panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(listField);
            panel1.Controls.Add(menu);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 468);
            panel1.TabIndex = 0;
            // 
            // listField
            // 
            listField.AutoScroll = true;
            listField.AutoSize = true;
            listField.BackColor = Color.Transparent;
            listField.Controls.Add(listView1);
            listField.Dock = DockStyle.Fill;
            listField.Location = new Point(160, 0);
            listField.Name = "listField";
            listField.Size = new Size(643, 468);
            listField.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.BackColor = Color.FromArgb(10, 10, 10);
            listView1.BackgroundImage = (Image)resources.GetObject("listView1.BackgroundImage");
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Columns.AddRange(new ColumnHeader[] { startDate, deadline, teg, comments, priority });
            listView1.Dock = DockStyle.Fill;
            listView1.ForeColor = Color.LightGray;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(643, 468);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // startDate
            // 
            startDate.Text = "Дата начала";
            startDate.Width = 200;
            // 
            // deadline
            // 
            deadline.Text = "Дата окончания";
            // 
            // teg
            // 
            teg.DisplayIndex = 3;
            teg.Text = "Тег";
            teg.Width = 80;
            // 
            // comments
            // 
            comments.DisplayIndex = 2;
            comments.Text = "Текст";
            comments.Width = 500;
            // 
            // priority
            // 
            priority.Text = "Приоритет";
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.Controls.Add(sort_Panel);
            menu.Controls.Add(tableLayoutPanel1);
            menu.Dock = DockStyle.Left;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(160, 468);
            menu.TabIndex = 0;
            // 
            // sort_Panel
            // 
            sort_Panel.Controls.Add(sort_priority);
            sort_Panel.Controls.Add(sort_startDate);
            sort_Panel.Controls.Add(sort_deadline);
            sort_Panel.Controls.Add(sort_name);
            sort_Panel.Controls.Add(sort_default);
            sort_Panel.Dock = DockStyle.Fill;
            sort_Panel.Location = new Point(0, 114);
            sort_Panel.Name = "sort_Panel";
            sort_Panel.Size = new Size(160, 354);
            sort_Panel.TabIndex = 1;
            sort_Panel.Visible = false;
            // 
            // sort_priority
            // 
            sort_priority.Anchor = AnchorStyles.Top;
            sort_priority.AutoSize = true;
            sort_priority.Location = new Point(12, 180);
            sort_priority.Name = "sort_priority";
            sort_priority.Size = new Size(96, 23);
            sort_priority.TabIndex = 4;
            sort_priority.Text = "Приоритет";
            sort_priority.UseVisualStyleBackColor = true;
            // 
            // sort_startDate
            // 
            sort_startDate.Anchor = AnchorStyles.Top;
            sort_startDate.AutoSize = true;
            sort_startDate.Location = new Point(12, 140);
            sort_startDate.Name = "sort_startDate";
            sort_startDate.Size = new Size(119, 23);
            sort_startDate.TabIndex = 3;
            sort_startDate.Text = "Дата создания";
            sort_startDate.UseVisualStyleBackColor = true;
            // 
            // sort_deadline
            // 
            sort_deadline.Anchor = AnchorStyles.Top;
            sort_deadline.AutoSize = true;
            sort_deadline.Location = new Point(12, 100);
            sort_deadline.Name = "sort_deadline";
            sort_deadline.Size = new Size(141, 23);
            sort_deadline.TabIndex = 2;
            sort_deadline.Text = "Срок выполнения";
            sort_deadline.UseVisualStyleBackColor = true;
            // 
            // sort_name
            // 
            sort_name.Anchor = AnchorStyles.Top;
            sort_name.AutoSize = true;
            sort_name.Location = new Point(12, 60);
            sort_name.Name = "sort_name";
            sort_name.Size = new Size(87, 23);
            sort_name.TabIndex = 1;
            sort_name.Text = "Название";
            sort_name.UseVisualStyleBackColor = true;
            // 
            // sort_default
            // 
            sort_default.Anchor = AnchorStyles.Top;
            sort_default.AutoSize = true;
            sort_default.Checked = true;
            sort_default.Location = new Point(12, 20);
            sort_default.Name = "sort_default";
            sort_default.Size = new Size(123, 23);
            sort_default.TabIndex = 0;
            sort_default.TabStop = true;
            sort_default.Text = "По умолчанию";
            sort_default.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(160, 114);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(addBTN);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(154, 31);
            panel4.TabIndex = 1;
            // 
            // addBTN
            // 
            addBTN.Dock = DockStyle.Fill;
            addBTN.FlatStyle = FlatStyle.Popup;
            addBTN.Location = new Point(20, 0);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(134, 31);
            addBTN.TabIndex = 2;
            addBTN.Text = "Добавить";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 31);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(removeBTN);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 31);
            panel5.TabIndex = 2;
            // 
            // removeBTN
            // 
            removeBTN.Dock = DockStyle.Fill;
            removeBTN.FlatStyle = FlatStyle.Popup;
            removeBTN.Location = new Point(20, 0);
            removeBTN.Name = "removeBTN";
            removeBTN.Size = new Size(134, 31);
            removeBTN.TabIndex = 3;
            removeBTN.Text = "Удалить";
            removeBTN.UseVisualStyleBackColor = true;
            removeBTN.Click += removeBTN_Click;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(20, 31);
            panel7.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(sortBTN);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 34);
            panel2.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Dock = DockStyle.Left;
            panel6.ForeColor = Color.DarkGray;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(20, 34);
            panel6.TabIndex = 0;
            // 
            // sortBTN
            // 
            sortBTN.Dock = DockStyle.Fill;
            sortBTN.FlatStyle = FlatStyle.Popup;
            sortBTN.Location = new Point(0, 0);
            sortBTN.Name = "sortBTN";
            sortBTN.Size = new Size(154, 34);
            sortBTN.TabIndex = 3;
            sortBTN.Text = "Сортировка";
            sortBTN.UseVisualStyleBackColor = true;
            sortBTN.Click += sortBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkGray;
            Name = "Form1";
            Text = "ToDoList";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            listField.ResumeLayout(false);
            menu.ResumeLayout(false);
            sort_Panel.ResumeLayout(false);
            sort_Panel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel menu;
        private Panel listField;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel sort_Panel;
        private RadioButton sort_priority;
        private RadioButton sort_startDate;
        private RadioButton sort_deadline;
        private RadioButton sort_name;
        private RadioButton sort_default;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Button addBTN;
        private Button sortBTN;
        private Button removeBTN;
        private Panel panel7;
        private Panel panel2;
        private ListView listView1;
        private ColumnHeader startDate;
        private ColumnHeader deadline;
        private ColumnHeader teg;
        private ColumnHeader comments;
        private ColumnHeader priority;
    }
}