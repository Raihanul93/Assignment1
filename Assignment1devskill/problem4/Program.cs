int[] a = new int[10];
int[] b = new int[10];
int[] c = new int[10];
int[] d = new int[10];
int[] cdsize = new int[2];
int[] e = new int[2];

int[] revc = new int[10];
int[] revd = new int[10];


int clen, g, h;
int dlen;

Console.WriteLine("Enter  digits up to 9 with split by space");

string arrayTemp1 = Convert.ToString(Console.ReadLine());

string[] temp1 = arrayTemp1.Split(' ');

for (int i = 0; i < temp1.Length; i++)
{
    a[i] = Convert.ToInt32(temp1[i]);


}

string t = String.Format("a. Reverse the order of the number =");
Console.WriteLine(t);

for (int j = (temp1.Length) - 1, k = 1; j >= 0; j--, k++)
{
    b[k] = a[j];
    Console.WriteLine(b[k]);

}


int n = 1, p = 1;

for (int m = 1; m <= temp1.Length; m++)
{
    if (m % 2 == 0)
    {
        c[n] = b[m];
        n++;

    }
    else
    {

        d[p] = b[m];
        p++;

    }


}


Console.WriteLine("c-Even array-");

for (int m = 1; m < c.Length; m++)
{

    if (c[m] == 0)
    {

        cdsize[0] = m - 1;
        break;


    }
    Console.WriteLine(c[m]);

}
Console.Write("c-Even size-");
Console.WriteLine(cdsize[0]);


Console.WriteLine("D-odd array-");

for (int m = 1; m < c.Length; m++)
{

    if (d[m] == 0)
    {


        cdsize[1] = m - 1;
        break;


    }
    Console.WriteLine(d[m]);

}
Console.Write("D-Odd  size-");

Console.WriteLine(cdsize[1]);




for (int m = 1; m < c.Length; m++)
{
    if (c[m] == 0)
    {
        cdsize[1] = m - 1;
        break;
    }


}






Console.WriteLine("----------c--------------");





for (int j = cdsize[0], k = 1; j > 0; j--, k++)
{
    revc[k] = c[j];

    Console.Write(revc[k]);
    if (j != 1)
    {
        Console.Write(",");
    }

}
Console.WriteLine(" ");

Console.WriteLine("----------d--------------");
Console.Write("");
for (int j = cdsize[1]+1, k = 1; j > 0; j--, k++)
{
    revd[k] = d[j];
    Console.Write(revd[k]);
    if (j != 1)
    {
        Console.Write(",");
    }

}
