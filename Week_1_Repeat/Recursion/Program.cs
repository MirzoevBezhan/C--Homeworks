///////////first 

// List<int> ints = new List<int>(){1,2,3};

//  int GetSum(List<int> ints,int i=0,int sum=0){
//     if (i==ints.Count)
//     {
//         return sum;
//     }
//      return GetSum(ints,i+1,sum+=ints[i]);
// }
// System.Console.WriteLine(GetSum(ints));

//////////task 2 

// int PrintNaturalNums(int num,int ind=0)
// {
//     if (ind == num)
//     {
//         return num;
//     }
//     System.Console.Write(ind + " ");
//     return PrintNaturalNums(num,ind+1);
// }

// System.Console.Write(PrintNaturalNums(20));

//////////////task 3 

// using System.Diagnostics;
// int SumOfNumsToN(int num, int ind = 0, int sum = 0)
// {
//     if (ind == num+1)
//     {
//         return sum; 
//     }
//     return SumOfNumsToN(num, ind + 1, sum+=ind);
// }

// System.Console.Write(SumOfNumsToN(4));

///////////task 4

// int CountNumsInNums(int num)
// {
//     if (num == 0)
//     {
//         return 0;
//     }
//     int ind = 1;
//     return ind + CountNumsInNums(num / 10);
// }

// System.Console.Write(CountNumsInNums(450));

//////////task 5

// int SumOfNumsInN(int num)
// {
//     if (num == 0)
//     {
//         return 0;
//     }
//     int ind = num%10;
//     return ind + SumOfNumsInN(num / 10);
// }

// System.Console.Write(SumOfNumsInN(450));

//////////task 6

// int Max(int [] ints,int index = 0,int max = int.MinValue)
// {
//     if (index == ints.Length)
//     {
//         return max;
//     }
//     if (ints[index]>max)
//     {
//         max=ints[index];
//     }
//     return Max(ints,index+1,max);
// }

// int []arr = new int []{1,3,5,32,2};
// System.Console.Write(Max(arr));

///////////task 7

// string GetSum(string name)
// {
//     int index = name.Length;
//     if (index >= 0)
//     {
//         return name;
//     }
//     index-=1;
//     System.Console.WriteLine(name[index]);
//     return GetSum(name);
// }

// string name = "Chingizhan";
// System.Console.Write(GetSum(name));

///////////task 8

// int Factorial(int num)
// {
//     if (num == 0)
//     {
//         return 1;
//     }
//     return num * Factorial(num-1);
// }

// int num = 5;
// System.Console.Write(Factorial(num));
