using System;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // My comments for solving this problem: //
        /* ############################################# */
        // 1. Create an array of doubles with the size of 'length'.
        // 2. Use a loop to iterate from 0 to length - 1.
        // 3. For each index, calculate the value as number * (index + 1).
        // 4. Assign the calculated value to the corresponding index in the array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }


        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>


    // My comments for solving this problem: //
    /* ############################################# */
    // 1. Check if the list is empty or has only one element; if so, return immediately as no rotation is needed.
    // 2. Calculate the effective rotation amount by taking the modulus of the amount with the list's count.
    // 3. If the effective rotation amount is 0, return immediately as no rotation is needed.
    // 4. Split the list into two parts: the last 'amount' elements and the rest of the list.
    // 5. Clear the original list.
    // 6. Add the last 'amount' elements to the front of the list.
    // 7. Add the remaining elements to the list.
    // 8. The list is now rotated to the right by the specified amount.
    // 9. Return the modified list.

    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        if (data.Count <= 1 || amount <= 0)
        {
            return; // No rotation needed for empty or single-element lists
        }
        int count = data.Count;
        amount = amount % count; // Handle cases where amount is greater than count
        if (amount == 0)
        {
            return; // No rotation needed if amount is a multiple of count
        }
        // Split the list into two parts
        List<int> lastPart = data.GetRange(count - amount, amount);
        List<int> firstPart = data.GetRange(0, count - amount);
        // Clear the original list
        data.Clear();
        // Add the last part to the front
        data.AddRange(lastPart);
        // Add the first part to the end
        data.AddRange(firstPart);     // The list is now rotated to the right by the specified amount
                
    }
}