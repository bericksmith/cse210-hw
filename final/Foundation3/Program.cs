using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Foundation Program 3\n");
        Console.Write("--------------------\n");
        Console.WriteLine("(Inheritance: The ability for one class to obtain the attributes and methods of another class directly, without having to type them.)\n");

        Address address1 = new Address("123 Main St", "Vancouver", "Washington", "United States");
        Address address2 = new Address("123 South 2nd West", "Rexburg", "Idaho", "United States");
        Address address3 = new Address("987 Test Rd.", "Seaside", "Oregon", "United States");

        Lecture lecture = new Lecture("Lecture on Programming with Classes", "Learn the ins and outs of Programming", "5/31/2023", "2", address1, "Brother Lythgoe", 100);
        Reception reception = new Reception("Fiscal Year Celebration Reception", "Celebrate a successful year", "5/31/2023", "4", address2, "1234@test.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("The Great Outdoors", "Campfire and Smores", "5/31/2023", "3", address3, "Cloud with chance of rain");

        Console.WriteLine("\nReception:");
        Console.WriteLine("-----------------");       
        Console.WriteLine("Standard Details:"); 
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("Full Details:");       
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine("***********************************");

        Console.WriteLine("\nLecture:");
        Console.WriteLine("-------------"); 
        Console.WriteLine("Standard Details:"); 
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("***********************************");

        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine("-----------------"); 
        Console.WriteLine("Standard Details:"); 
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("Full Details:");        
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("***********************************");
    }
}
