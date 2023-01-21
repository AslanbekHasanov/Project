int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
if(a == b && a == c && a != d)
{
    Console.WriteLine("Teng bulmagan sonning tartib raqami: " + 4); 
}
else if(a == b &&b == d && a != c)
{
    Console.WriteLine("Teng bulmagan sonning tartib raqami: " + 3);
}
else if (a == c && c == d && a != b)
{
    Console.WriteLine("Teng bulmagan sonning tartib raqami: " + 2);
}
else if(b == c && c == d && c != a)
{
    Console.WriteLine("Teng bulmagan sonning tartib raqami: " + 1);
}
else
{
    Console.WriteLine("teng bulmagan son yuq");
}
