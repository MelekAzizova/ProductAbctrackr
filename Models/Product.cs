namespace ProductAbctrackr.Models;

internal abstract class Product
{
    static protected int Id = 1;
    public int ID { get; init; }
    public string name { get; set; }
    public int price {  get; set; }
    public int count {  get; set; }
    public int Sold;


    public string Name
    {
        get {  return name; }
        set
        {
            name = value;
        }
    }

    public int Price
    {
        get { return price; }
        set 
        { 
            price = value; 
        }
    }
    public int Count
    {
        get { return count; }
        set
        {
            count = value;
        }
    }




    public abstract int TotalInCome();
    public abstract int Sell();
    public abstract void ShowInfo();
}
