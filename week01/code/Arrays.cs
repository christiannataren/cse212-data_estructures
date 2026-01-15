using System.Reflection;

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

        //Start creating a list where the results will be saved
        //Loop as much times as indicated by the lenght + 1 and starting  the loopCounter from 1 and incrementing the loopcount by 1
        //Add the result of the operation (number * loopCounter) in the list
        ///After looping return the list as array

        List<double> multi = new List<double>();
        for (int i = 1; i < length + 1; i++)
        {
            multi.Add(number * i);
        }

        return multi.ToArray(); // replace this return statement with your own
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

        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Start looping by the amount of numbers will be moving
        //Save in a variable the last number, it alway be the total of the data size - 1
        /// Make a copy of the data
        ///Save the last number in the index 0 of the data
        /// Loop the copy starting  on 0 and finishing when the loopCounter is less than the size - 1
        /// Save each index of the copy in the data file using as index the loopCounter + 1

        for (int i = 0; i < amount; i++)
        {
            int loss = data[data.Count - 1];
            int[] copy = data.ToArray();
            data[0] = loss;
            for (int e = 0; e < copy.Length - 1; e++)
            {
                data[e + 1] = copy[e];
            }
        }
    }
}
