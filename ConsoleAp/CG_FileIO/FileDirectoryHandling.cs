
using System.IO;

class FDHandling
{
    public void CreateFile()
    {
        var folderPath = @"C:\6thsem\netcentric\ConsoleAp\CG_FileIO";
        var filePath = $"{folderPath}\\student.txt";

        

        File.WriteAllText(filePath,"It is what it is.");


    }
}