/////////////////////////////// Task 1 /////////////////////////////

// int [] ints = new int[6];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i]=Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < ints.Length; i++)
// {
//     if (i%2==0)
//     {
//     System.Console.Write($"{ints[i]} ");   
//     }
// }

/////////////////////////////// Task 2 /////////////////////////////

// int [] ints = new int[5];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i]=Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < ints.Length; i++)
// {
//     if (ints[i]%2==0)
//     {
//     System.Console.Write($"{ints[i]} ");   
//     }
// }

/////////////////////////////// Task 3 /////////////////////////////

// int[] ints = new int[5];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for (int i = 0; i < ints.Length; i++)
// {
//     if (ints[i] > 0)
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

/////////////////////////////// Task 4 /////////////////////////////

// int[] ints = new int[5];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for (int i = 0; i < ints.Length-1; i++)
// {
//     if (ints[i] < ints[ i+1 ])
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

/////////////////////////////// Task 5 /////////////////////////////

// int[] ints = new int[5];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for (int i = 0; i < ints.Length-1; i++)
// {
//     if (ints[i] < 0 && 0 > ints[ i+1 ])
//     {
//         cnt++;
//     }
//     if (ints[i] > 0 && 0 < ints[ i+1 ])
//     {
//         cnt++;
//     }
// }
// if (cnt>0)
// {
//     System.Console.WriteLine("Yes");
// }
// else {
//     System.Console.WriteLine("No");
// }

/////////////////////////////// Task 6 /////////////////////////////

// int[] ints = new int[5];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for (int i = 1; i < ints.Length - 1; i++)
// {
//     if (ints[i - 1] < ints[i] && ints[i] > ints[i + 1])
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);

/////////////////////////////// Task 7 /////////////////////////////

// using System.Runtime.InteropServices;

// int[] ints = new int[5];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine();
// Array.Reverse(ints);
// for (int i = 0; i < ints.Length; i++)
// {
//     System.Console.Write($"{ints[i]} ");
// } 

/////////////////////////////// Task 8 /////////////////////////////

// using System.Runtime.InteropServices;

// int[] ints = new int[6];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < ints.Length-1; i+=2)////////////// array [5] 
// {
//         int n = ints[i];                /////////// n = 1
//         ints[i]=ints[i+1];           ////////// 1 = 2 
//         ints[i+1]=n;                 //////  2 = 1 
// }
// for (int i = 0; i < ints.Length; i++)
// {
// System.Console.Write(ints[i] + " ");
// }

/////////////////////////////// Task 9 /////////////////////////////

// using System.Runtime.InteropServices;

// int num = Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[num];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = num-1; i > 0; i--)
// {
//  int n = ints[i];
//  ints[i] = ints[i-1];
//  ints[i-1]=n;

// }
// for (int i = 0; i < ints.Length; i++)
// {
//     System.Console.Write(ints[i] + " ");
// }

/////////////////////////////// Task 10 /////////////////////////////

// using System.Runtime.InteropServices;

// int num = Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[num];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int max=int.MinValue;
// for (int i = 0; i < ints.Length; i++)
// {
// if (max<ints[i])
// {
//     max = ints[i];
// }
// }
// System.Console.WriteLine("Max = " + max);

/////////////////////////////// Task 11 /////////////////////////////

// using System.Runtime.InteropServices;

// int num = Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[num];
// for (int i = 0; i < ints.Length; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i < ints.Length; i++)
// {
//       if (a>ints[i])
//       {
//         System.Console.WriteLine(i);
//         break;
//       }
// }
