// 1. String ustida amallar
System.Console.Write("Sonni kiriting: x=");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter str:");
string? str = Console.ReadLine();
int length = Convert.ToInt32(str.Length);
if(a>length)
{
    System.Console.WriteLine(str.ToUpper());
}
else
{
    System.Console.WriteLine(str.ToLower());
}

// 2. Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
int x = 15;
int y = 10;
if (x > y)
{
    System.Console.WriteLine("x is greater than y");
}
else if(x < y)
{
    System.Console.WriteLine("x is less than y");
}
else if(x == y)
{
    System.Console.WriteLine("x is ecual to y");
}
else
{
    System.Console.WriteLine("x and y are not comparable");
}

// 3. Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, 
//    natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!
System.Console.Write("Hafta kunlaridan birini kiriting:");
string? day = Console.ReadLine();
string resualt = day switch 
{
    "Monday" => "Dushanba",
    "Tuesday" => "Seshanba",
    "Wednesthay" => "Chorshanba",
    "Thursday" => "Payshanba",
    "Friday" => "Juma",
    "Saturday" => "Shanba",
    "Sunday" => "Yakshanba",
    _ => "Operation nor found!"
};
System.Console.WriteLine(resualt);