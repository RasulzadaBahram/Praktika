
#region 1ci sual

//2 ededin boyunu tapan alqoritm yaz Readline ile

//Console.WriteLine("A-ni daxil edin:");
//string a = Console.ReadLine();
//Console.WriteLine("B-ni daxil edin:");
//string b = Console.ReadLine();
//int A = Convert.ToInt32(a);
//int B = Convert.ToInt32(b);

//if (A > B)
//{
//    Console.WriteLine("Iki ededden en boyuku a-dir" + A);
//}
//else if (A == B) 
//{
//    Console.WriteLine("Ededler beraberdir");
//}
//else
//{
//    Console.WriteLine("Iki ededden en boyuku B-dir" + B);
//}
#endregion


#region 2ci sual
//2-e qaliqsiz bolunen ededleri ferqlendiren

//int A;
//Console.WriteLine("A-ni daxil edin:");
//A=Convert.ToInt32(Console.ReadLine());
//if (A % 2 == 0)
//{
//    Console.WriteLine(A+ " "+"2-e bolunur" );
//}
//else
//{
//    Console.WriteLine(A + " " + "2-e bolunur");
//}

#endregion


#region 3cu sual

//100 >= boyuk <= kicik neticesini versin

//Console.WriteLine("A-ni daxil edin:");
//string a = Console.ReadLine();
//int A = Convert.ToInt32(a);
//if (A >= 100)
//{
//    Console.WriteLine("Boyuk");
//}
//else if (A <= 0) 
//{
//    Console.WriteLine("kick");
//}

#endregion


#region 4ci sual

//18den boyuklere adult kiciklere child veren kod yaz

//Console.WriteLine("A-ni daxil edin:");
//string a = Console.ReadLine();
//int age = Convert.ToInt32(a);
//if (age >18)
//{
//    Console.WriteLine("Adult");
//}
//else if (age < 18)
//{
//    Console.WriteLine("child");
//}

#endregion


#region 5ci sual

//menfi ve musbet ededleri ferqlendiren alqoritm

//int A;
//Console.WriteLine("A-ni daxil edin: ");
//A=Convert.ToInt32(Console.ReadLine());
//if (A > 0)
//{
//    Console.WriteLine("A musbetdir");
//}
//else if (A == 0)
//{
//    Console.WriteLine("A sifirdir");
//}
//else 
//{
//    Console.WriteLine("A menfirdir");
//}

#endregion


#region 6ci sual

//1-7 hefte gunlerine gore ayir

//int A;
//Console.WriteLine("A ucun 1-7 eded secin: ");
//A = Convert.ToInt32(Console.ReadLine());
//switch (A)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thirsday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//}

#endregion


#region 7ci sual

//ededin kubunu tap

//double A;
//Console.WriteLine("A ucun reqem secin ");
//A = Convert.ToInt32(Console.ReadLine());
//A = Math.Pow(A, 3);
//Console.WriteLine(A);

#endregion


#region 8cu sual

//aylarin gunlerini cixardan alqoritm

//int A;
//Console.WriteLine("A ucun eded daxil ed");
//A=Convert.ToInt32(Console.ReadLine());
//switch (A)
//{
//    case 1 or 3 or 5 or 7 or 9 or 11:
//        Console.WriteLine("31 gunden ibaretdir");
//        break;

//    case 2:
//        Console.WriteLine("28 gunden ibaretdiur");
//        break;
//    case 4 or 6 or 8 or 10 or 12:
//        Console.WriteLine("30 gunden ibaretdiur");
//        break;
//}

#endregion


#region 9cu sual

//string[] fruits = { "Alma", "Banan", "Gilas", "Nar", "ciyelek", "uzum" };
//for (int i = 0; i < fruits.Length; i++)
//{

//    Console.WriteLine(fruits[i]);
//}
#endregion


#region 10,11ci suallar

//string[] students = { "x1", "x2", "x3", "x4", "x5", "x6","x7","x8" };
//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine(students[i]);
//}

#endregion


#region 12ci sual

//string[] students = { "x1", "x2", "x3", "x4", "x5", "x6", "x7", "x8" };
//Console.WriteLine(students[5]);


#endregion


#region 13cu sual

//string[] travels = { "baku", "shaki", "shamaxi", "sumqayit", "quba", "qusar" };
//for (int i = 0; i < travels.Length; i++)
//{
//    Console.WriteLine(travels[i]);
//}

#endregion


#region 14cu sual


//int[] x = {20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30};
//for (int i = 0; i < x.Length; i++)
//{
//    if (x[i] % 3 == 0)
//    {
//        Console.WriteLine(x[i]);
//    }
//}


#endregion


#region 15ci sual

//yuxarida arrayin min max ve ededi orta tap

//int[] x = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
//int max = x[0];
//int min = x[0];
//double cem = 0;
//double count = 0;
//for (int i = 0; i < x.Length; i++)
//{
//    if (max < x[i])
//    {
//        max = x[i];
//    }
//    if (min > x[i])
//    {
//        min = x[i];
//    }
//    if (true)
//    {
//        cem = cem + x[i];
//        count++;
//    }
//}
//Console.WriteLine("max: " + max);
//Console.WriteLine("min: " + min);
//Console.WriteLine("eded orta: " + cem / count);

#endregion


#region 16ci sual
//bool isPrime=false;

//int number=Convert.ToInt32(Console.ReadLine());

//for (int i = 2; i <= number-1; i++) 
//{
//    if (number % i == 0)
//    {
//        isPrime=true;
//        break;
//    }
//    else {
//        isPrime = false;
//    }
//}
//if (isPrime)
//{
//    Console.WriteLine("primedeyil");
//}
//else {
//    Console.WriteLine("prime");
//}











//if (a % a != 0 && a % 1 != 0)
//{
//    Console.WriteLine("Prime");
//}
//else 
//{

//    Console.WriteLine("Prime deyil");
//}

#endregion


#region 17ci sual

//int[] arr = [23, 60, 43, 12, 56, 100, 23, 43, 21, 36, 72];
//for (int i = 0; i < arr.Length; i++)
//{
//    //int div = Convert.ToInt32(arr[i]);
//    if (arr[i] % 6 == 0)
//    {
//        Console.WriteLine("6ya bolunur: " + arr[i]);
//    }
//    else
//    {
//        Console.WriteLine("6ya bolunmur: " + arr[i]);
//    }
//}




#endregion


#region 18ci sual

//while (true)
//{
//    Console.WriteLine("1. +");
//    Console.WriteLine("2. *");
//    Console.WriteLine("3. -");
//    Console.WriteLine("4. /");
//    Console.WriteLine("5. %");
//    Console.WriteLine("6. ^n");
//    Console.WriteLine("Emeliyyat:");
//    int do1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("A-ni daxil edin:");
//    int A = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("B-ni daxil edin:");
//    int B = Convert.ToInt32(Console.ReadLine());


//    switch (do1)
//    {
//        case 1:
//            Console.WriteLine("A+B= " + (A + B));
//            break;
//        case 2:
//            Console.WriteLine("A*B= " + (A * B));
//            break;
//        case 3:
//            Console.WriteLine("A-B= " + (A - B));
//            break;
//        case 4:
//            if (A == 0 && B == 0)
//            {
//                Console.WriteLine("yeniden daxil et");
//            }
//            else
//            {
//                Console.WriteLine("A/B= " + (A / B));
//            }
//            break;
//        case 5:
//            Console.WriteLine("A%B= " + (A % B));
//            break;
//        case 6:
//            if (B == 0)
//            {
//                Console.WriteLine("A^B= 1");
//            }
//            else
//            {
//                Console.WriteLine("A^B= " + Math.Pow(A, B));
//            }
//            break;
//    }

//}



#endregion


#region 19cu sual

//double[] price = [100.0, 1300.50, 259.99, 430.30, 160.99, 320.0];
//for (int i = 0; i < price.Length; i++)
//{
//    double b = price[i] * 0.8;
//    Console.WriteLine(b);
//}

#endregion


#region 20ci sual

//int[] age = [23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57];
//for (int i = 0; i < age.Length; i++)
//{
//    if (age[i] >= 65)
//    {
//        Console.WriteLine($"{age[i]} yasli sexs teqaude dusur");
//    }
//}


#endregion


#region 21-ci sual

//int d = 180;
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{d - a} left");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{d - (a+b)} left");
//int c = d-(a+b);

//if (a == b && a == c && b == c)
//{
//    Console.WriteLine("Beraber terefli");
//}
//else if (a == b || a == c || b == c)
//{
//    Console.WriteLine("Beraber yanli");
//}
//else if(a==90 || b==90 || c==90)
//{
//    Console.WriteLine("Duzbucaqli ucbucaq");
//}
//else
//{
//    Console.WriteLine("Ferqli terefli");
//}


#endregion


#region 22-ci sual

////Random rnm= new Random();    random generator yaratmaq ucun istifade olunur
//int i = 1;

////int i=rnm.Next(1, 101);     arada 1-100 arasi random eded verir

//while (i < 101)
//{
//    for (int j = 0; j < 5;)
//    {
//        int eded = Convert.ToInt32(Console.ReadLine());
//        j++;
//        if (eded == i)
//        {
//            Console.WriteLine("u won");
//        }
//    }
//    Console.WriteLine("u lost");
//    //Console.WriteLine("number was: " + i);
//}

#endregion


#region 23-cu sual

//Console.WriteLine("Kvadrat sahesi");
//double a = Convert.ToDouble(Console.ReadLine());
//double b = Convert.ToDouble(Console.ReadLine());
//double sahe = a * b;
//Console.WriteLine(sahe);

//Console.WriteLine("Duzbucaqli sahesi");
//double en = Convert.ToDouble(Console.ReadLine());
//double uzun = Convert.ToDouble(Console.ReadLine());
//double sahe1 = en*uzun;
//Console.WriteLine(sahe1);

//Console.WriteLine("ucbucaq sahesi");
//double h = Convert.ToDouble(Console.ReadLine());
//double esas = Convert.ToDouble(Console.ReadLine());
//double sahe2 = h*esas;
//Console.WriteLine(sahe2/2);

#endregion


#region 24-ci sual

//string a = Console.ReadLine();
//char[] b = a.ToCharArray();
//bool c = true;
//for (int i = 0; i < b.Length; i++)
//{
//    if (b[i] == b[(b.Length - i - 1)])
//    {
//       c=true;
//    }
//    else
//    {
//        c = false;
//    }
//}
//if (c)
//{
//    Console.WriteLine("palendron");
//}
//else {
//    Console.WriteLine("deyil");
//}

#endregion


#region 25ci sual
//Random rny = new Random();
//int kub=rny.Next(1, 101);
//Console.WriteLine(kub);
//Console.WriteLine(Math.Pow(kub,3));

#endregion


#region 29ci sual

//for (int i = 1; i <= 100; i++)
//{
//    int sonu_yeddi = i % 10;
//    int bolunen_yeddi = i % 7;
//    if (sonu_yeddi == 7 || bolunen_yeddi == 0)
//    {
//        Console.Write(" ciz  ");
//    }
//    else
//    {
//        Console.Write(i + " ");
//    }

//}

#endregion

#region 30cu sual

//int[] array = [10,12,22,10,32,22,16,32,22,20,22,32,10,10,23,23,15];
//int count = 0;
//for (int i = 0; i < array.Length; i++) 
//{
//    if (array[i] != 0) 
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);



#endregion


#region Method 1
//internal class Program
//{
//    public static void Main(string[] args)
//    {

//        MinusOrPlus(Convert.ToInt32(Console.ReadLine()));
//    }

//    public static int MinusOrPlus(int num) 
//    {
//        if (num > 0)
//        {
//            Console.WriteLine("Musbet");
//            return num;
//        }
//        Console.WriteLine("Menfi");
//        return 0;
//    }
//}

#endregion


#region Method 2

//internal class Program
//{
//    public static void Main(string[] args)
//    {
//        BiggerOne(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
//    }
//    public static int BiggerOne(int num,int num1) 
//    {
//        if (num > num1)
//        {
//            Console.WriteLine(num);
//            return 0;
//        }
//        else 
//        {
//            Console.WriteLine(num1);
//            return 0;
//        }
//    }
//}


#endregion

#region Method 3

//internal class Program
//{
//    public static void Main(string[] args)
//    {
//        DivideByTwo(Convert.ToInt32(Console.ReadLine()));
//    }
//    public static int DivideByTwo(int num)
//    {
//        if (num % 2 == 0)
//        {
//            Console.WriteLine(num + " " + "2-e bolunur");
//            return 0;
//        }
//        else
//        {
//            Console.WriteLine(num + " " + "2-e bolunmur");
//            return 0;
//        }
//    }
//}



#endregion

#region Method 4

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine( Cubed(Convert.ToInt32(Console.ReadLine())));

    }

    public static double Cubed(int num)
    {
        //double restult=Math.Pow(num,3);
        //Console.WriteLine(restult);
        //return 0;
        double restult = Math.Pow(num, 3);
        return restult;

    }
}

#endregion