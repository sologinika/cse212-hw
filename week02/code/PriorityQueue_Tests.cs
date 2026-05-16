using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities:
    // A (1), B (3), C (2)
    // Expected Result:  Dequeue returns B first because it has highest priority.
    // Defect(s) Found:  Dequeue did not correctly identify the highest priority item.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: Add three items with same priority:
    // A (2), B (2), C (2)
    // Expected Result:  Dequeue returns A first (FIFO for same priority).
    // Defect(s) Found: Queue failed FIFO ordering when priorities were equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
          priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.
     [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: Incorrect or missing exception handling for empty queue.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    [TestMethod]
    // Scenario: Add multiple items and remove all.
    // Expected Result: Items removed in priority order:
    // B, C, A
    // Defect(s) Found: Queue ordering incorrect after multiple dequeues.
    public void TestPriorityQueue_MultipleDequeues()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

}