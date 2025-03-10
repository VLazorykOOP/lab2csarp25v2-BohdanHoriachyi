using System;

Random random = new Random();
double result = 0;
int temp = 0;

void Task1()
{
    Console.WriteLine("Vvedit n:"); 
    int n = int.Parse(Console.ReadLine());

    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = random.Next(-100, 100);
        Console.Write(a[i] + "\t ");
        temp += a[i];
    }
    Console.WriteLine();
    Console.WriteLine($"\nResult:{result = temp / n} ");

    temp = 0;

    Console.WriteLine("\nVvedit m:");
    int m = int.Parse(Console.ReadLine());
    int[,] b = new int[n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            b[i, j] = random.Next(-100, 100);
            Console.Write(b[i,j] + "\t ");
            temp += b[i,j];
        }
        Console.WriteLine();
    }
    Console.WriteLine($"\nResult:{result = temp / n*m} ");
}

void Task2()
{
    temp = 0;
    Console.WriteLine("Vvedit n:");
    int n = int.Parse(Console.ReadLine());

    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = random.Next(-100, 100);
        Console.Write(a[i] + "\t ");
    }

    Console.WriteLine();
    temp = a[0];
    int k = 0;

    for (int i = 0; i < n; i++)
    {
        if (temp < a[i])
        {
            k = i;
            temp = a[i];
        }
    }
    Console.WriteLine("\nMax:" + temp + "\nMax index:" + k);
    Console.WriteLine("\nVidmini vid Max:\n");
    for (int i = 0; i < n; i++)
    {
        if (i != k)
        {
            Console.Write("\t " + i);
        }
    }

}

void Task3()
{
    temp = 0;

    Console.WriteLine("Vvedit n:");
    int n = int.Parse(Console.ReadLine());

   
    int[,] a = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = random.Next(-100, 100);
            Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for (int j = 0; j < n / 2; j++)
    {
        int opposite = n - 1 - j;
        for (int i = 0; i < n; i++)
        {
            int temp = a[i, j];
            a[i, j] = a[i, opposite];
            a[i, opposite] = temp;
        }
    }

    Console.WriteLine("\nMatrix after changes:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Task4()
{
    temp = 0;
    Console.WriteLine("Vvedit n:\n");
    int n = int.Parse(Console.ReadLine());


    int[][] a = new int[n][];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Vvedit m:");
        int m = int.Parse(Console.ReadLine());
        a[i] = new int[m];
        for (int j = 0; j < m; j++)
        {
            a[i][j] = random.Next(-100, 100);
            Console.Write(a[i][j] + "\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\nVvedit max:");
    temp = int.Parse(Console.ReadLine());

    int[] b = new int[n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < a[i].Length; j++)
        {
            if (a[i][j] > temp)
            {
                b[i]++;
            }
        }
    }
    foreach (var item in b)
    {
        Console.Write(item + "\t");
    }
}

Console.WriteLine("0 - Task_1");
Console.WriteLine("1 - Task_2");
Console.WriteLine("2 - Task_3");
Console.WriteLine("3 - Task_4\n");

string _task = Console.ReadLine();
int task;

if (int.TryParse(_task, out task) && task >= 0 && task <= 3)
{
    task = int.Parse(_task);
    switch (task)
    {
        case 0:
            Task1();
            break;
        case 1:
            Task2();
            break;
        case 2:
            Task3();
            break;
        case 3:
            Task4();
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}
else
{
    Console.WriteLine("Invalid input");
}