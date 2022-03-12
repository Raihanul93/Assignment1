int[] a = new int[9];
int[] b = new int[3];
int[] c = new int[3];
int[] t = new int[3];
int[] n = new int[3];
int[] p = new int[3];
int[] v = new int[9];

Console.WriteLine("Enter 3X3 Matrix Elements");

string arrayTemp1 = Convert.ToString(Console.ReadLine());

string[] temp1 = arrayTemp1.Split(' ');

for (int i = 0; i < temp1.Length; i++)
{
    a[i] = Convert.ToInt32(temp1[i]);

}

string arrayTemp2 = Convert.ToString(Console.ReadLine());

string[] temp2 = arrayTemp2.Split(' ');

for (int i = 0; i < temp2.Length; i++)
{
    b[i] = Convert.ToInt32(temp2[i]);

}
string arrayTemp3 = Convert.ToString(Console.ReadLine());

string[] temp3 = arrayTemp3.Split(' ');

for (int i = 0; i < temp3.Length; i++)
{
    c[i] = Convert.ToInt32(temp3[i]);

}



Console.WriteLine("Enter Rotation Number =");
string numbersLine = Console.ReadLine();
int rotation = Convert.ToInt32(numbersLine) % 4;

for (int m = 0; m < 3; m++)
{
    a[3 + m] = b[m];
    a[6 + m] = c[m];
}

int j, k, s1 = 0, s2 = 0;

int[,] matx = new int[3, 3];

for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {

        if (j == 0)
        { matx[j, k] = a[k]; }

        if (j == 1)
        { matx[j, k] = a[k + 3]; }

        if (j == 2)
        { matx[j, k] = a[k + 6]; }
    }

}
Console.WriteLine("----Your Input--");
for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {

        Console.Write(matx[j, k]);
        Console.Write(' ');
    }
    Console.WriteLine("");
}

for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {
        if (j == 0)
        {
            t[k] = c[k];

        }

        if (j == 1)
        { n[k] = b[k]; }

        if (j == 2)
        {
            p[k] = a[k];

        }

    }
    Console.WriteLine("");
}



if (rotation == 1)
{
    for (int h = 0, l = 0; h < 3; h++, l = l + 3)
    {

        v[l] = t[h];

        v[l + 1] = n[h];

        v[l + 2] = p[h];
    }

}


if (rotation == 2)
{

    for (int f = 0; f < 3;)
    {
        for (int h = 0, l = 2; h < 3; h++)
        {

            v[h] = t[l];



            v[l + f + h + 1] = n[l];


            v[l + f + h + 4] = p[l];

            l = l - 1;
            f = f + 1;

        }
    }

}

if (rotation == 3)
{

    for (int f = 0; f < 3;)
    {
        for (int h = 0, l = 2; h < 9; h = h + 3)
        {
            v[h] = p[l];
            v[l + f + h - 1] = n[l];
            v[l + f + h] = t[l];

            l = l - 1;
            f = f + 1;

        }
    }
}


int[,] rot1 = new int[3, 3];

for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {
        if (j == 0)
        { rot1[j, k] = v[k]; }

        if (j == 1)
        { rot1[j, k] = v[k + 3]; }

        if (j == 2)
        { rot1[j, k] = v[k + 6]; }
    }

}
Console.WriteLine("--Rotation result=-----");
for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {

        Console.Write(rot1[j, k]);
        Console.Write(' ');
    }
    Console.WriteLine("");
}
