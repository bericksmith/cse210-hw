using System;

//Create the job class
public class Job
{
    //Create member variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;


    //add a method (member function) to display the job details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}