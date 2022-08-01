// namespace RomanToInt;
//
// public class Practice
// {
//     class RomanToInt
// {
//     // static void Main()
//     {
//         string[] list = new string[5];
//         list = R2I("IIIII");
//         Print(list);
//         int total = DoMath(list);
//         Console.WriteLine(total);
//         Console.WriteLine("======");
//         Console.WriteLine();
//         list = R2I("XVIII");
//         Print(list);
//         total = DoMath(list);
//         Console.WriteLine(total);
//         Console.WriteLine("======");
//         Console.WriteLine();
//         list = R2I("MDCLX");
//         Print(list);
//         total = DoMath(list);
//         Console.WriteLine(total);
//         Console.WriteLine("======");
//         Console.WriteLine();
//
//
//         
//
//     }
//
     // static void Print(string[] list)
     // {
     //     foreach (string i in list)
     //     {
     //         Console.WriteLine(i);
     //     }
     //     Console.WriteLine();
     //
     // }
//
//     static int DoMath(string[] s)
//     {
//         int total = 0;
//         for (int i = 0; i < s.Length; i++)
//         {
//             if (s.Length == 1)
//             {
//                 total += Int32.Parse(s[i]);
//
//             }
//             else if (i == s.Length)
//             {
//                 total += Int32.Parse(s[i]);
//             }
//             else if ((i + 1) <= s.Length && (Int32.Parse(s[i]) >= Int32.Parse(s[i + 1]))) // parse these
//             {
//                 total += Int32.Parse(s[i]);
//             }
//             else if ((i + 1) <= s.Length && ((Int32.Parse(s[i]) < Int32.Parse(s[i + 1]))))
//             {
//                 total -= Int32.Parse(s[i]);
//             }
//         }
//
//         return total;
//     } 
//
//     public static string[] R2I(string s)
//     {
//         string[] IntList = new string[s.Length];
//         for (int i = 0; i < s.Length; i++)
//         {
             // switch (s[i])
             // {
             //     case 'I':
             //         IntList[i] = "1";
             //         break;
             //     case 'V':
             //         IntList[i] = "5";
             //         break;
             //     case 'X':
             //         IntList[i] = "10";
             //         break;
             //     case 'L':
             //         IntList[i] = "50";
             //         break;
             //     case 'C':
             //         IntList[i] = "100";
             //         break;
             //     case 'D' :
             //         IntList[i] = "500";
             //         break;
             //     case 'M':
             //         IntList[i] = "1000";
             //         break;
             // }
//         }
//
//         return IntList;
//
//     }
//
//     // public static string R2I(string s)
//     // {
//     //     string IntList = "";
//  
//     //
//     //     return IntList;
//     // }
// }
// }