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
        // step 1: Create an array length
        double[] multiples = new double[length];

        // step 2: Use a loop to calculate the ultiples of number
        for (int i = 0; i < length; i++)
        {
            // The value in such as index will be the number multiplyed by  (i + 1)
            multiples[i] = number * (i + 1);
        }

        // step 3: Return the array withthe multiples calculated
        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
   {
    // Step 1: Calculate the efectives rotations 
    int rotations = amount % data.Count;

    // Step 2: Extract the last `rotations` elements..
    List<int> temp = data.GetRange(data.Count - rotations, rotations);

    // Step 3: Remove the last `rotations` elements to the original list.
    data.RemoveRange(data.Count - rotations, rotations);

    // Step 4: Insert the extracted elements at the beginning of the original list.
    data.InsertRange(0, temp);
   }
}
