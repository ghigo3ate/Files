using System;
using System.IO;
 
namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"C:\Desktop\хлам\ht.txt";
 
            string text = "Начало\nКонец...";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
 
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Конец конца");
                    sw.WriteLine("Xd 😀");			
                    
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}