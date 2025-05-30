using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them
    // Expected Result: Dequeue returns the item with the highest priority
    // Defect(s) Found:
    public void TestPriorityQueue_DequeueHighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result, "Should return the item with the highest priority (5)");
    }

    [TestMethod]
    // Scenario: Enqueue items with same priority, dequeue returns first inserted
    // Expected Result: Dequeue returns the first inserted item with the highest priority
    // Defect(s) Found: Error Message: Assert.AreEqual failed. Expected:<A>. Actual:<B>. Should return the first inserted item with the highest priority
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual(
            "A",
            result,
            "Should return the first inserted item with the highest priority"
        );
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Throws InvalidOperationException
    // Defect(s) Found:
    public void TestPriorityQueue_EmptyDequeueThrows()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue and dequeue all items
    // Expected Result: All items are dequeued in order of priority
    // Defect(s) Found:  Error Message: Assert.AreEqual failed. Expected:<C>. Actual:<B>. 
    public void TestPriorityQueue_DequeueAll()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }
}
