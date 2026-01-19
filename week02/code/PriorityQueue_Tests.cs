using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Normal items with diferent priorities
    // Expected Result: [purple, blue, orange, red]
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        /////red 1, blue 4 orange 2 purple 6
        PriorityItem red = new PriorityItem("red", 1);
        PriorityItem blue = new PriorityItem("blue", 4);
        PriorityItem orange = new PriorityItem("orange", 2);
        PriorityItem purple = new PriorityItem("purple", 6);
        PriorityItem[] expectedResult = [purple, blue, orange, red];
        priorityQueue.Enqueue(red.Value, red.Priority);
        priorityQueue.Enqueue(blue.Value, blue.Priority);
        priorityQueue.Enqueue(orange.Value, orange.Priority);
        priorityQueue.Enqueue(purple.Value, purple.Priority);
        int i = 0;
        while (priorityQueue.Size() > 0)
        {

            // Console.WriteLine($"Expected: {expectedResult[i].Value} Got: {priorityQueue.Dequeue()}");
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
            i++;
        }
    }

    [TestMethod]
    // Scenario: Adding two items with the same priority
    // Expected Result: [purple, blue, orange, red, white]
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        /////red 1, blue 4 orange 2 purple 6
        PriorityItem red = new PriorityItem("red", 1);
        PriorityItem blue = new PriorityItem("blue", 4);
        PriorityItem orange = new PriorityItem("orange", 2);
        PriorityItem purple = new PriorityItem("purple", 6);
        PriorityItem white = new PriorityItem("white", 1);
        PriorityItem[] expectedResult = [purple, blue, orange, red, white];
        priorityQueue.Enqueue(red.Value, red.Priority);
        priorityQueue.Enqueue(blue.Value, blue.Priority);
        priorityQueue.Enqueue(orange.Value, orange.Priority);
        priorityQueue.Enqueue(purple.Value, purple.Priority);
        priorityQueue.Enqueue(white.Value, white.Priority);
        int i = 0;
        while (priorityQueue.Size() > 0)
        {

            // Console.WriteLine($"Expected: {expectedResult[i].Value} Got: {priorityQueue.Dequeue()}");
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
            i++;
        }
    }

    [TestMethod]
    // Scenario: Adding items with priority 0
    // Expected Result: [purple, blue, orange, red, white]
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        /////red 1, blue 4 orange 2 purple 6
        PriorityItem red = new PriorityItem("red", 1);
        PriorityItem blue = new PriorityItem("blue", 4);
        PriorityItem orange = new PriorityItem("orange", 2);
        PriorityItem purple = new PriorityItem("purple", 6);
        PriorityItem white = new PriorityItem("white", 0);
        PriorityItem[] expectedResult = [purple, blue, orange, red, white];
        priorityQueue.Enqueue(red.Value, red.Priority);
        priorityQueue.Enqueue(blue.Value, blue.Priority);
        priorityQueue.Enqueue(orange.Value, orange.Priority);
        priorityQueue.Enqueue(purple.Value, purple.Priority);
        priorityQueue.Enqueue(white.Value, white.Priority);
        int i = 0;
        while (priorityQueue.Size() > 0)
        {

            // Console.WriteLine($"Expected: {expectedResult[i].Value} Got: {priorityQueue.Dequeue()}");
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
            i++;
        }
    }
    [TestMethod]
    // Scenario: Adding  items with priority negative
    // Expected Result: [purple, blue, orange, white,red]
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        /////red 1, blue 4 orange 2 purple 6
        PriorityItem red = new PriorityItem("red", -1);
        PriorityItem blue = new PriorityItem("blue", 4);
        PriorityItem orange = new PriorityItem("orange", 2);
        PriorityItem purple = new PriorityItem("purple", 6);
        PriorityItem white = new PriorityItem("white", 0);
        PriorityItem[] expectedResult = [purple, blue, orange, white, red];
        priorityQueue.Enqueue(white.Value, white.Priority);
        priorityQueue.Enqueue(red.Value, red.Priority);
        priorityQueue.Enqueue(blue.Value, blue.Priority);
        priorityQueue.Enqueue(orange.Value, orange.Priority);
        priorityQueue.Enqueue(purple.Value, purple.Priority);
        
        int i = 0;
        while (priorityQueue.Size() > 0)
        {

            // Console.WriteLine($"Expected: {expectedResult[i].Value} Got: {priorityQueue.Dequeue()}");
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
            i++;
        }
    }

    // Add more test cases as needed below.
}