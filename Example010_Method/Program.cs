int [] array = {13,24,36,88,59,62,75,88};
int n =array.Length;
int find = 88;
int index = 0;
while (index<n)
{
    if (array [index] == find)
    {
        Console.WriteLine (index);
        break;
    }
    index++;
}
