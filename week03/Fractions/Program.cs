using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3,4);
        Fraction f4 = new Fraction(1,3);

        List<Fraction> fractions = [f1,f2,f3,f4];

        foreach(Fraction f in fractions){
            Console.WriteLine($"String: {f.GetFractionString()}");
            Console.WriteLine($"Decimal: {f.GetDecimalValue()}");
        }
    }
}