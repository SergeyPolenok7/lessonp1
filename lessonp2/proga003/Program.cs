int[] array = {10,22,33,41,15,6,17,84};

int n = array.Length;
int find = 17;

int index = 0;

while (index<n);
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
