

using System.Globalization;

DateTime today= DateTime.Now;

//DateTime birthday = DateTime.Parse(s: "8/22/1969");

// DateTime birthday = DateTime.ParseExact(s: "8/22/1969", format: "d/M/yyyy", CultrueInfo.InvariantCulture);

// DateTime birthday = DateTime.Parse(s:"8/2/1969", 



Console.WriteLine(today.ToString(format:"MMMM dd, yyyy hh:mm tt zzz"));