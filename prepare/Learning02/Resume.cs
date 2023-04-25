using System;
//Create the resume class
public class Resume
{
    //Create member variables
    public string _name;


    //Create the member variable for the list of Jobs
    public List<Job> _jobs = new List<Job>();


    //add a method to display resume details
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //iterate through each Job instance in the list of jobs and display them
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }


}