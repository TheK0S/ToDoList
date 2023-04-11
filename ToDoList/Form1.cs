using Newtonsoft.Json;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        TableLayoutPanel? tableList;

        List<string> jsons = new List<string>();
        List<Business> dragDropBusineses = new List<Business>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void PrintList(ref List<Business> list)
        {
            tableList = new TableLayoutPanel()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                RowCount = 0,
                ColumnCount = 0,
                AutoSize = true,
                Width = listField.Width - 20
            };

            tableList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            tableList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));


            for (int i = 0; i < list.Count; i++)
            {
                Label header = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    Text = list[i].header,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label footer = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Bottom,
                    Text = $" Начало: {list[i].dateTimeStart.ToString("G")}               Окончание: {list[i].dateTimeEnd.ToString("G")}",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label priority = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Text = list[i].priority,
                    //Font = new Font(Font, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Label text = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Text = list[i].comments,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Panel panel = new Panel()
                {
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(15, 15, 15)
                };

                panel.Controls.Add(text);
                panel.Controls.Add(header);
                panel.Controls.Add(footer);


                tableList.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                tableList.Controls.Add(list[i].checkBox, 0, i);
                tableList.Controls.Add(panel, 1, i);
                tableList.Controls.Add(priority, 2, i);
            }

            listField.Controls.Add(tableList);
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
                { dateTimeStart = DateTime.Now, dateTimeEnd = DateTime.Now, comments = $"Какая то задача № {i} hgfjhgkjjfdhgkjhdsfkdhjgkhajlkhjgakljhkahlakhjskjhsakdjhfkhfskdhfakhsjfdlkahsfdlkhf", priority = "Hight", header = $"Task {i}" });
            }
            PrintList(ref DB.businessList);

            dragDropLabel.Text = "Перетащи список дел сюда";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void removeBTN_Click(object sender, EventArgs e)
        {

        }

        private void listField_Resize(object sender, EventArgs e)
        {
            if (tableList != null)
                tableList.Width = listField.Width - 20;
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            // Проверить, является ли передаваемый объект файлом JSON
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file).ToLowerInvariant() == ".json")
                        {
                            e.Effect = DragDropEffects.Copy;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void label1_DragLeave(object sender, EventArgs e)
        {
            dragDropLabel.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                // Получить список файлов и проверить, что он содержит JSON-файлы
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLowerInvariant() == ".json")
                    {
                        jsons.Add(File.ReadAllText(file));
                    }
                }
            }
            catch (Exception)
            {

            }

            foreach (var item in jsons)
            {
                Business business = JsonConvert.DeserializeObject<Business>(item);

                if (business != null)
                    dragDropBusineses.Add(business);
            }

            if (dragDropBusineses.Count > 0)
                dragDropLabel.Text = "Нажми кнопку \"Добавить\", чтобы добавить дела в общий список";
        }
    }
}