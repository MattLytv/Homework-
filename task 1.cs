
using System.Security.AccessControl;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IDiscount
{
    void ApplyDiscount(string discount);
}

interface IPromocode
{
    void ApplyPromocode(string promocode);
}

interface ISizeAndColor
{
    void SetColor(string color);
    void SetSize(string size);
}

interface IPrice
{
    void SetPrice(double price);
}

class Book : IDiscount, IPrice
{
    public Book(string name)
    {
        this.name = name;
    }
    private string name { get; set; }
    private double price { get; set; }
    private string discount { get; set; }
    public void ApplyDiscount(string discount)
    {
        this.discount = discount;
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void ShowInfo()
    {
        Console.WriteLine("\nName - " + name + "\nDiscount - " + discount + "\nPrice - " + price);
    }
}

class OutWear : IDiscount, ISizeAndColor, IPrice
{
    private string name { get; set; }
    private double price { get; set; }
    private string discount { get; set; }
    private string size { get; set; }
    private string color { get; set; }
    public OutWear(string name)
    {
        this.name = name;
    }
    public void ApplyDiscount(string discount)
    {
        this.discount = discount;
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public void SetSize(string size)
    {
        this.size = size;
    }
    public void ShowInfo()
    {
        Console.WriteLine("\nName - " + name + "\nDiscount - " + discount + "\nPrice - " + price + "\nSize - " + size + "\nColor - " + color);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("book1");
        book1.ApplyDiscount("20%");
        book1.SetPrice(120);
        book1.ShowInfo();

        OutWear outwear1 = new OutWear("outwear1");
        outwear1.ApplyDiscount("0%");
        outwear1.SetPrice(3400);
        outwear1.SetSize("M");
        outwear1.SetColor("red");
        outwear1.ShowInfo();

        Console.ReadKey();
    }
}