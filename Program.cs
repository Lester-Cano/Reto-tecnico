using System;
using Newtonsoft.Json;
using System.IO;


namespace Reto_tecnico
{
    class Program
    {





        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            string path = @"C:\Users\Personal\source\repos\Reto tecnico\Categories.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                Category[] categories = JsonConvert.DeserializeObject<Category[]>(json);
                foreach(Category category in categories)
                {
                    Console.WriteLine(category.id);
                    Console.WriteLine(category.Name);
                }
            }

            string path2 = @"C:\Users\Personal\source\repos\Reto tecnico\Questions.json";
            using (StreamReader jsonStream = File.OpenText(path2))
            {
                var json = jsonStream.ReadToEnd();
                Question[] categories = JsonConvert.DeserializeObject<Question[]>(json);
                foreach (Question category in categories)
                {
                    Console.WriteLine(category.Category);
                    Console.WriteLine(category.QuestionM);
                    foreach(string answer in category.Answers)
                    {
                        Console.WriteLine(answer);
                    }
                    
                    Console.WriteLine(category.Correct_Answer);
                }



            }

        }



    }
}
