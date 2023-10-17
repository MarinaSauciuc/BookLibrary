using CsvHelper;
using CsvHelper.Configuration;
using Entities;
using System.Formats.Asn1;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;

namespace Repository
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            string[] lines = File.ReadAllLines("E:\\Visual Studio projects\\repos\\BookLibrary\\Repository\\Resources\\Database.csv");
            foreach (var line in lines)
            {
                string[] values = line.Split(',');
                if (values[0]=="title")
                {
                    continue;
                }

                Book book = new Book();
                book.title= values[0];
                book.author= values[1];
                book.genre= values[2];
                book.status = Convert.ToBoolean(values[3]);
                books.Add(book);
            }
            return books;
        }

        public void SaveBook(Book book)
        {

            var headerConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var stream = File.Open("E:\\Visual Studio projects\\repos\\BookLibrary\\Repository\\Resources\\Database.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, headerConfig))
            {
                csv.WriteRecord(book);
                csv.NextRecord();
            }
        }

      

    }
}