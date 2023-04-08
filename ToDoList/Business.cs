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

        DateTime dateTime = DateTime.Now;
        Priority priority;
        string tag;
        string comments;
        object file;

        public Business(string comments, string tag, DateTime dateTime, Priority priority = Priority.Medium)
        {
            this.dateTime = dateTime;
            this.priority = priority;
            this.tag = tag;
            this.comments = comments;
        }
    }
}
