using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Task7_1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Serializer serializater = new Serializer();
            try
            {
                Catalog catalog = serializater.Deserialize(ResourceFile.PathToFile);
                PrintBooksToConsoleAfterDeserialize(catalog);

                serializater.Serialize(catalog, ResourceFile.PathToFile);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void PrintBooksToConsoleAfterDeserialize(Catalog catalog)
        {
           
            foreach (Book book in catalog.Books)
            {
                Console.WriteLine("BOOKS:-------------------");
                Console.WriteLine($"Isbn: {book.Id}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"Publisher: {book.Publisher}");
                Console.WriteLine($"Publish Date: {book.Publish_date}");
                Console.WriteLine($"Description: {book.Description}");
                Console.WriteLine($"Registration Date: {book.Registration_date}");

            }
        }
    }
}
