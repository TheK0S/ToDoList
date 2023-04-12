using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Task
    {
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public string? Priority { get; set; }
        public string? Header { get; set; }
        public string? Comments { get; set; }
        public string? File { get; set; }

        [JsonIgnore]
        [field: NonSerialized]
        public CheckBox checkBox = new CheckBox() { Text = "", Dock = DockStyle.Left, AutoSize = true};

        public bool IsChecked()
        {
            return checkBox.Checked;
        }
    }
}
