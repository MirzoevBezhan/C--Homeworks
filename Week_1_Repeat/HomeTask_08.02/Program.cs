//////////////// Task 1

// DateTime now = DateTime.Now;

// System.Console.WriteLine("Year = " + now.Year);
// System.Console.WriteLine("Month = " + now.Month);
// System.Console.WriteLine("Day = " + now.Day);
// System.Console.WriteLine("Hour = " + now.Hour);
// System.Console.WriteLine("Minute = " + now.Minute);
// System.Console.WriteLine("Second = " + now.Second);
// System.Console.WriteLine("Millisecond = " + now.Millisecond);

/////////////// Task 2

// int cnt = 0 ;
// for (; ; )
// {
//     System.Console.Write("> ");
//     string a = Console.ReadLine();
//     cnt++;
//     if (a=="End" || a=="end" || a=="END" || a == "Tamom" || a == "Stop")
//     {
//       System.Console.WriteLine(cnt-1);        
//       break;
//     }
// }

/////////////// Task 3

// using System.Runtime.InteropServices;

// Gauge gauge = new Gauge();
// gauge.Value=2;
// gauge.Enhance();
// gauge.Enhance();
// gauge.Enhance();
// gauge.Decrease();
// System.Console.WriteLine(gauge.Full());
// System.Console.WriteLine(gauge.Value);

/////////////// Task 4

Counter counter = new Counter(2);
counter.Decrease();
counter.Decrease(2);
counter.Increase(2);
counter.Increase(2);
counter.Show();
