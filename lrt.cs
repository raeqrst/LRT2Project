// COMP 019 - Activity 1: Git Implementation
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LRT-2 EMERGENCY ADVISORY - MARCH 2026");
        Console.WriteLine("To alleviate the impact of rising FUEL and OIL prices,");
        Console.WriteLine("a 50% FARE REDUCTION is applied to ALL journeys");
        Console.WriteLine("until further notice.");

        string[] stations = {
            "Recto", "Legarda", "Pureza", "V. Mapa", "J. Ruiz",
            "Gilmore", "Betty Go-Belmonte", "Cubao", "Anonas",
            "Katipunan", "Santolan", "Marikina", "Antipolo", "TEST STATION"
        };

        Console.WriteLine("Stations:");
        for (int i = 0; i < stations.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + stations[i]);
        }

        Console.Write("\nPlease enter starting station number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter destination station number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        int distance = Math.Abs(end - start);

        // LATEST STANDARD FARE MATRIX (Before 50% Discount)
        double standardFare;

        if (distance == 0) standardFare = 0;
        else if (distance <= 3) standardFare = 15.00; // Standard Min
        else if (distance <= 6) standardFare = 20.00;
        else if (distance <= 9) standardFare = 27.00;
        else standardFare = 35.00;                   // Standard Max

        // APPLY THE 2026 50% EMERGENCY DISCOUNT
        double emergencyDiscount = standardFare * 0.50;
        double finalFare = standardFare - emergencyDiscount;

        // OUTPUT SUMMARY
        Console.WriteLine("\n===== FARE COMPUTATION =====");
        Console.WriteLine("Route: " + stations[start - 1] + " to " + stations[end - 1]);
        Console.WriteLine("Standard Base Fare:   ₱" + standardFare.ToString("0.00"));
        Console.WriteLine("Oil Hike Discount:   -₱" + emergencyDiscount.ToString("0.00") + " (50% OFF)");
        Console.WriteLine("----------------------------");
        Console.WriteLine("TOTAL TO PAY:         ₱" + finalFare.ToString("0.00"));
        Console.WriteLine("============================");

        Console.WriteLine("\nThank you for riding LRT-2! Stay safe.");
        Console.ReadLine();
    }
}
