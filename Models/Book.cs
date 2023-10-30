namespace ProductAbctrackr.Models;

internal class Book : Product
{
   public string authorName;
   public int pageCount;

    public Book() 
    {
        ID = Product.Id;
        Id++;
    }

    public int PageCount
    {
        get { return pageCount; }
        set
        {
            pageCount = value;
        }
    }


    public override int Sell()
    {
        if(Count > 0) 
        {
            Console.WriteLine("Bir kitab satildi");
            Count--;
        }
        return Count;
        
    }
    public override int TotalInCome()
    {
        if (Count > 0)
        {
            Console.WriteLine("Qalan kitab sayi "+ " "+ Count);
            
        }
        return Count;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{ID}-> Kitabin adi: {Name}  \n Yazicinin adi: {authorName}    \n Qiymet: {Price}  \n  kitab sayi: {Count}  " );
    }

}
