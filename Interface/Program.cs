using Interface.Interface;
using Interface.Models;

public class Program
{
    public static void Main(string[] args)
    {
        //Cat cat = new Cat
        //{
        //    name = "salma"
        //};
        //Dog dog = new Dog()
        //{
        //    name = "salma1451",
        //    sort="ggs"
        //};
        //cat.MakeSound();
        //dog.MakeSound();



        //Car car = new Car()
        //{
        //    name = "Taxi Free",
        //    id = 1,
        //    Brand="sa"
        //}
        //    ;
        //Bus bus = new Bus()
        //{
        //    name = "salam",
        //    id = 2,
        //    Brand = "sa"
        //};

        //car.Drive();
        //bus.Drive();


        //Duck duck = new Duck()
        //{
        //    name="salam"
        //};
        //duck.Fly();
        //duck.Swim();


        //Circles circle = new Circles()
        //{
        //    r=5
        //};

        //Rectangle rectangle = new Rectangle()
        //{
        //    a=5,h=2
        //};

        //List<IShape> shapes = new List<IShape>() { circle, rectangle };

        //foreach(var item in shapes)
        //{
        //    Console.WriteLine(item.GetArea());
        //}


        CashPayment cashPayment = new CashPayment();
        CardPayment cardPayment = new CardPayment();
        int cash = int.Parse(Console.ReadLine());

        cashPayment.Pay(cash);
        cardPayment.Pay(cash);



    }

}