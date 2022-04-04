static bool Repe(int num, int[] vect)
{
    for (int i = 0; i < 8; i++)
    {
        if (num == vect[i])
        {
            return true;
        }
    }
    return false;
}


Random Random = new Random();
int num = 1;
int[] sal = new int[8];

for (int i = 0; i <= 9; i++)
{
    if(i < 8)
    {
        while (Repe(num, sal) == true)
        {
            num = Random.Next(1,9);
        }

        sal[i] = num;
        Console.WriteLine(sal[i]);
    }
   
}