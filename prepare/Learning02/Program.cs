using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "BYU";
        job1._jobTitle = "Software Engineer1";
        job1._startYear = "2023";
        job1._endYear = "2024";

        //job1.DisplayJobDetails();

        /*Console.WriteLine($"{job1._company}");
        Console.WriteLine($"{job1._jobTitle}");
        Console.WriteLine($"{job1._startYear}");
        Console.WriteLine($"{job1._endYear}");*/

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer2";
        job2._startYear = "2023";
        job2._endYear = "2024";

        //job2.DisplayJobDetails();

        /*Console.WriteLine($"{job2._company}");
        Console.WriteLine($"{job2._jobTitle}");
        Console.WriteLine($"{job2._startYear}");
        Console.WriteLine($"{job2._endYear}");*/

        Resume resume1 = new Resume();
        resume1._PersonName = "Alejandro Modera";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        resume1.DisplayResume();
    }
}