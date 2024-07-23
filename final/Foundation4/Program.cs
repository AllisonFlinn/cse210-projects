using System;

class Program
{
    static void Main(string[] args)
    {
         List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("July 15, 2024", 20, 2.8);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("July 17, 2024", 60, 11);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("July 24, 2024", 20, 15);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}