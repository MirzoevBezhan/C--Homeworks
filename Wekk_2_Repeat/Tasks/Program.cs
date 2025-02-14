using System.Globalization;

List<string> strings = new List<string>();

strings.AddRange("Moskov", "Piter", "Novosibirsk", "Ekaterinburg", "Kazan");

strings.Insert(0, "Sochi");

// strings.Remove("Ekaterinburg");

// strings.Contains("Moskov");

// var b = strings.FindAll(a => a.Length>6);

// strings.Sort();

// System.Console.WriteLine(string.Join(",",strings));

//////////////////// Task 2

List<int> ints = new List<int>() { 7, 12, 3, 9, 5, 15, 8, 1, 6, 11 };

// var Evens = ints.FindAll(a=>a%2==0);
// foreach (var item in Evens)
// {
//     System.Console.Write(item +" ");
// }

// ints.RemoveAll(n => n < 5);
// foreach (var item in ints)
// {
//     System.Console.Write(item + " ");
// }

ints.Insert(ints.Count, 20);

ints.Max();
ints.Min();

ints.Sort();
ints.Reverse();

ints.Sum();

// System.Console.WriteLine(string.Join(" ",ints));

//////////////// Task 3

Student student = new Student();
student.name="Soruh";
student.age=20;
student.course=1;
Student student2 = new Student();
student2.name="Yusuf";
student2.age=2;
student2.course=3;
Student student3 = new Student();
student3.name="Matlab";
student3.age=22;
student3.course=3;
Student student4 = new Student();
student4.name="Jeremy";
student4.age=23;
student4.course=3;
Student student5 = new Student();
student5.name="Alish";
student5.age=10;
student5.course=5;

List<Student> students = new List<Student>();
students.AddRange(student,student2,student3,student4,student5);
var Thirdcourse = students.FindAll(n=>n.course==3);
// foreach (var item in Thirdcourse)
// {
//     System.Console.WriteLine(item.name);
// }
var Agetwen = students.FindAll(n=>n.age>20);
// foreach (var item in Agetwen)
// {
//     System.Console.WriteLine(item.name);
// }

students.GroupBy(n=>n.age);

students.Min(m=>m.age);

students.Sum(n=>n.age/students.Count);

System.Console.WriteLine(string.Join("\n", strings.Select(n => n)));