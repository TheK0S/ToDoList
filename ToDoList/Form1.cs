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
        List<Task> dragDropTask = new List<Task>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.ReadFromJson();

            if (DB.taskList.Count > 0)
                PrintList(ref DB.taskList);
        }

        void PrintList(ref List<Task> list)
        {
            if (DB.taskList.Count > 0)
            {
                List<DateTime> boldDates = new List<DateTime>();
                foreach (var item in DB.taskList)
                {
                    boldDates.Add(item.DateTimeStart);
                }

                Calendar.AnnuallyBoldedDates = boldDates.Distinct().ToArray();
            }

            if (listField.Controls.Contains(tableList))
            {
                listField.Controls.Remove(tableList);
            }

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
                    Text = list[i].Header,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label footer = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Bottom,
                    Text = $" ������: {list[i].DateTimeStart.ToString("G")}               ���������: {list[i].DateTimeEnd.ToString("G")}",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label priority = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Text = list[i].Priority,
                    //Font = new Font(Font, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Label text = new Label()
                {
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Text = list[i].Comments,
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

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (dragDropTask.Count > 0)
            {
                foreach (var item in dragDropTask)
                {
                    DB.taskList.Add(item);
                }
            }

            PrintList(ref DB.taskList);

            dragDropLabel.Text = "�������� ������ ��� ����";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.WriteToJson();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "������� ��� ���������� ���� �� ������?",
                "�������������",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                );

            if (result == DialogResult.Yes)
            {
                List<Task> tasksForRemove = new List<Task>();

                foreach (var item in DB.taskList)
                    if (item.IsChecked())
                        tasksForRemove.Add(item);

                if (tasksForRemove.Count > 0)
                    foreach (var item in tasksForRemove)
                        DB.taskList.Remove(item);

                PrintList(ref DB.taskList);
            }
        }

        private void listField_Resize(object sender, EventArgs e)
        {
            if (tableList != null)
                tableList.Width = listField.Width - 20;
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            // ���������, �������� �� ������������ ������ ������ JSON
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
                // �������� ������ ������ � ���������, ��� �� �������� JSON-�����
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
                List<Task> tempList = JsonConvert.DeserializeObject<List<Task>>(item);

                if (tempList != null)
                {
                    foreach (var listItem in tempList)
                        dragDropTask.Add(listItem);
                }
            }

            if (dragDropTask.Count > 0)
                dragDropLabel.Text = "����� ������ \"��������\", ����� �������� ���� � ����� ������";
        }

        private void create_addTask_Click(object sender, EventArgs e)
        {
            Task task = new Task()
            {
                DateTimeStart = create_startDate != null ? create_startDate.Value : DateTime.Now,
                DateTimeEnd = create_endDate != null ? create_endDate.Value : DateTime.Now,
                Priority = prioritySelector.SelectedItem?.ToString() ?? "�������",
                Header = create_header.Text ?? "�����",
                Comments = create_text.Text ?? "������� ����� ������!"
            };

            DB.taskList.Add(task);

            PrintList(ref DB.taskList);
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            if (create_openFile.ShowDialog() == DialogResult.OK)
            {
                userFilePath.Text = create_openFile.FileName;
            }
        }

        private void create_pdf_Click(object sender, EventArgs e)
        {
            if (DB.taskList.Count > 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string text_pdf = "";
                    foreach (var item in DB.taskList)
                    {
                        text_pdf += $"\t{item.Header}\n" +
                            $"Start date: {item.DateTimeStart.ToString("G")}\n" +
                            $"Deadline: {item.DateTimeEnd.ToString("G")}\n" +
                            $"Priority: {item.Priority}\n" +
                            $"Text: {item.Comments}\n\n\n";
                    }

                    DB.SaveToPDF(saveFileDialog.FileName, text_pdf);
                }
            }
            else
            {
                MessageBox.Show("������ ��� ����", "���������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}