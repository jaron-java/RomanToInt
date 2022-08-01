namespace RomanToInt;

public class Program
{
    static void Main()
    {
        int[] intlist = new int[5];
        intlist = StringToInts("IX");
        Print(intlist);
        Console.WriteLine("=====");
        int total = 0;
        total = Add(intlist);
        Console.WriteLine(total);
        Console.WriteLine("=======");
        
        intlist = StringToInts("XC");
        Print(intlist);
        Console.WriteLine("======");
        total = Add(intlist);
        Console.WriteLine(total);
    }

    static int Add(int[] list)
    {
        int length = list.Length - 1;
        int total = 0;
        // if (length == 1)
        // {
        //     total += list[0];
        //     return total;
        // }
        for (int i = 0; i <= length; i++)
        {
            if (i < length)
            {
                if (list[i] >= list[i + 1])
                {
                    total += list[i];
                }
                else if (list[i] < list[i + 1])
                {
                    total -= list[i];
                }
            }
            else if (i == length)
            {
                total += list[i];
            }
        }

        return total;
    }
    static void Print(int[] list)
    {
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

    }
    static int[] StringToInts(string s)
    {
        int[] IntList = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':
                    IntList[i] = 1;
                    break;
                case 'V':
                    IntList[i] = 5;
                    break;
                case 'X':
                    IntList[i] = 10;
                    break;
                case 'L':
                    IntList[i] = 50;
                    break;
                case 'C':
                    IntList[i] = 100;
                    break;
                case 'D' :
                    IntList[i] = 500;
                    break;
                case 'M':
                    IntList[i] = 1000;
                    break;
            }

        }

        return IntList;
    }

}