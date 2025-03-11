using System;

class Program
{
    static void Main(string[] args)
    {
        //This is how to create a new instance of the class called "Job", the instance is going to be "job1"
        Job job1 = new Job();

        //Now we can assign values to the member variables of job1
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Data Scientist";
        job2.startYear = 2022;
        job2.endYear = 2023;


        // ------------- Resume Instance part
        Resume myResume = new Resume();           //Creates a local variable called myResume and uses the values of Resume
        myResume._name = "Allison Rose";


        //access to myResume, then access to _jobs list, and then add the information of job1 and job2 to the list 
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Display the information ;)
        myResume.Display();
    }
}