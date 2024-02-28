
using System.Collections.Generic;

class Collections
{
    void LearnCollections()
    {
        double[] weights = [45.56, 65.7];
        string[,] namelist = new string[3,4];
        string[][] names = [["a", "b","c"], ["d", "e"],["f","g","h"]];


        //Builtin Collections : List, Dictionary 
        List<string> stdNames = ["Rame", "sham"];

        Dictionary<string, char> studentGrades = new()
        {
            ["Ramu"] = 'c',
            ["babi"] = 'b',
        };
        var grade = studentGrades["Ramu"];
    }
}