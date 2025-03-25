using System;
using System.Globalization;

// ***********************************************
// 1.  DateTime - demo
DateTime dt = DateTime.Now;
Console.WriteLine(dt.Ticks);
Console.WriteLine(dt.ToLocalTime());
Console.WriteLine(dt.ToLongDateString());
Console.WriteLine(dt.ToOADate());
Console.WriteLine(dt.ToShortTimeString());
Console.WriteLine(dt.ToUniversalTime());

DateTimeOffset dt2 = DateTimeOffset.Now;
Console.WriteLine(dt2);

DateTime dt3 = new DateTime(1254875155584458555, DateTimeKind.Local);
Console.WriteLine(dt3);


DateTime dt4 = new DateTime(5785, 6, 22, new HebrewCalendar());
Console.WriteLine(dt4);

Console.WriteLine(DateTime.MinValue);
Console.WriteLine(DateTime.MaxValue);

Console.WriteLine(dt.Year);
Console.WriteLine(dt.Hour);

Console.WriteLine(dt.DayOfWeek);
Console.WriteLine(dt.DayOfYear);
// ***********************************************




// ***********************************************
// ***********************************************
// 2. MyDateTime - demo
MyDateTime md = new MyDateTime(18, 3, 2025, 10, 35, 42);
Console.WriteLine(md);

MyDateTime md2 = new MyDateTime(23, 6, 2023);
MyDateTime md3 = new MyDateTime(an: 2025, luna: 12, zi: 13);

Console.WriteLine(md3);

if (md2 == md3)
{
    Console.WriteLine($"{md2} / {md3} sunt egale");
}
else
{
    Console.WriteLine($"{md2} / {md3} nu sunt egale");
}

Console.WriteLine(md2 - md3); // 


// ***********************************************