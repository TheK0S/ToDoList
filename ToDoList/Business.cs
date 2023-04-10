using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Business
    {
        public DateTime dateTimeStart = DateTime.Now;
        public DateTime dateTimeEnd = DateTime.Now;
        public string priority;
        public string tag;
        public string comments;
        public object file;
        public CheckBox checkBox = new CheckBox() { Text = "", Dock = DockStyle.Left, AutoSize = true};


        //public string DatesToString()
        //{
        //    return $"Дата начала: {dateTimeStart.ToString("G")}     Дата окончания: {dateTimeEnd.ToString("G")}";
        //}
    }
}
