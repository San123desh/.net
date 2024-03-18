
using System;
using System.IO;

class FDHandling
{
    public void CreateFile()
    {
        var folderPath = @"C:\6thsem\netcentric\ConsoleAp\CG_FileIO";
        var filePath = $"{folderPath}\\student.txt";
        File.WriteAllText(filePath,"It is what it is.");

        //to text files format FileA1.txt,FileB2.txt
        for(var counter = 'A'; counter <= 'J'; counter++)
        {
            File.WriteAllText($"{folderPath}\\File{counter}{counter - 64}.txt",DateTime.Now.ToLongDateString());
        }
    }

    public void ReadFile()
    {
        var filePath = @"C:\6thsem\netcentric\ConsoleAp\CG_FileIO\FileA1.txt";
        var fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);

        //read file and count number of words and sentences
        var sentences = fileContent.Split(['.','?','!']);
        Console.WriteLine($"Number of sentences: {sentences.Length}");
        // foreach(var sentence in sentences){
        //     Console.WriteLine(sentence);
        // }

        var words = fileContent.Split([" ","\\n","-",":","\\","."],StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Number of words: {words.Length}");
         foreach(var word in words){
            Console.WriteLine(word);
        }

    }
}

