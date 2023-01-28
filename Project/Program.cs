//20 -misol
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
////int d = int.Parse(Console.ReadLine());
//if (Math.Abs(a - b) > Math.Abs(a - c))
//{
//    Console.WriteLine("YAQIN NUQTA: " + b + "\nmasofasi: " + Math.Abs(a - c));
//}
//else if (Math.Abs(a - b) < Math.Abs(a - c))
//{
//    Console.WriteLine("YAQIN NUQTA: " + b + "\nmasofasi: " + Math.Abs(a - b));
//}

//else if (Math.Abs(a - b) == Math.Abs(a - c))
//{
//    Console.WriteLine("yaqin nuqta: " + b + " " + c);
//}
//else if (a == b && b == c) 
//{
//    Console.WriteLine("nuqtalar ustma ust tushadi");
//}
//if 28 -misol
//salom:
//int year = int.Parse(Console.ReadLine());
//if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
//{
//    Console.WriteLine("Kabisa yili, bu yilda 366 kun bor");
//}
//else
//{
//    Console.WriteLine("Kabisa yili emas, bu yilda 365 kun bor");
//}
//goto salom;
// case 1- misol
//salom:
//Console.Write("Hafta kunini kiriting: ");
//int day = int.Parse(Console.ReadLine());
//switch (day % 7)
//{
//	case 0: 
//		Console.WriteLine("Dushanba"); break;
//    case 1:
//        Console.WriteLine("Seshanba"); break;
//    case 2:
//        Console.WriteLine("Chorshanba"); break;
//    case 3:
//        Console.WriteLine("Payshanba"); break;
//    case 4:
//        Console.WriteLine("Juma"); break;
//    case 5:
//        Console.WriteLine("Shanba"); break;
//    case 6:
//        Console.WriteLine("Yakshanba"); break;
//    default:
//        Console.WriteLine("bunaqa hafta kuni mavjud emas"); break;

//}
//goto salom;
// 9 - misol
//Console.WriteLine("day = "); int day = int.Parse(Console.ReadLine());
//Console.WriteLine("month = "); int month = int.Parse(Console.ReadLine());
//string nameOfMonth;
//switch (month)
//{
//	case 1:
//	case 2:
//	case 3:
//	case 5:
//	case 7:
//	case 8:


//	default:
//		break;
//}
// IF 24 - misol


// if 27
//int x = int.Parse(Console.ReadLine());
//if(x < 0)
//{
//    Console.WriteLine(0);
//}
//else if((x >= 0 && x < 1) || (x >= 2 && x < 3))
//{
//    Console.WriteLine(1);
//}
//else if((x >= 1 && x < 2) || (x >= 3 && x < 4))
//{
//    Console.WriteLine(-1);
//}





//double month = double.Parse(Console.ReadLine());
//string seasonName;
//switch (month)
//{
//	case 12:
//	case 1:
//	case 2: seasonName = "Winter"; break;
//	case 3:
//	case 4:
//	case 5: seasonName = "Spring"; break;
//	case 6:
//	case 7:
//	case 8: seasonName = "Summer"; break;
//	case 9:
//	case 10:
//	case 11: seasonName = "Autumn"; break;
//    default:
//		seasonName = "\aThis is month not found";
//		break;
//}
//if (month < 12)
//{
//    Console.WriteLine("This is {0} month, belongs to the {1} season ", month, seasonName);
//}
//else
//{
//    Console.WriteLine(seasonName);
//}



////if 30 - misol
//float a = float.Parse(Console.ReadLine());
//if ((a > 9 && a < 100) && (a % 2 == 0))
//{
//    Console.WriteLine("ikki xonali juft son");
//}
//else if ((a > 99 && a < 1000) && (a % 2 == 1))
//{
//    Console.WriteLine("uch xonali toq son");
//}
//else
//{
//    Console.WriteLine("bu oraliqdagi son emas");
//}
//salom