/////////// Task 1

// string text = Console.ReadLine();
// void ChangeTextFormat(string name)
// {
//     System.Console.WriteLine("Lower: " + name.ToLower());
//     System.Console.WriteLine("Upper: " + name.ToUpper());
// }
// ChangeTextFormat(text);

/////////// Task 2

// string text = Console.ReadLine();

// int CountVowel(string text)
// {
//     int cnt = 0;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i]=='y' || text[i]=='Y'|| text[i]=='I' || text[i]=='i' || text[i]=='O'|| text[i]=='o'|| text[i]=='e' || text[i]=='E' || text[i]=='A'|| text[i]=='a')
//         {
//             cnt++;
//         }
//     }
//     return cnt;
// }
// System.Console.WriteLine("Vowel: " + CountVowel(text));

/////////// Task 3

// string text = Console.ReadLine();

// string DeleteEmpty(string text)
// {
//  string result = text.Trim().Replace(" ", "");
//  return result;
// }
// System.Console.WriteLine("Result: " + DeleteEmpty(text));

/////////// Task 4

// using System.Runtime.InteropServices;
// using System.Text;

// void CreateText()
// {
//     StringBuilder stringBuilder = new StringBuilder(100);
//     for (int i = 0; i < 100; i++)
//     {
//         stringBuilder.Append("a");
//     }
//     for (int j = 4; j < 100; j += 5)
//     {
//         stringBuilder[j] = 'b';
//     }
// System.Console.WriteLine(stringBuilder.ToString());
// }
// CreateText();

/////////// Task 5

// List<string> strings = new List<string>();
// string a = "Jeremy";
// string b = "get's";
// string c = "up";
// string d = "early";
// strings.AddRange(a,b,c,d);
// void createText(List<string> strings)
// {
//     foreach (var item in strings)
//     {
//         System.Console.Write(item + " ");
//     }
// }
// createText(strings);
