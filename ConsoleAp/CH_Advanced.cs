//parallel programming->for cpu intensive tasks
//TPL = Task Parallel Library
//Threads, Tasks

using System;
using System.Threading;
using System.Threading.Tasks;
class ParallelLearner
{
    public void Learn()
    {
        string[] words = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k"];
        //sequential->waiting
        Console.WriteLine("sequential loop");
        foreach(var word in words)
        {
            Thread.Sleep(1000);
            Console.WriteLine(word);
        } 

        Console.WriteLine("Parallel loop");
        Parallel.ForEach(words, word=>{
            Thread.Sleep(1000);
            Console.WriteLine(word);
        });
    }
       
}


//synchronous->predictable ->what comes after what

//parallel vs asynchronous

// asynchronous programming->async,await
//I/O bound, scaling
class AsyncLearner
{

    async Task MakeTea()
    {
        await IgniteBurner();
        await GrindMasala();
        await PourMilk();
    }
    public async Task IgniteBurner()
    {
        await Task.Delay(1000);

    }

    async Task GrindMasala()
    {
        await Task.Delay(1000);

    }

    async Task PourMilk()
    {
        await Task.Delay(1000);
    }
}

//model view controller


