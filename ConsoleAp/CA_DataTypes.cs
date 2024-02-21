using System;

class Helpers{
    // method overloading
    void Print(){
        console.WriteLine("Ola!");
    }
    void Print(string greeting){
        console.WriteLine(greeting);
    }

    float CalculateBMIT(float heightInFt,float weightInkg){
        float heightInFt = heightInFt / 3.14f;
        float bmi = weightInkg/(heightInFt*heightInFt);
        return bmi;
    }
}