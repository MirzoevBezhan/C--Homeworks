///////////first 

// List<int> ints = new List<int>(){1,2,3,4,5,6};

//  int GetSum(List<int> ints,int i=0,int sum=0){
//     if (i==ints.Count)
//     {
//         return sum;
//     }
//      return GetSum(ints,i+1,sum+=ints[i]);
// }
// System.Console.WriteLine(GetSum(ints));

//////////task 2 

// int GetSum(int num,int ind=0)
// {
//     if (ind == num)
//     {
//         return num;
//     }
//     System.Console.Write(ind + " ");
//     return GetSum(num,ind+1);
// }

// System.Console.Write(GetSum(20));

//////////////task 3 

// using System.Diagnostics;
// int GetSum(int num, int ind = 0, int sum = 0)
// {
//     if (ind == num+1)
//     {
//         return sum;
//     }
//     return GetSum(num, ind + 1, sum+=ind);
// }

// System.Console.Write(GetSum(4));

///////////task 4

// int GetSum(int num)
// {
//     if (num == 0)
//     {
//         return 0;
//     }
//     int ind = 1;
//     return ind + GetSum(num / 10);
// }

// System.Console.Write(GetSum(450));

//////////task 5

// int GetSum(int num)
// {
//     if (num == 0)
//     {
//         return 0;
//     }
//     int ind = num%10;
//     return ind + GetSum(num / 10);
// }

// System.Console.Write(GetSum(450));

//////////task 6

// int GetSum(int [] ints,int index = 0,int max = int.MinValue)
// {
//     if (index == ints.Length)
//     {
//         return max;
//     }
//     if (ints[index]>max)
//     {
//         max=ints[index];
//     }
//     return GetSum(ints,index+1,max);
// }

// int []arr = new int []{1,3,5,32,2};
// System.Console.Write(GetSum(arr));

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

// int GetSum(int num)
// {
//     if (num == 0)
//     {
//         return 1;
//     }
//     return num * GetSum(num-1);
// }

// int num = 5;
// System.Console.Write(GetSum(num));
