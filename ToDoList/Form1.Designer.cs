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
            Calendar = new MonthCalendar();
            tabPage2 = new TabPage();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            searchField = new TextBox();
            label1 = new Label();
            sort_priority = new RadioButton();
            sort_startDate = new RadioButton();
            sort_deadline = new RadioButton();
            sort_name = new RadioButton();
            sort_default = new RadioButton();
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
            create_pdf = new Button();
            create_addTask = new Button();
            label8 = new Label();
            userFilePath = new Label();
            addFile = new Button();
            prioritySelector = new DomainUpDown();
            create_text = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            create_endDate = new DateTimePicker();
            label5 = new Label();
            create_startDate = new DateTimePicker();
            label4 = new Label();
            create_header = new TextBox();
            listField = new Panel();
            panel1 = new Panel();
            create_openFile = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(236, 526);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(10, 10, 10);
            tabPage1.Controls.Add(Calendar);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(228, 496);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Календарь";
            // 
            // Calendar
            // 
            Calendar.BackColor = SystemColors.MenuHighlight;
            Calendar.CalendarDimensions = new Size(1, 3);
            Calendar.Location = new Point(33, 25);
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(10, 10, 10);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(searchField);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(sort_priority);
            tabPage2.Controls.Add(sort_startDate);
            tabPage2.Controls.Add(sort_deadline);
            tabPage2.Controls.Add(sort_name);
            tabPage2.Controls.Add(sort_default);
            tabPage2.Controls.Add(dragDropLabel);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(228, 496);
            tabPage2.TabIndex = 1;
            tabPage2.Text = " Изменить";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 10);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 14;
            label2.Text = "Поиск";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(122, 76);
            button2.Name = "button2";
            button2.Size = new Size(100, 33);
            button2.TabIndex = 3;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(8, 76);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 2;
            button1.Text = "Искать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchField
            // 
            searchField.BackColor = Color.FromArgb(20, 20, 20);
            searchField.ForeColor = Color.DarkGray;
            searchField.Location = new Point(8, 45);
            searchField.Name = "searchField";
            searchField.Size = new Size(214, 25);
            searchField.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 135);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 10;
            label1.Text = "Сортировка";
            // 
            // sort_priority
            // 
            sort_priority.Anchor = AnchorStyles.Top;
            sort_priority.AutoSize = true;
            sort_priority.Location = new Point(44, 282);
            sort_priority.Name = "sort_priority";
            sort_priority.Size = new Size(96, 23);
            sort_priority.TabIndex = 9;
            sort_priority.Text = "Приоритет";
            sort_priority.UseVisualStyleBackColor = true;
            sort_priority.CheckedChanged += sort_priority_CheckedChanged;
            // 
            // sort_startDate
            // 
            sort_startDate.Anchor = AnchorStyles.Top;
            sort_startDate.AutoSize = true;
            sort_startDate.Location = new Point(44, 252);
            sort_startDate.Name = "sort_startDate";
            sort_startDate.Size = new Size(119, 23);
            sort_startDate.TabIndex = 8;
            sort_startDate.Text = "Дата создания";
            sort_startDate.UseVisualStyleBackColor = true;
            sort_startDate.CheckedChanged += sort_startDate_CheckedChanged;
            // 
            // sort_deadline
            // 
            sort_deadline.Anchor = AnchorStyles.Top;
            sort_deadline.AutoSize = true;
            sort_deadline.Location = new Point(44, 222);
            sort_deadline.Name = "sort_deadline";
            sort_deadline.Size = new Size(141, 23);
            sort_deadline.TabIndex = 7;
            sort_deadline.Text = "Срок выполнения";
            sort_deadline.UseVisualStyleBackColor = true;
            sort_deadline.CheckedChanged += sort_deadline_CheckedChanged;
            // 
            // sort_name
            // 
            sort_name.Anchor = AnchorStyles.Top;
            sort_name.AutoSize = true;
            sort_name.Location = new Point(44, 192);
            sort_name.Name = "sort_name";
            sort_name.Size = new Size(87, 23);
            sort_name.TabIndex = 6;
            sort_name.Text = "Название";
            sort_name.UseVisualStyleBackColor = true;
            sort_name.CheckedChanged += sort_name_CheckedChanged;
            // 
            // sort_default
            // 
            sort_default.Anchor = AnchorStyles.Top;
            sort_default.AutoSize = true;
            sort_default.Checked = true;
            sort_default.Location = new Point(44, 162);
            sort_default.Name = "sort_default";
            sort_default.Size = new Size(123, 23);
            sort_default.TabIndex = 5;
            sort_default.TabStop = true;
            sort_default.Text = "По умолчанию";
            sort_default.UseVisualStyleBackColor = true;
            sort_default.CheckedChanged += sort_default_CheckedChanged;
            // 
            // dragDropLabel
            // 
            dragDropLabel.AllowDrop = true;
            dragDropLabel.Dock = DockStyle.Bottom;
            dragDropLabel.Location = new Point(3, 317);
            dragDropLabel.Name = "dragDropLabel";
            dragDropLabel.Size = new Size(222, 98);
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
            addBTN.FlatStyle = FlatStyle.Flat;
            addBTN.Location = new Point(20, 0);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(196, 33);
            addBTN.TabIndex = 4;
            addBTN.Text = "Добавить файлы";
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
            removeBTN.FlatStyle = FlatStyle.Flat;
            removeBTN.Location = new Point(20, 0);
            removeBTN.Name = "removeBTN";
            removeBTN.Size = new Size(196, 33);
            removeBTN.TabIndex = 5;
            removeBTN.Text = "Удалить выделенные";
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
            tabPage3.Text = "  Создать   ";
            // 
            // sort_Panel
            // 
            sort_Panel.BackColor = Color.FromArgb(10, 10, 10);
            sort_Panel.Controls.Add(create_pdf);
            sort_Panel.Controls.Add(create_addTask);
            sort_Panel.Controls.Add(label8);
            sort_Panel.Controls.Add(userFilePath);
            sort_Panel.Controls.Add(addFile);
            sort_Panel.Controls.Add(prioritySelector);
            sort_Panel.Controls.Add(create_text);
            sort_Panel.Controls.Add(label3);
            sort_Panel.Controls.Add(label7);
            sort_Panel.Controls.Add(label6);
            sort_Panel.Controls.Add(create_endDate);
            sort_Panel.Controls.Add(label5);
            sort_Panel.Controls.Add(create_startDate);
            sort_Panel.Controls.Add(label4);
            sort_Panel.Controls.Add(create_header);
            sort_Panel.Dock = DockStyle.Fill;
            sort_Panel.Location = new Point(3, 3);
            sort_Panel.Name = "sort_Panel";
            sort_Panel.Size = new Size(222, 492);
            sort_Panel.TabIndex = 1;
            // 
            // create_pdf
            // 
            create_pdf.FlatStyle = FlatStyle.Flat;
            create_pdf.Location = new Point(26, 213);
            create_pdf.Name = "create_pdf";
            create_pdf.Size = new Size(171, 32);
            create_pdf.TabIndex = 13;
            create_pdf.Text = "Экспорт в pdf";
            create_pdf.UseVisualStyleBackColor = true;
            create_pdf.Click += create_pdf_Click;
            // 
            // create_addTask
            // 
            create_addTask.FlatStyle = FlatStyle.Flat;
            create_addTask.Location = new Point(27, 449);
            create_addTask.Name = "create_addTask";
            create_addTask.Size = new Size(171, 32);
            create_addTask.TabIndex = 7;
            create_addTask.Text = "Дабавить задачу";
            create_addTask.UseVisualStyleBackColor = true;
            create_addTask.Click += create_addTask_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 343);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 12;
            label8.Text = "Текст задачи";
            // 
            // userFilePath
            // 
            userFilePath.Location = new Point(11, 307);
            userFilePath.Name = "userFilePath";
            userFilePath.Size = new Size(201, 36);
            userFilePath.TabIndex = 11;
            // 
            // addFile
            // 
            addFile.FlatStyle = FlatStyle.Flat;
            addFile.Location = new Point(26, 263);
            addFile.Name = "addFile";
            addFile.Size = new Size(171, 32);
            addFile.TabIndex = 5;
            addFile.Text = "Прикрепить файл";
            addFile.UseVisualStyleBackColor = true;
            addFile.Click += addFile_Click;
            // 
            // prioritySelector
            // 
            prioritySelector.BackColor = Color.FromArgb(10, 10, 10);
            prioritySelector.BorderStyle = BorderStyle.FixedSingle;
            prioritySelector.ForeColor = Color.DarkGray;
            prioritySelector.Items.Add("Высокий");
            prioritySelector.Items.Add("Средний");
            prioritySelector.Items.Add("Низкий");
            prioritySelector.Location = new Point(82, 173);
            prioritySelector.Name = "prioritySelector";
            prioritySelector.Size = new Size(130, 25);
            prioritySelector.TabIndex = 4;
            // 
            // create_text
            // 
            create_text.BackColor = Color.FromArgb(20, 20, 20);
            create_text.BorderStyle = BorderStyle.FixedSingle;
            create_text.ForeColor = Color.DarkGray;
            create_text.Location = new Point(11, 371);
            create_text.Multiline = true;
            create_text.Name = "create_text";
            create_text.ScrollBars = ScrollBars.Both;
            create_text.Size = new Size(201, 68);
            create_text.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 4);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 0;
            label3.Text = "Заголовок";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 134);
            label7.Name = "label7";
            label7.Size = new Size(27, 19);
            label7.TabIndex = 8;
            label7.Text = "До";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 96);
            label6.Name = "label6";
            label6.Size = new Size(26, 19);
            label6.TabIndex = 7;
            label6.Text = "От";
            // 
            // create_endDate
            // 
            create_endDate.CustomFormat = "dd. MM. yyyy HH:mm";
            create_endDate.Format = DateTimePickerFormat.Custom;
            create_endDate.Location = new Point(40, 130);
            create_endDate.Name = "create_endDate";
            create_endDate.Size = new Size(172, 25);
            create_endDate.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 65);
            label5.Name = "label5";
            label5.Size = new Size(133, 19);
            label5.TabIndex = 5;
            label5.Text = "Планируемые даты";
            // 
            // create_startDate
            // 
            create_startDate.CustomFormat = "dd. MM. yyyy HH:mm";
            create_startDate.Format = DateTimePickerFormat.Custom;
            create_startDate.Location = new Point(41, 90);
            create_startDate.Name = "create_startDate";
            create_startDate.Size = new Size(171, 25);
            create_startDate.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 175);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 2;
            label4.Text = "Приоритет";
            // 
            // create_header
            // 
            create_header.BackColor = Color.FromArgb(20, 20, 20);
            create_header.BorderStyle = BorderStyle.FixedSingle;
            create_header.ForeColor = Color.DarkGray;
            create_header.Location = new Point(11, 33);
            create_header.Name = "create_header";
            create_header.Size = new Size(201, 25);
            create_header.TabIndex = 1;
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
            // create_openFile
            // 
            create_openFile.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "pdf|*.pdf";
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
            tabPage2.PerformLayout();
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
        private Panel listField;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MonthCalendar Calendar;
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
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox searchField;
        private Label label1;
        private RadioButton sort_priority;
        private RadioButton sort_startDate;
        private RadioButton sort_deadline;
        private RadioButton sort_name;
        private RadioButton sort_default;
        private Label label4;
        private TextBox create_header;
        private Label label3;
        private Label label7;
        private Label label6;
        private DateTimePicker create_endDate;
        private Label label5;
        private DateTimePicker create_startDate;
        private TextBox create_text;
        private DomainUpDown prioritySelector;
        private Button create_addTask;
        private Label label8;
        private Label userFilePath;
        private Button addFile;
        private OpenFileDialog create_openFile;
        private SaveFileDialog saveFileDialog;
        private Button create_pdf;
    }
}