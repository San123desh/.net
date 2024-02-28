//LINQ - language Integreted query

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

class LINQLearner{
    public void Learn(){
        int[] numbers = [4,5,6,23,64,0];

        
        List<Student> students =[
            new Student("ramu shrestha",23,"rag@gmail.com"),
            new Student("shamu shrestha",20,"sar@xyz.com"),
            new Student("katr shrestha",57,"kar@live.com"),
            new Student("katr shrestha",19,"kar@gmail.com")
        ];

        var squaredNumbers = numbers.Select(x=> x*x);

        var evenNumbers = numbers.Where(x=> x % 2 == 0);

        // method syntax
        var cubes = numbers.Where(x=> x % 2==1).Select(x=> Math.Pow(x,3));

        // Expression syntax
        cubes = from x in numbers where x % 2 ==1 select Math.Pow(x ,3);



        var roll = students.Where(student=> student.rollnumber < 50).OrderBy(s => s.Name);

        //group all by email domain
        var stdGroups = students.GroupBy(st => st.Email[(st.Email.IndexOf("@")+ 1)..]);

        foreach(var stdGroup in stdGroups){
            Console.WriteLine($"Domain name: {stdGroup.Key}");
            foreach(var student in stdGroup){

                // Console.WriteLine($"\t\t{student.Name}");
                // student.PrintInfo();

                Console.WriteLine($"\t\t{student.PrintInfo()}\n");
            }
        }
    }
}   