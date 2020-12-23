using NUnit.Framework;
using System;
using coolOrange_CandidateChallenge;

namespace coolOrange_CandidateChallengeTest
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        [TestCase("MED_PRIORITY", 58, 1)]
        [TestCase("MIN_PRIORITY", 100, 1)]
        [TestCase("MAX_PRIORITY", 2, 0)]
        [TestCase("LOW_PRIORITY", 4, -1)]
        public void CompareTo_Calls_IComparable_Compares_Priority_Of_Tasks_Returns_Int32(string priority, int complexity, int expectedResult)
        {
            var task = new Task("TestTask");
            task.SetPriority(priority);
            task.SetComplexity(complexity);

            var taskComp = new Task("CompareTask");
            taskComp.SetPriority("MAX_PRIORITY");

            var result = task.CompareTo(
                taskComp);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(6)]
        public void GetComplexity_Calls_IComplexity_Returns_Complexity(int complexity)
        {
            var task = new Task("TestTask");
            var task2 = new Task("TestTask2");

            task.SetComplexity(6);
            task2.SetComplexity(11);

            var result = task.GetComplexity();
            var result2 = task2.GetComplexity();

            Assert.AreEqual(complexity, result);
            Assert.AreNotEqual(complexity, result2);
        }

        [Test]
        [TestCase(5)]
        public void GetPriority_Calls_IPriority_Returns_Priority(int priority)
        {
            var task = new Task("TestTask");
            var task2 = new Task("TestTask2");

            task2.SetPriority("MIN_PRIORITY");

            var result = task.GetPriority();
            var result2 = task2.GetPriority();

            Assert.AreEqual(priority, result);
            Assert.AreNotEqual(priority, result2);
        }

        [Test]
        [TestCase(13)]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(58)]
        [TestCase(-3)]
        [TestCase(77)]
        public void SetComplexity_Calls_IComplexity_Sets_Complexity(int complexity)
        {
            var task = new Task("TestTask");

            task.SetComplexity(complexity);

            var result = task.GetComplexity();

            Assert.IsNotNull(result);
            Assert.AreEqual(complexity, result);
        }

        [Test]
        [TestCase("MAX_PRIORITY", 10)]
        [TestCase("LOW_PRIORITY", 5)]
        [TestCase("MID_PRIORITY", 5)]
        [TestCase("MED_PRIORITY", 5)]
        [TestCase("MIN_PRIORITY", 1)]
        public void SetPriority_Calls_IPriority_Sets_Priority(string priority, int expected)
        {
            var task = new Task("TestTask");
            string level = priority;

            task.SetPriority(
                level);

            var result = task.GetPriority();

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }
    }
}
