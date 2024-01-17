using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "General Manager";
        job1._company = "Duck Donuts";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "General Manager";
        job2._company = "Domino's";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._jobTitle = "General Manager";
        job3._company = "Aspen Art and Frame";
        job3._startYear = 2018;
        job3._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Zachary Wetsel";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();

    }
}