#region Task 1

//Console.WriteLine("Meyveni daxil edin: ");
//string meyve=Console.ReadLine();
//meyve.Split();
//Console.WriteLine("Kg-sini daxil edin: ");
//int kg=Convert.ToInt32(Console.ReadLine());
//string[] stok = ["nar", "banan","ciyelek"];
//for (int i = 0; i < stok.Length; i++) {
//    if (meyve == stok[i])
//    {
//        switch (meyve)
//        {
//            case "heyva":
//                Console.WriteLine("Qiymeti " + (kg * 2.3));
//                break;

//            case "alma":
//                Console.WriteLine("Qiymeti " + (kg * 2));
//                break;

//            case "nar":
//                Console.WriteLine("Qiymeti " + (kg * 4));
//                break;

//        }
//    }
//    else {
//        Console.WriteLine("yeniden daxil et");
//        break;
//    }
//}
//$"string {data}"

#endregion

//500 128

#region Task 2

//2^ quvvet

//Example 1

//Console.WriteLine("eded daxil et: ");
//double eded=Convert.ToDouble(Console.ReadLine());
//for (int i = 2; i <= eded;)
//{
//    eded /= 2;
//}

//if (eded == 1)
//{
//    Console.WriteLine("2^ lik ededdir");
//}
//else {
//    Console.WriteLine("2^ lik eded deyil");
//}


//Example 2

//int n = Convert.ToInt32(Console.ReadLine());
//while (n > 0) 
//{
//    if (n % 2 == 0 || n==1)
//    {
//        if (n == 1)
//        {
//            Console.WriteLine("2^ lik ededdir");
//        }
//        n /= 2;
//    }
//    else 
//    {
//        Console.WriteLine("2^ lik eded deyil");
//        break;
//    }

//}

#endregion



#region Task 3

//Terminal da balansla bagli testler

//Example 1

//Console.WriteLine("Balans: ");
//double num = Convert.ToDouble(Console.ReadLine());
//while (num >= 0)
//{
//    Console.WriteLine("\n1- Balans ");
//    Console.WriteLine("2-Daxil etmek");
//    Console.WriteLine("3-Xaric etmek");
//    Console.WriteLine("4-Cixis");
//    Console.WriteLine("Emeliyyat: ");

//    int emeliyyat = Convert.ToInt32(Console.ReadLine());
//    if (emeliyyat >= 5)
//    {
//        Console.WriteLine("Emeliyyati yeniden daxil edin");
//    }
//    switch (emeliyyat)
//    {
//        case 1:
//            Console.WriteLine("Balans: " + num + "\n");
//            break;

//        case 2:
//            Console.WriteLine("Elave olundu :");
//            double elave = Convert.ToDouble(Console.ReadLine());
//            if (elave <= 2000)
//            {
//                Console.WriteLine("Balans elave olundu: " + (num + elave) + "\n");
//            }
//            else 
//            {
//                Console.WriteLine("Limiti kecdiz");
//            }
//            break;

//        case 3:
//            Console.WriteLine("Xaric olundu: ");
//            int xaric = Convert.ToInt32(Console.ReadLine());
//            if (num > xaric)
//            {
//                Console.WriteLine("Balans xaric olundu: " + (num - xaric) + "\n");
//            }
//            else
//            {
//                Console.WriteLine("Balansda kifayet qeder mebleg yoxdur");
//                Console.WriteLine($"Balans {num} \n");
//            }
//            break;

//        case 4:
//            Console.WriteLine("Cixis edilir.. \n");
//            break;
//    }
//}


//Example 2

//Console.WriteLine("Please enter Name");
//string name=Console.ReadLine();
//Console.WriteLine("Enter Balance: ");
//decimal balance=Convert.ToDecimal(Console.ReadLine());

//while (true)
//{
//    Console.WriteLine();
//    Console.WriteLine();
//    Console.WriteLine();
//    Console.WriteLine();

//    int choosen = Convert.ToInt32(Console.ReadLine());

//    switch (choosen)
//    {
//        case 1:
//            Console.WriteLine($"Your balance amoung is {balance}");
//            break;

//        case 2:
//            Console.WriteLine("Please enter amount!");
//            decimal getBalance = Convert.ToDecimal(Console.ReadLine());
//            if (getBalance > balance)
//            {
//                Console.WriteLine($"Kifayet qeder megleb yoxdur!");
//            }

//            break;

//        case 3:
//            Console.WriteLine("Please enter deposit! ");
//            decimal addBalance = Convert.ToDecimal(Console.ReadLine());
//            if (addBalance > 2000)
//            {
//                Console.WriteLine($"Your max amout 2000!");
//            }
//            else
//            {
//                balance += addBalance;
//                Console.WriteLine();
//                break;
//            }
//            break;

//        case 4:
//            Console.WriteLine($"Good bye {name}");
//            break;
//        default:
//            Console.WriteLine("Please enter valic choosen");
//            break;
//    }
//    if (choosen == 4)
//    {
//        break;
//    }
//}



#endregion

