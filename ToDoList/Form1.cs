using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private string draggedItem;

        private const string FilePath = "ToDoList.txt"; // файл для сохранения списка дел

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void PrintList(ref List<Business> list)
        {
            //TableLayoutPanel tableList = new TableLayoutPanel()
            //{
            //    CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
            //    RowCount = 0,
            //    ColumnCount = 3,
            //    AutoSize = true,
            //    Dock = DockStyle.Fill,
            //    BackColor = Color.Transparent                
            //};
            //tableList.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));






            //tableList.RowCount = 0;
            //tableList.ColumnCount = 0;

            //tableList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            //tableList.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            //tableList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));


            //for (int i = 0; i < list.Count; i++)
            //{
            //    Label header = new Label() { Dock = DockStyle.Top, Text = list[i].tag, Padding = new Padding(3) };
            //    Label footer = new Label() { Dock = DockStyle.Bottom, Text = list[i].dateTimeStart.ToString("G"), Padding = new Padding(3) };
            //    Label priority = new Label() { Dock = DockStyle.Fill, Text = list[i].priority, Padding = new Padding(3) };
            //    Label text = new Label() { Dock = DockStyle.Fill, Text = list[i].comments, Padding = new Padding(10), BorderStyle = BorderStyle.FixedSingle };
            //    Panel panel = new Panel() { AutoSize = true, Dock = DockStyle.Fill, Padding = new Padding(10), BorderStyle = BorderStyle.FixedSingle };

            //    panel.Controls.Add(text);
            //    panel.Controls.Add(header);
            //    panel.Controls.Add(footer);


            //    tableList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //    tableList.Controls.Add(list[i].checkBox, 0, i);
            //    tableList.Controls.Add(panel, 1, i);
            //    tableList.Controls.Add(priority, 2, i);
            //}

            //listField.Controls.Add(tableList);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Label footer = new Label() { AutoSize = false, Dock = DockStyle.Bottom, Text = list[i].dateTimeStart.ToString("G") };
            //    Label text = new Label() { AutoSize = false, Dock = DockStyle.Fill, Text = list[i].comments };
            //    Label priority = new Label() { AutoSize = false, Dock = DockStyle.Right, Text = list[i].priority };
            //    Panel panel = new Panel() { AutoSize = true, Dock = DockStyle.Fill, Padding = new Padding(10), BorderStyle = BorderStyle.FixedSingle };

            //    panel.Controls.Add(list[i].checkBox);
            //    panel.Controls.Add(footer);
            //    panel.Controls.Add(text);
            //    panel.Controls.Add(priority);

            //    //listView1.Items.Add(new ListViewItem(new string[]
            //    //{ list[i].dateTimeStart.ToString(),
            //    //  list[i].dateTimeEnd.ToString(),
            //    //  list[i].tag, list[i].comments

            //    //}));
            //}
            LayoutPanel.Width = listField.Width;

            for (int i = 0; i < list.Count; i++)
            {
                Label startDate = new Label() { AutoSize = true, Text = $"Дата начала: {list[i].dateTimeStart.ToString("G")}" };
                Label endDate = new Label() { AutoSize = true, Text = $"    Дата окончания: {list[i].dateTimeStart.ToString("G")}" };
                Label text = new Label() { AutoSize = true, Text = list[i].comments };                
                Label teg = new Label() { AutoSize = false, Width = LayoutPanel.Width - list[i].checkBox.Width - 100, Text = list[i].tag };
                Label priority = new Label() { AutoSize = false, Width = LayoutPanel.Width - teg.Width - 100, Text = list[i].priority };

                FlowLayoutPanel panel = new FlowLayoutPanel() 
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    Width = LayoutPanel.Width - 20,
                    Padding = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    Anchor = AnchorStyles.None,
                };

                panel.Controls.Add(list[i].checkBox);
                panel.Controls.Add(teg);
                panel.Controls.Add(priority);
                panel.Controls.Add(startDate);
                panel.Controls.Add(endDate);
                panel.Controls.Add(text);
                

                LayoutPanel.Controls.Add(panel);

            }





        }

        private void sortBTN_Click(object sender, EventArgs e)
        {
            sort_Panel.Visible = !sort_Panel.Visible;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                DB.businessList.Add(new Business()
                { dateTimeStart = DateTime.Now, dateTimeEnd = DateTime.Now, comments = $"Какая то задача № {i} hgfjhgkjjfdhgkjhdsfkdhjgkhajlkhjgakljhkahlakhjskjhsakdjhfkhfskdhfakhsjfdlkahsfdlkhf", priority = "Hight", tag = $"Task {i}" });
            }
            PrintList(ref DB.businessList);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void removeBTN_Click(object sender, EventArgs e)
        {

        }
    }
}