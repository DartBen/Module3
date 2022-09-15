using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        string MyName = "Jane";
        byte MyAge = 27;
        bool HaveIApet = true;
        double MyShoeSize = 37.5;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("MyAge " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIApet);
        Console.WriteLine("My shoe size is " + MyShoeSize);

        //int age = 32;
        //Console.WriteLine($"Мой возраст {age}");
        //double result = 5 * 2 / 3;
        //WriteLine(result);

        //int i;
        //byte b;
        //string str;
        //float f;
        //double d;
        //short s;
        //long l;
        //ulong ul;


        //b = byte.MaxValue;

        //i = b;

        //b = (byte)i;

        //str = i.ToString();

        //s= short.MaxValue;
        //f = float.MaxValue;

        //d = (double) f;
        //ul=ulong.MaxValue;

        //b = (byte) ul;

        //l = (long)s;

        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine();
        //Console.Write("Enter your age: ");
        //byte age = (byte)int.Parse(Console.ReadLine());
        //Console.WriteLine("Your name is {0} and age is {1} ", name, age);



        Console.Write("Введите имя: ");
        var name = Console.ReadLine();
        var age = Convert.ToInt32(Console.ReadLine());
        var birthdate = Console.ReadLine();



        Console.ReadKey();
    }
}


//enum DaysOfWeek : byte
//{
//    Tuesday,            //0
//    Monday = 1,
//}

enum DaysOfWeek : byte
{
    Monday=1, 
    Tuesday,
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday,
    Sunday
}

enum Semaphore : int
{
    Red=100, Yellow=200, Green=300
}





