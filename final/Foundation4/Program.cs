using System;

class Program
{
    static void Main(string[] args)
    {
        Exercise running = new Running("12/11/2025", 30, 7);
        Exercise biking = new Biking("12/12/2025", 45, 6);
        Exercise swimming = new Swimming("12/13/2025", 60, 42);
        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(running);
        exercises.Add(biking);
        exercises.Add(swimming);

        foreach (Exercise exercise in exercises)
        {
            exercise.DisplaySummary();
        }
    }
}