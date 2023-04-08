namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void PrintList(ref List<Business> list)
        {
            TableLayoutPanel tableList = new TableLayoutPanel()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                RowCount = 0,
                ColumnCount = 1,
                AutoSize = true,
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            for (int i = 0; i < list.Count; i++)
            {
                Label footer = new Label() { AutoSize = false, Dock = DockStyle.Bottom, Text = list[i].DatesToString() };
                Label text = new Label() { AutoSize = false, Dock = DockStyle.Fill, Text = list[i].comments };
                Label priority = new Label() { AutoSize = false, Dock = DockStyle.Right, Text = list[i].priority.ToString() };
                Panel panel = new Panel() { Dock = DockStyle.Fill, Padding = new Padding(10), BorderStyle = BorderStyle.FixedSingle };

                panel.Controls.Add(footer);
                panel.Controls.Add(text);
                panel.Controls.Add(priority);

                tableList.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                tableList.Controls.Add(panel, 0, i);
            }

            listField.Controls.Add(tableList);
        }

        private void sortBTN_Click(object sender, EventArgs e)
        {
            sort_Panel.Visible = !sort_Panel.Visible;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                DB.businessList.Add(new Business() 
                { dateTimeStart = DateTime.Now, dateTimeEnd = DateTime.Now, comments = $"Какая то задача № {i}", priority = Business.Priority.High, tag = $"Task {i}" });
            }
            PrintList(ref DB.businessList);
        }
    }
}