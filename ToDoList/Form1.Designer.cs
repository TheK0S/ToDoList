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
            sortBTN = new Button();
            panel6 = new Panel();
            panel1.SuspendLayout();
            menu.SuspendLayout();
            sort_Panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(listField);
            panel1.Controls.Add(menu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 465);
            panel1.TabIndex = 0;
            // 
            // listField
            // 
            listField.AutoScroll = true;
            listField.AutoSize = true;
            listField.BackColor = Color.Transparent;
            listField.Dock = DockStyle.Fill;
            listField.Location = new Point(160, 0);
            listField.Name = "listField";
            listField.Size = new Size(640, 465);
            listField.TabIndex = 1;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.Controls.Add(sort_Panel);
            menu.Controls.Add(tableLayoutPanel1);
            menu.Dock = DockStyle.Left;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(160, 465);
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
            sort_Panel.Location = new Point(0, 100);
            sort_Panel.Name = "sort_Panel";
            sort_Panel.Size = new Size(160, 365);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(160, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(addBTN);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(154, 44);
            panel4.TabIndex = 1;
            // 
            // addBTN
            // 
            addBTN.Dock = DockStyle.Fill;
            addBTN.FlatStyle = FlatStyle.Popup;
            addBTN.Location = new Point(20, 0);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(134, 44);
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
            panel3.Size = new Size(20, 44);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(sortBTN);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 53);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 44);
            panel5.TabIndex = 2;
            // 
            // sortBTN
            // 
            sortBTN.Dock = DockStyle.Fill;
            sortBTN.FlatStyle = FlatStyle.Popup;
            sortBTN.Location = new Point(20, 0);
            sortBTN.Name = "sortBTN";
            sortBTN.Size = new Size(134, 44);
            sortBTN.TabIndex = 3;
            sortBTN.Text = "Сортировка";
            sortBTN.UseVisualStyleBackColor = true;
            sortBTN.Click += sortBTN_Click;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Dock = DockStyle.Left;
            panel6.ForeColor = Color.DarkGray;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(20, 44);
            panel6.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 465);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkGray;
            Name = "Form1";
            Text = "ToDoList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menu.ResumeLayout(false);
            sort_Panel.ResumeLayout(false);
            sort_Panel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}