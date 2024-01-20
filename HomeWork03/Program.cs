// See https://aka.ms/new-console-template for more information

int findAmountDig(int num)
{
    int amount = 0;
    bool isEnd = false;
    while (!isEnd)
    {
        if (num != 0)
        {
            num = num / 10;
            amount++;
        }
        else
        {
            isEnd = true;
        }
    }
    return amount;
}

int[] convertToIntArray(String textNum)
{
    bool isEnd = false;
    int num = Convert.ToInt32(textNum);
    int amountDig = findAmountDig(num);
    int[] array = new int[textNum.Length];
    int var = 0;
    int i2 = 0;

    while (!isEnd)
    {
        int ten = 1;
        for (int i = 1; i <= amountDig - 1; i++)
        {
            ten = ten * 10;
        }
        if (num / ten != 0)
        {
            var = num / ten;
            Console.Write($"{var} ");
            array[i2] = var;
            num = num - var * ten;
            amountDig = amountDig - 1;
            i2++;
        }
        else
        {
            isEnd = true;
        }
    }
    return array;
}

bool sumDig(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];

    }
    System.Console.WriteLine($"сумма {sum}");
    if (sum % 2 == 0)
    {
        return true;
    }
    return false;
}

int numberGeneration(bool useMinus)
{
    int amountDec = 2;
    int amountVar = 20;
    int dec = 1;
    int amountDig = 0;
    int minNumber = 0;
    int maxNumber = 200;
    if (useMinus)
    {
        minNumber = -maxNumber;

    }
    for (int i = 0; i < amountDec; i++)
    {
        dec = dec * 10;
    }

    dec = dec - 1;
    int num = new Random().Next(minNumber, maxNumber + 1);
    for (int i = 0; i < amountVar; i++)
    {
        if (num <= dec)
        {
            amountDig = amountDig + 1;
        }
        else
        {
            //System.Console.Write($"{num} ");
        }
        num = new Random().Next(minNumber, maxNumber + 1);
    }
    return num;
}

int[] generateArray()
{
    int maxSizeArray = 11;
    int[] array = new int[maxSizeArray];
    for (int i = 0; i < maxSizeArray; i++)
    {
        array[i] = numberGeneration(true);  
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i <= array.Length-1; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
}


Console.WriteLine($"----====== Задача 1 ======-----");
bool isEnd = false;
int sum = 0;
while (!isEnd)
{
    Console.Write($"Введите чилое или q для выхода: ");
    String enter = "";
    enter = Console.ReadLine();
    char[] characters = enter.ToCharArray();

    if (characters[0].Equals('q'))
    {
        isEnd = true;
        Console.WriteLine($"Выход {isEnd}");
    }
    else
    {
        isEnd = sumDig(convertToIntArray(enter));
        Console.WriteLine($"Выход {isEnd}");
    }
}


Console.WriteLine($"----====== Задача 2 ======-----");
int[] array = generateArray();

int sum = 0;
Console.WriteLine($"Четные числа");
for (int i = 0; i < maxSizeArray; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
        sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма {sum}");


Console.WriteLine($"----====== Задача 3 ======-----");
int[] array = generateArray();
printArray(array);
int tmp = 0;
int length = array.Length-1;

for (int i = 0; i < length/2; i++)
{
    tmp = array[i];
    array[i] = array[length-i];
    array[length - i] = tmp;
}
Console.WriteLine();
printArray(array);
