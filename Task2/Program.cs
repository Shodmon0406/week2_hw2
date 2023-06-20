
Date date = new Date(2023, 06, 20);
System.Console.WriteLine(date.GetYear());
System.Console.WriteLine(date.GetMonth());
System.Console.WriteLine(date.GetDay());
System.Console.WriteLine(date.ToString());
date.SetYear(2024);
date.SetMonth(07);
date.SetDay(21);
System.Console.WriteLine(date.ToString());
date.SetDate(2025, 08, 22);
System.Console.WriteLine(date.ToString());