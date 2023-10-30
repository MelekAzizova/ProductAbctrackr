namespace ProductAbctrackr.Models;

internal class Library 
{
    Book[] books;

    public void AddBook(Book book)
    {
        Array.Resize(ref books, books.Length + 1);
        books[books.Length - 1] = book;
        Console.WriteLine("Book added!");

    }


    public Book GetBookById(int id)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].ID ==id)
            {
                return books[i];
            }
            
        }
        return null;

    }

}