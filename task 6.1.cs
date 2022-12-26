class Program
{
    static void Main(string[] args)
    {
        Creator dev = new PanelDeveloper("ТОВ \"Будсервіс\"");
        House house2 = dev.Create();

        dev = new WoodDeveloper("Приватний забудовник");
        House house1 = dev.Create();

        Console.ReadLine();
    }
}
// абстрактний клас будівника
abstract class Creator
{
    public string Name { get; set; }

    public Creator(string n)
    {
        Name = n;
    }
    // фабричний метод
    abstract public House Create();
}
// будуємо панельний будинок
class PanelDeveloper : Creator
{
    public PanelDeveloper(string n) : base(n)
    { }

    public override House Create()
    {
        return new PanelHouse();
    }
}
// будинок дерев'яний будинок
class WoodDeveloper : Creator
{
    public WoodDeveloper(string n) : base(n)
    { }

    public override House Create()
    {
        return new WoodHouse();
    }
}

abstract class House
{ }

class PanelHouse : House
{
    public PanelHouse()
    {
        Console.WriteLine("Панельний будинок збудований");
    }
}
class WoodHouse : House
{
    public WoodHouse()
    {
        Console.WriteLine("Дерев'яний будинок збудований");
    }
}