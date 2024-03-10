using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Sumsung"


        Job job2 = new Job()
        job2.string_jobTitle = "Manager";
        job2._company = "Apple"

        Resume myResume = newResume()
        myResume._name = "Sifiso Khuzwayo";

        myResume._jobs.Add(job1);
        myResume._jobs.add(job2);


        job1.Display();
        job2.Display();

    }
}