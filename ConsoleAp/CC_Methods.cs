using System;
using System.Linq;

class Helpers{
    public void Print() => Console.WriteLine("Hello");

    public void Print(string greeting) => Console.WriteLine(greeting);

    internal float CalculateBMI(float heightInFt,float weightInkg = 50.0f){
        var heightInM = heightInFt / 3.14f;
        var bmi = weightInkg/(heightInM*heightInM);
        return bmi;
    }

    public (int,int) GetYoungestAndEldest(params int[] ages)
    {
        var youngest = ages.Min();
        var eldest = ages.Max();

        return (youngest,eldest);
    }
}
