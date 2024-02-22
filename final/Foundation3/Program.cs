using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Street", "City", "ID", "USA");
        Address address2 = new Address("456 Street Name", "City", "ID", "USA");
        Address address3 = new Address("789 Street Name", "City", "ID", "USA");

        Lecture lecture = new Lecture("Lecture Title", "Lecture Description", DateTime.Now, address1, "Lecturer Name", 100);
        Reception reception = new Reception("Reception Title", "Reception Description", DateTime.Now, address2, "rsvp@email.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("OutdoorGathering Title", "OutdoorGathering Description", DateTime.Now, address3, "Sunny");

        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(outdoorGathering.GenerateFullDetails());

        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine(outdoorGathering.GenerateStandardDetails());

        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine(outdoorGathering.GenerateShortDescription());
    }
}