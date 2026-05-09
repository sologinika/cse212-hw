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

        // Step 1: I create a new array of doubles with size equal to 'length'.
        // This array will store the multiples of the given number.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

        // Step 2: Loop through each position in the array,
        // starting from index 0 up to length - 1.
      
        // Step 3: Calculate the multiple by multiplying
            // the given number by (i + 1).
            // Example: if number = 3:
            // i=0 -> 3*1 = 3
            // i=1 -> 3*2 = 6
            // i=2 -> 3*3 = 9

        // Step 4: Return the completed array.
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
                    
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

         // Step 1: Get the last 'amount' elements from the list.

        // Step 2: Remove those elements from the end of the list.

        // Step 3: Insert those saved elements at the beginning of the list.

        // This modifies the original list directly.
    }
}
