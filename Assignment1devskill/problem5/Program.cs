int[] a = new int[9];
int[] b = new int[3];
int[] c = new int[3];


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


for (j = 0; j < 3; j++)
{
    for (k = 0; k < 3; k++)
    {
        if (j == k)
        {
            s1 = s1 + matx[j, k];
        }


    }

}

String s = String.Format("1st diagonal value = {0}", s1);

Console.WriteLine(s);





for (j = 0; j < 3; j++)
{
    for (k = 2; k >= 0; k--)
    {
        if (j + k == 2)

        {
            s2 = s2 + matx[j, k];

        }

    }

}

String p = String.Format("2st diagonal value = {0} ", s2);
Console.WriteLine(p);
