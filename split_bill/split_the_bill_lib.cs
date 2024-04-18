using System;
using System.Collections.Generic;
namespace split_bill;

public class bill_splitter

{
    public decimal Amountsplited(decimal totalAmount, int numberOfPeople)
    {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than zero.", nameof(numberOfPeople));
        }

        if (totalAmount < 0)
        {
            throw new ArgumentException("Total amount must be non-negative.", nameof(totalAmount));
        }

        // Calculate the split amount by rounding up to ensure fairness
        decimal splitAmount = Math.Ceiling(totalAmount / numberOfPeople * 100) / 100;
        return splitAmount;
    }
    public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        if (mealCosts == null || mealCosts.Count == 0)
        {
            throw new ArgumentException("Meal costs dictionary cannot be null or empty.", nameof(mealCosts));
        }

        if (tipPercentage < 0 || tipPercentage > 100)
        {
            throw new ArgumentException("Tip percentage must be between 0 and 100.", nameof(tipPercentage));
        }

        Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();
        decimal totalTip = 0;

        // Calculate total tip
        foreach (var kvp in mealCosts)
        {
            totalTip += kvp.Value * (decimal)(tipPercentage / 100);
        }

        // Calculate tip per person
        decimal tipPerPerson = totalTip / mealCosts.Count;

        // Assign tip amount to each person
        foreach (var kvp in mealCosts)
        {
            tipAmounts.Add(kvp.Key, tipPerPerson);
        }

        return tipAmounts;
    }
    public static void Main(string[] args)
    {
        // Example usage
        TipCalculator calculator = new TipCalculator();
        Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>
        {
            {"Jay", 25.00m},
            {"abc", 30.00m},
            {"xyz", 20.00m}
        };
        float tipPercentage = 15.0f;

        Dictionary<string, decimal> tipAmounts = calculator.CalculateTip(mealCosts, tipPercentage);

        // Print the result
        Console.WriteLine("Tip distribution:");
        foreach (var kvp in tipAmounts)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value:C}");
        }

    }

    private class TipCalculator
    {
        public TipCalculator()
        {
        }

        internal Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            throw new NotImplementedException();
        }
    }
}



