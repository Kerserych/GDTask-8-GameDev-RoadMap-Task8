int[] massive = new int[] { 1, 2, 0, 3, 0, 4, 0, 5, 0, 6 };
massive = GoAway(massive);
Console.WriteLine(String.Join(" ", massive));

int[] GoAway(int[] mas)
{
    for (int i = 1; i < mas.Length; i++)
    {
        for (int j = 0; j < mas.Length - i; j++)
        {
            if (mas[j] == 0)
            {
                swamp(ref mas[j], ref mas[j + 1]);
            }
        }
    }
    return mas;
}

void swamp(ref int x1, ref int x2)
{
    int temp = x1;
    x1 = x2;
    x2 = temp;
}