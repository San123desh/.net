using System;

class DSStudent:ITStudent{
    public DSStudent(String name,byte roll, string email, string project):base(name,roll, email, project){

    }
    public string DataScienceInstructor{get; set;}
}

//student -> itstudent -> dsstudent