
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

