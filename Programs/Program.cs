

string[] array = { "Hello", "2", "world", ":-)"};
int count = ArrayVerify(array);
string[] resultArray = FillArray(array, count);

int ArrayVerify(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
string[] FillArray(string[] array, int count)
