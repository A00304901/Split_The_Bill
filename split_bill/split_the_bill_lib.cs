using System;
using System.Collections.Generic;
namespace split_bill;

public class bill_splitter

{
    // this is the firts method
    public decimal Amountsplited(decimal totalAmount, int numberOfPeople)
    {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of person is greater than zero.", nameof(numberOfPeople));
        }

        if (totalAmount < 0)
        {
            throw new ArgumentException("Total amount must be non-negative.", nameof(totalAmount));
        }

        // Calculate the split aamount
        decimal splitAmount = Math.Ceiling(totalAmount / numberOfPeople * 100) / 100;
        return splitAmount;
    }
    
    // this is the second method
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

    // this is the third method
    public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
    {
        // Check if inputs are valid
        if (price <= 0 || numberOfPatrons <= 0 || tipPercentage < 0 || tipPercentage > 100)
        {
            return 0; // Or any default value indicating an error
        }

        // Calculate tip per person
        return price * (decimal)(tipPercentage / 100) / numberOfPatrons;
    }
}


    




