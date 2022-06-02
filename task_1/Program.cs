// Составить частотный словарь элементов двумерного массива

// Вариант 1
//--------------------------------------------------------------------

/*void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 6;
int n = 6;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 0;
int[,] dictionary = new int[m * n, 2];
int k = 0;

bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int r = 0; r < k; r++)
        {
            if (dictionary[r, 0] == array[i, j])
            {
                dictionary[r, 1]++;
                exist = true;
                break;
            }
        }
        if (exist == false)
        {
            dictionary[k, 0] = array[i, j];
            dictionary[k, 1]++;
            k++;
        }
    }
}
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < dictionary.GetLength(1); j++)
    {
        Console.Write($" {dictionary[i, +j]} ");
    }
    Console.WriteLine();
}*/

//-------------------------------------------------------------
// Вариант 2

/*Console.Clear();
Console.Write("Введите текст: ");
string text = Console.ReadLine() ?? "0";
text = text.ToLower(); // можно не переводить в нижний регистр
string collection = "";
for (int i = 0; i < text.Length; i++)
{
    if( !collection.Contains(text[i]))
        collection += text[i];
}

string [,] matrix = new string [collection.Length,2];

for ( int i = 0; i < collection.Length; i++)
{
    matrix[i, 0] = Convert.ToString(collection[i]);
    matrix[i, 1] = "0";
}


for ( int i = 0; i < text.Length; i++)
{
    for (int j = 0; j < collection.Length; j++)
        if(text[i] == collection[j])
        {
            matrix[j,1] = Convert.ToString(Convert.ToInt32(matrix[j, 1]) + 1);
        }
}
for(int j = 0; j < collection.Length; j++)
    Console.WriteLine($"символ '{matrix[j,0]}' в тексте встречается {matrix[j,1]} раз");*/

//-----------------------------------------------------------------------------
// Вариант 3

// Составить частотный словарь элементов двумерного массива
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int Searching(string text, char any)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == any)
        {
            count++;
        }

    }
    return count;
}
string Checking(string text)
{
    string newText = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        bool check = false;
        for (int j = i + 1; j < text.Length; j++)
        {
            if (text[i] == text[j]) check = true;
        }
        if (!check) newText = newText + $"{text[i]}";
    }
    return newText;
}
Console.Clear();
string text = "Частотный анализ – это один из методов криптоанализа,";
Console.WriteLine(text);
double size = text.Length;
double percent = 0;
string newText = Checking(text);
for (int i = 0; i < newText.Length; i++)
{
    int count = Searching(text, newText[i]);
    percent = count / size * 100;
    Console.WriteLine($"{newText[i]} is in text {count} times. Percent = {Math.Round(percent, 2)} %");
}