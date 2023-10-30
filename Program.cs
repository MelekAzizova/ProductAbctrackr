using ProductAbctrackr.Models;

namespace ProductAbctrackr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {

            price = 10,
            name = "Birinci Addim",
            authorName = "Qaraqan",
            Count = 10
            };



           book. ShowInfo();
           book. Sell();
           book. TotalInCome();
           

        }
    }
}