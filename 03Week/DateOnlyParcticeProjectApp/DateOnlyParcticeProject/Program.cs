
using System.Globalization;

DateOnly birthday = DateOnly.ParseExact("28/5/2001","d/M/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(birthday.ToString("MMM dd, yyyy"));
Console.WriteLine(birthday);