using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Business
    {
        public enum Priority { Low, Medium, High };

        public DateTime dateTimeStart = DateTime.Now;
        public DateTime dateTimeEnd = DateTime.Now;
        public Priority priority;
        public string tag;
        public string comments;
        public object file;

        public string PriorityToString()
        {
            return priority == Priority.Low ? "Низкий" : priority == Priority.Low ? "Средний" : "Высокий";
        }
        public string DatesToString()
        {
            return $"Дата начала: {dateTimeStart.ToString("G")}     Дата окончания: {dateTimeEnd.ToString("G")}";
        }
    }
}
