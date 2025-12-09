using System;

class Program
{
    static void Main(string[] args)
    {
        //I used AI to generate event ideas. The code was written by me.
        Lecture quantum = new Lecture("Quantum Frontiers Lecture", "Exploring advances in nuclear fusion research", "2026-03-15", "7pm", "120 Science Hall", "Rexburg", "ID", "Dr. Elaine Carter", 250);
        Reception gradParty = new Reception("Spring Alumni Reception", "Celebrating graduates with light refreshments and networking", "2026-04-10", "6:30pm", "45 University Center", "Rexburg", "ID", "rsvp@byuidalumni.org");
        Outdoor jazzFestival = new Outdoor("Summer Jazz in the Park", "Outdoor concert featuring local jazz ensembles", "2026-06-20", "5pm", "Central Park, 200 Main St", "Rexburg", "ID", "Sunny, 78°F");
        Event projectShowcase = new Event("Student Project Showcase", "Exhibition of innovative student projects across disciplines", "2026-05-05", "10am", "75 Innovation Lab", "Rexburg", "ID");

        List<Event> events = new List<Event>();
        events.Add(quantum);
        events.Add(gradParty);
        events.Add(jazzFestival);
        events.Add(projectShowcase);

        foreach (Event e in events)
        {
            e.DisplayShort();
            Console.WriteLine();
            Thread.Sleep(2000);
            e.DisplayStandard();
            Console.WriteLine();
            Thread.Sleep(2000);
            e.DisplayFull();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }
}