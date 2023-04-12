using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class DB
    {
        public static Form1 form1 = new Form1();
        public static List<Task> taskList = new List<Task>();
        public static string json = "TaskListDB.json";
        public static void ReadFromJson()
        {
            try
            {
                taskList = JsonConvert.DeserializeObject<List<Task>>(File.ReadAllText(json)) ?? new List<Task>();
            }
            catch (Exception)
            {

            }
        }

        public static void WriteToJson()
        {
            try
            {
                File.WriteAllText(json, JsonConvert.SerializeObject(taskList));
            }
            catch (Exception)
            {
                //, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }
            }
        }
    }
}
