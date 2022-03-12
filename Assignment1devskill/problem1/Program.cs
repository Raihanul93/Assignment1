int b, c, d;

string numbersLine = Console.ReadLine();

string[] numbers = numbersLine.Split(new char[] { ' ' });
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
b = Convert.ToInt32(numbers[0]);
c = Convert.ToInt32(numbers[1]);

if (1 <= c & c <= 30)
{
    d = (b << c) | (b >> (32 - c));
    Console.WriteLine(Convert.ToString(b, toBase: 2));




    Console.WriteLine(Convert.ToString(d, toBase: 2));
    int e = Convert.ToInt32(d);

    Console.WriteLine(e);
}


else
{
    Console.WriteLine("Error");
}
