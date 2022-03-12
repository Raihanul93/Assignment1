char[] a = new char[100];
char[] d = new char[100];
int[] b = new int[100];
int[] c = new int[100];
Console.WriteLine("Enter string digits up to 100  split by space");
int i, sum = 0;

string array1 = Console.ReadLine();

string[] list1 = array1.Split(" ");

int largesizeaerray;


Console.WriteLine("Enter string digits up to 100  split by space");
string array2 = Console.ReadLine();
string[] list2 = array2.Split(" ");

Console.WriteLine("First Line Integer");

for (i = 0; i < list1.Length; i++)
{
    a[i] = (Convert.ToChar(list1[i]));

    b[i] = (int)(Convert.ToChar(list1[i]));
    Console.WriteLine(b[i]);
}
Console.WriteLine("Second Line Integer");

for (i = 0; i < list2.Length; i++)
{
    d[i] = (Convert.ToChar(list2[i]));

    c[i] = (int)(Convert.ToChar(list2[i]));
    Console.WriteLine(c[i]);
}

if (list1.Length >= list2.Length)
{
    largesizeaerray = list1.Length;

}
else
{
    largesizeaerray = list2.Length;

}


string t = String.Format("--SUM----");
Console.WriteLine(t);

for (i = 0; i < largesizeaerray; i++)
{
    sum = sum + b[i] + c[i];

}

Console.WriteLine(sum);
