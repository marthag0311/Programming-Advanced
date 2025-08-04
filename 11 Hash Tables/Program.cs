namespace _11_Hash_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Book_KVP book = new Book_KVP(20);
            book.AddItem("apple", 0.67);
            book.AddItem("pear", 0.79);
            book.AddItem("eggs", 2.49);
            book.AddItem("milk", 1.49);
            book.AddItem("avocado", 1.49);
            Console.WriteLine(book.ToString());
            Console.WriteLine("Price of eggs: " + book.GetPrice("eggs"));
            Console.WriteLine(book.ToString());*/

            Book_Hash book = new Book_Hash(5);
            Console.WriteLine(book.GetSize());
            book.AddItem("apple", 0.67);
            book.AddItem("pear", 0.79);
            book.AddItem("eggs", 2.49);
            book.AddItem("milk", 1.49);
            book.AddItem("avocado", 1.49);
            book.AddItem("kiwi", 4.49);
            book.AddItem("chocolate", 7.49);
            book.AddItem("bread", 2.37);
            Console.WriteLine(book.ToString());
            Console.WriteLine("Price of eggs: " + book.GetPrice("eggs"));
            Console.WriteLine(book.ToString());
        }
    }
}