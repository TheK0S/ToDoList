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
            menu = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            monthCalendar1 = new MonthCalendar();
            tabPage2 = new TabPage();
            dragDropLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            addBTN = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            removeBTN = new Button();
            panel7 = new Panel();
            tabPage3 = new TabPage();
            sort_Panel = new Panel();
            sort_priority = new RadioButton();
            sort_startDate = new RadioButton();
            sort_deadline = new RadioButton();
            sort_name = new RadioButton();
            sort_default = new RadioButton();
            listField = new Panel();
            panel1 = new Panel();
            menu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tabPage3.SuspendLayout();
            sort_Panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.Controls.Add(tabControl1);
            menu.Dock = DockStyle.Left;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(236, 526);
            menu.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(236, 526);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(10, 10, 10);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(228, 496);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Календарь";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.MenuHighlight;
            monthCalendar1.CalendarDimensions = new Size(1, 3);
            monthCalendar1.Location = new Point(33, 25);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(10, 10, 10);
            tabPage2.Controls.Add(dragDropLabel);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(228, 496);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Изменить";
            // 
            // dragDropLabel
            // 
            dragDropLabel.AllowDrop = true;
            dragDropLabel.Dock = DockStyle.Fill;
            dragDropLabel.Location = new Point(3, 3);
            dragDropLabel.Name = "dragDropLabel";
            dragDropLabel.Size = new Size(222, 412);
            dragDropLabel.TabIndex = 2;
            dragDropLabel.Text = "Перетащи список дел сюда";
            dragDropLabel.TextAlign = ContentAlignment.MiddleCenter;
            dragDropLabel.DragDrop += label1_DragDrop;
            dragDropLabel.DragEnter += label1_DragEnter;
            dragDropLabel.DragLeave += label1_DragLeave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(10, 10, 10);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 415);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(222, 78);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(addBTN);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 33);
            panel4.TabIndex = 1;
            // 
            // addBTN
            // 
            addBTN.Dock = DockStyle.Fill;
            addBTN.FlatStyle = FlatStyle.Popup;
            addBTN.Location = new Point(20, 0);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(196, 33);
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
            panel3.Size = new Size(20, 33);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(removeBTN);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 42);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 33);
            panel5.TabIndex = 2;
            // 
            // removeBTN
            // 
            removeBTN.Dock = DockStyle.Fill;
            removeBTN.FlatStyle = FlatStyle.Popup;
            removeBTN.Location = new Point(20, 0);
            removeBTN.Name = "removeBTN";
            removeBTN.Size = new Size(196, 33);
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
            panel7.Size = new Size(20, 33);
            panel7.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(10, 10, 10);
            tabPage3.Controls.Add(sort_Panel);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(228, 498);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Сортировка";
            // 
            // sort_Panel
            // 
            sort_Panel.BackColor = Color.FromArgb(10, 10, 10);
            sort_Panel.Controls.Add(sort_priority);
            sort_Panel.Controls.Add(sort_startDate);
            sort_Panel.Controls.Add(sort_deadline);
            sort_Panel.Controls.Add(sort_name);
            sort_Panel.Controls.Add(sort_default);
            sort_Panel.Dock = DockStyle.Fill;
            sort_Panel.Location = new Point(3, 3);
            sort_Panel.Name = "sort_Panel";
            sort_Panel.Size = new Size(222, 492);
            sort_Panel.TabIndex = 1;
            // 
            // sort_priority
            // 
            sort_priority.Anchor = AnchorStyles.Top;
            sort_priority.AutoSize = true;
            sort_priority.Location = new Point(43, 180);
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
            sort_startDate.Location = new Point(43, 140);
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
            sort_deadline.Location = new Point(43, 100);
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
            sort_name.Location = new Point(43, 60);
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
            sort_default.Location = new Point(43, 20);
            sort_default.Name = "sort_default";
            sort_default.Size = new Size(123, 23);
            sort_default.TabIndex = 0;
            sort_default.TabStop = true;
            sort_default.Text = "По умолчанию";
            sort_default.UseVisualStyleBackColor = true;
            // 
            // listField
            // 
            listField.AutoScroll = true;
            listField.BackColor = Color.FromArgb(10, 10, 10);
            listField.Dock = DockStyle.Fill;
            listField.Location = new Point(236, 0);
            listField.Name = "listField";
            listField.Size = new Size(890, 526);
            listField.TabIndex = 1;
            listField.Resize += listField_Resize;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(10, 10, 10);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(listField);
            panel1.Controls.Add(menu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 526);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 526);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkGray;
            Name = "Form1";
            Text = "ToDoList";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            sort_Panel.ResumeLayout(false);
            sort_Panel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel menu;
        private Panel sort_Panel;
        private RadioButton sort_priority;
        private RadioButton sort_startDate;
        private RadioButton sort_deadline;
        private RadioButton sort_name;
        private RadioButton sort_default;
        private Panel listField;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MonthCalendar monthCalendar1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Button addBTN;
        private Panel panel3;
        private Panel panel5;
        private Button removeBTN;
        private Panel panel7;
        private TabPage tabPage3;
        private Label dragDropLabel;
    }
}