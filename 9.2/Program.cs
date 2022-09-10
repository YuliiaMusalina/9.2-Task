// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int element1 = ReadInt("Введите первый элемент: ");
int element2 = ReadInt("Введите второй элемент: ");
int n = ReadInt("введите количество элементов N: ");

int[] fibonachi = new int[n];

fibonachi[0] = element1;
fibonachi[1] = element2;

for(int i = 2; i < n; i++)
{
    fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
}

Console.Write(string.Join(" ", fibonachi));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

