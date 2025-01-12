// Task 1
//int a = int.Parse(Console.ReadLine());
//int rev = 0;
//int temp = a;
//while(temp > 0)
//{
//    rev = temp % 10 + rev * 10;
//    temp /= 10;
//}
//Console.WriteLine(rev);
//if (rev == a) Console.WriteLine("Eded oz tersine beraberdir");
//else Console.WriteLine("Eded tersine beraber deyil");

// Task 2
//int a = int.Parse(Console.ReadLine());
//int rev = 0;
//int temp = a;
//while(temp > 0)
//{
//    rev = temp % 10 + rev * 10;
//    temp /= 10;
//}
//Console.WriteLine(rev);
//if (rev == a) Console.WriteLine("Eded oz tersine beraberdir");
//else Console.WriteLine("Eded tersine beraber deyil");

// Task 3
//int a = int.Parse(Console.ReadLine());

//int gun = a / 86400; //1 gunde olan saniye sayi
//a -= gun * 86400;
//int saat= (a / 3600); //1 saatda olan saniye sayi
//a -= saat * 3600;
//int deq = a / 60; //1 deqiqede olan saniye sayi;
//a-= deq * 60;
//int san = a;
//Console.WriteLine(gun+ " gun, "+saat+" saat, "+deq+" deqiqe, "+san+" saniye");

// Task 4
//Console.Write("x1: ");
//int x1 = int.Parse(Console.ReadLine());
//Console.Write("y1: ");
//int y1 = int.Parse(Console.ReadLine());
//Console.Write("x2: ");
//int x2 = int.Parse(Console.ReadLine());
//Console.Write("y2: ");
//int y2 = int.Parse(Console.ReadLine());

//Console.WriteLine("2 noqte arasindaki mesafe: "+Math.Sqrt((x2-x1)* (x2 - x1)+ (y2-y1)* (y2 - y1)));

// Task 5
int a = int.Parse(Console.ReadLine());
int rev = 0;
int temp = a;
while (temp > 0)
{
    rev = temp % 10 + rev * 10;
    temp /= 10;
}
temp = rev;
Console.WriteLine(temp);
while (temp > 0)
{
    Console.Write(temp % 10);
    temp /= 10;
    if (temp > 0) Console.Write(temp % 10 + " ");
    temp /= 10;
}



// Task 6
//Console.Write("Doguldugunuz gun: ");
//int gun = int.Parse(Console.ReadLine());
//Console.Write("Doguldugunuz ay: ");
//int ay = int.Parse(Console.ReadLine());
//Console.Write("Doguldugunuz il: ");
//int il = int.Parse(Console.ReadLine());

//int gun1=11;
//int ay1 = 1;
//int il1 = 2025;

//if (ay1 > ay) Console.WriteLine("Yas: " + (il1 - il));
//else if(ay1 == ay) {
//    if(gun1>=gun) Console.WriteLine("Yas: " + (il1 - il));
//    else Console.WriteLine("Yas: " + (il1 - il-1));
//}
//else Console.WriteLine("Yas: " + (il1 - il-1));

//Task 7
//Console.WriteLine("Ededi hazirki vahidi ile daxil edin (Numune: 50 k): ");
//string a=Console.ReadLine();
//Console.WriteLine("Cevirmek istediyiniz vahidi daxil edin(d- dm, k-km, M-m, m-mm, s-sm):");
//char b = char.Parse(Console.ReadLine());

//double m = 0.1;
//double s = 1;
//double d = 10;
//double M = 100;
//double k = 100000;

////eyni setirde qebul etdikde vahid ve reqemi, daha sonra tek reqemi almaq ucun son herfi silib parse etdim. kesmek yolun internetden tapdim 
//int n = int.Parse(a.Remove(a.Length - 1));
//if (b == 'm')
//{
//	switch (a[a.Length-1])
//	{
//		case 's':
//			Console.WriteLine((s/m * n) + " millimetr");
//			break;
//        case 'd':
//            Console.WriteLine((d/m * n) + " millimetr");
//            break;
//        case 'M':
//            Console.WriteLine(( M/m * n) + " millimetr");
//            break;
//        case 'k':
//            Console.WriteLine(( k/m * n) + " millimetr");
//            break;
//        default:
//            Console.WriteLine(a);
//			break;
//	}
//}

//else if (b == 's')
//{
//    switch (a[a.Length - 1])
//    {
//        case 'm':
//            Console.WriteLine((m / s * n) + " santimetr");
//            break;
//        case 'd':
//            Console.WriteLine((d / s * n) + " santimetr");
//            break;
//        case 'M':
//            Console.WriteLine((M / s * n) + " santimetr");
//            break;
//        case 'k':
//            Console.WriteLine((k / s * n) + " santimetr");
//            break;
//        default:
//            Console.WriteLine(a);
//            break;
//    }
//}

//else if (b == 'd')
//{
//    switch (a[a.Length - 1])
//    {
//        case 'm':
//            Console.WriteLine((m / d * n) + " destimetr");
//            break;
//        case 's':
//            Console.WriteLine((s / d * n) + " destimetr");
//            break;
//        case 'M':
//            Console.WriteLine((M / d * n) + " destimetr");
//            break;
//        case 'k':
//            Console.WriteLine((k / d * n) + " destimetr");
//            break;
//        default:
//            Console.WriteLine(a);
//            break;
//    }
//}

//else if (b == 'M')
//{
//    switch (a[a.Length - 1])
//    {
//        case 'm':
//            Console.WriteLine((m / M * n) + " metr");
//            break;
//        case 's':
//            Console.WriteLine((s / M * n) + " metr");
//            break;
//        case 'd':
//            Console.WriteLine((d / M * n) + " metr");
//            break;
//        case 'k':
//            Console.WriteLine((k / M * n) + " metr");
//            break;
//        default:
//            Console.WriteLine(a);
//            break;
//    }
//}

//else if (b == 'k')
//{
//    switch (a[a.Length - 1])
//    {
//        case 'm':
//            Console.WriteLine((m / k * n) + " kilometr");
//            break;
//        case 's':
//            Console.WriteLine((s / k * n) + " kilometr");
//            break;
//        case 'M':
//            Console.WriteLine((M / k * n) + " kilometr");
//            break;
//        case 'd':
//            Console.WriteLine((d/k * n) + " kilometr");
//            break;
//        default:
//            Console.WriteLine(a);
//            break;
//    }
//}
//else Console.WriteLine("Yanlis parametr daxil edilib");


// Task 8
//int a = int.Parse(Console.ReadLine());
//int cnt = 0;
//for (int i = 1; i < a; i++)
//{
//    if (a / i == a % i) cnt++;
//}
//Console.WriteLine(cnt);

//Taks 9
//int dovsan = 4; //ayaq sayi
//int qaz = 2; //ayaq sayi
//for (int i = 0; i <= 64; i += dovsan)
//{
//    for (int j = 0; j <= 64; j += qaz)
//    {
//        if(i+j==64) Console.WriteLine((j/qaz) + " qaz, "+(i/dovsan)+" dovsan");
//    }
//} 