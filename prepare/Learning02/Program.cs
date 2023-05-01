using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        Jobs job2 = new Jobs();

        job1._jobTitle = "Software Engineer";
        job2._jobTitle = "Manager";

        job1._company = "Microsoft";
        job2._company = "Apple";

        job1._StartYear = 2019;
        job2._StartYear = 2022;

        job1._EndYear = 2022;
        job2._EndYear = 2023;

        resume myResume = new resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResults();

    }
}