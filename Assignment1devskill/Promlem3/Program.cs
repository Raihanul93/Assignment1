int[][,] jaggedArray4 = new int[][,]
{
    new int[,] { { 1, 3 }, { 5, 7 } },
                new int[,] { { 0, 2 }, { 4, 6 }, { 8, 10 } },
                new int[,] { { 11, 22 }, { 99, 88 }, { 0, 9 } }
            };

int[] c = new int[30];
int d;


for (int i = 0; i < 3; i++)
{

    for (int j = 0; j < 3; j++)

    {


        for (int k = 0; k < 2; k++)
        {

            if (i == 0 && j == 2)
            {

            }
            else
            {
                d = jaggedArray4[i][j, k];
                Console.WriteLine(d);

            }


        }

    }

}
