using iTextSharp.text;
using iTextSharp.text.pdf;
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
                
            }
        }

        public static bool SaveToPDF(string path_pdf, string text)
        {
            try
            {
                using (FileStream stream = new FileStream(path_pdf, FileMode.Create))
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, stream);
                    document.Open();

                    //BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Calibri.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    //iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                    document.Add(new Paragraph(text));
                    document.Close();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
