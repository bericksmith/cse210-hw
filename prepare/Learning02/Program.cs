using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Front End Designer";
        job1._company = "Acme Inc.";
        job1._startYear = 2003;
        job1._endYear = 2012;
        //job1.DisplayJobDetails(); 

        Job job2 = new Job();
        job2._jobTitle = "PE Teacher";
        job2._company = "Evergreen High School";
        job2._startYear = 2013;
        job2._endYear = 2015;
        //job2.DisplayJobDetails();

        //create a new instance of the Resume class.
        Resume theResume = new Resume();
        theResume._name = "Berick Smith";
        //add the two jobs to the list of jobs in the resume object
        theResume._jobs.Add(job1);
        theResume._jobs.Add(job2);
        theResume.DisplayResume();


    }
}