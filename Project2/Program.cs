using System.Text;
using System.Threading.Channels;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //string title = "clean code";
            //string uppertitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(uppertitle);

            #endregion
            #region Q2 
            //string str1 = "clean code";
            //string str2 = "clean code";
            //bool result = ReferenceEquals(str1, str2);
            //Console.WriteLine(result);
            #endregion
            #region Q3
            //StringBuilder sb = new StringBuilder();

            //sb.AppendLine("Book List");
            //sb.AppendLine("Updated");

            //Console.WriteLine(sb);
            #endregion
            #region Q4
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Book List");
            //sb.AppendLine("uppdate");
            //sb.Replace("Book List", "Libarary");
            //Console.WriteLine(sb);

            #endregion
            #region Q5
            //string title = "Clean Code";
            //int pages = 464;

            //string result = "Book: " + title + "\nPages: " + pages;

            //Console.WriteLine(result);
            #endregion
            #region Q6
            //string title = "clean code";
            //int pages = 464;
            //string result = $"Book:{title}\npages :{pages}";
            //Console.WriteLine(result);
            #endregion
            #region Q7
            //string title = "Clean Code";
            //int pages = 464;

            //string result = string.Format("Book: {0}\nPages: {1}", title, pages);

            //Console.WriteLine(result);
            #endregion
            #region Q8
            //int pages= 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else {
            //    Console.WriteLine("Short Book");
            //}

            #endregion
            #region Q9
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable == true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion
            #region Q10
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "clean code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;


            //}

            #endregion
            #region  Q11
            //int pages = 464;
            //string sizelabel = pages > 300 ? "long Book " : "Short Book";
            //Console.WriteLine(sizelabel);
            #endregion
            #region Q12 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i =0; i < books.Length; i++)
            //{
            //    Console.WriteLine( books[i]);
            //}

            #endregion
            #region Q13
            //string[] books = { "clean code", "the Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}

            #endregion
            #region Q14
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);

            #endregion
            #region Q15
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion
            #region Q16
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //    {
            //        break;
            //    }

            //    Console.WriteLine(book);
            //}
            #endregion
            #region Q17
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            #endregion




            }
        }

    }
}
