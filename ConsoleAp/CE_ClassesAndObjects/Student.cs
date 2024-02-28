using System;
using System.Dynamic;
using System.Security;
using Microsoft.VisualBasic;

class Student{

    public Student(){//default constructure
        
    }
    //parameterized cons
    public Student(string nam,byte rollno, string mail){
        name = nam;
        rollnumber = rollno;
        Email = mail;
    }

     public Student(string nam,byte rollno, string mail, DateTime dob):this(nam,rollno,mail){
        Dob = dob;
    }

    //field
    string name;
    //full property definition
    public string Name{

        get{
            return name;
        }
        set{
            if(value.Length >= 2){
                name = value;
            }
        }
    }
    public byte rollnumber;
    public DateTime Dob{get;}

    //auto implemented property
    // use get only for read only property
    public string Email{get; set;}

    public virtual string PrintInfo()
    {
        var studentInfo = $"Student name:{name},roll number: {rollnumber}, dob: {Dob},email: {Email}";
        return studentInfo;
    }
}