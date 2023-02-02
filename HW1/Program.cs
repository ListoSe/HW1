//int a = 0;
//Console.WriteLine("write num from 1 to 100");
//a = Convert.ToInt32(Console.ReadLine());
//if(a >= 1 && a <= 100)
//{ 
//if (a % 3 == 0 && a % 5 == 0)
//    Console.WriteLine("fizz buzz");
//else if (a % 3 == 0)
//    Console.WriteLine("fizz");
//else if (a % 5 == 0)
//    Console.WriteLine("buzz");
//else
//    Console.WriteLine(a);
//}

//Task 2
//int a = 0, b = 0 ;
//Console.WriteLine("write num: ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("write proc: ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(a / 100 * b);

//Task 3
//int[] a = new int[4];
//for(int i = 0;i < 4; i++)
//{
//    Console.WriteLine($"{i+1}write num: ");
//    a[i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = 0; i < 4; i++)
//{
//    Console.Write(a[i]);
//}

//Task 4
//int a = 0, b = 0, c = 0, tmp = 0;
//int[] arr = new int[6];
//a = Convert.ToInt32(Console.ReadLine());
//if (a <= 999999 && a >= 100000) {
//Console.WriteLine("from: ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("to: ");
//c = Convert.ToInt32(Console.ReadLine());
//arr[0] = a / 100000;
//arr[1] = a / 10000 - arr[0] * 10;
//arr[2] = a / 1000 - (a / 10000 * 10);
//arr[3] = a / 100 - (a / 1000 * 10);
//arr[4] = a / 10 - (a / 100 * 10);
//arr[5] = a - (a / 10 * 10);

//tmp = arr[b - 1];
//arr[b - 1] = arr[c - 1];
//arr[c - 1] = tmp;
//for (int i = 0; i < 6; i++){
//    Console.Write(arr[i]);
//}
//}
//else Console.WriteLine("a normalnoe chislo?");


//Task 5
//string a = " ";
//a = Console.ReadLine();
//string[] part = a.Split('.');

//int day = Convert.ToInt32(part[0]);
//int month = Convert.ToInt32(part[1]);

//if (month <= 2 || month == 12)
//    Console.WriteLine("Winter");
//else if(month > 2 && month < 6)
//    Console.WriteLine("Spring");
//else if(month > 5 && month < 9)
//    Console.WriteLine("Summer");
//else if(month > 8 && month < 12)
//    Console.WriteLine("Autumn");

//day = day % 7;

//switch(day)
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
//        Console.WriteLine("Thursday");
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


//Task 6
//int a = 0;
//bool b = false;
//Console.WriteLine("ins num: ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("select from Fahrenheit to Celsius(false) || or from Celsius to Fahrenheit(true)");
//b = Convert.ToBoolean(Console.ReadLine());
//if (b == false){
//    a = (a - 32) * 5 / 9;
//    Console.WriteLine($"T Cel: {a}");
//}
//else if (b == true)
//{
//    a = a * 9 / 5 + 32;
//    Console.WriteLine($"T far: {a}");
//}

//Task 7
//int a = 0, b = 0;
//Console.WriteLine("ins 2num: ");
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("res: ");
//if (a > b){
//    for(int i = b; i <= a; i++){
//        if(i % 2 == 0) Console.WriteLine(i);
//    }
//}
//else{
//    for (int i = a; i <= b; i++){
//        if (i % 2 == 0) Console.WriteLine(i);
//    }
//}
