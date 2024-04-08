namespace Homework2_3
{
    class Program

    {
        static void Main(string[] args)
        {

            string title = "Harry Potter and the Philosopher's Stone";
            string author = "Joanne Rowling";
            int year = 1997;
            double price = 450.50;


            string bookInfo = string.Format("book: {0}\nauthor: {1}\nyear: {2}\nprice: {3}", title, author, year, price);


            Console.WriteLine(bookInfo);
            Console.ReadKey();
        }
    }
}