using System;
//Принцип відкритості/закритості 
//(OCP)

interface IFigure
{
    //int Width {  get;  set; }
    //int Height { get;set; } 
    int GetArea();
}
class Rectangle : IFigure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : IFigure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        Width = Height;
        return Height * Width;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;
            Console.WriteLine(rect.GetArea());

            Square square = new Square();
            square.Width = 5;
            square.Height = 10;
            Console.WriteLine(square.GetArea());

            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
}