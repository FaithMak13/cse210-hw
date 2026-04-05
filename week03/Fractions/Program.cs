using System.Xml.Schema;

Fraction f1 = new Fraction();        // 1/1
Fraction f2 = new Fraction(5);       // 5/1
Fraction f3 = new Fraction(3, 4);    // 3/4

Console.WriteLine(f1.GetFractionString());
Console.WriteLine(f1.GetDecimalValue());

Console.WriteLine(f2.GetFractionString());
Console.WriteLine(f2.GetDecimalValue());

Console.WriteLine(f3.GetFractionString());
Console.WriteLine(f3.GetDecimalValue());
