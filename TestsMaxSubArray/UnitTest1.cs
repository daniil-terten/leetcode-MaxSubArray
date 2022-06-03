using MaxSubArray;
using NUnit.Framework;

namespace TestsMaxSubArray
{
    public class Tests
    {
        MaxSubArrayApp _maxSubArray;

        [SetUp]
        public void Setup()
        {
            _maxSubArray = new MaxSubArrayApp();
        }

        [Test]
        public void Test1()
        {
            var nums = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var expectedArrayValues = new[] { 4, -1, 2, 1 };
            var expectedValue = 6;
            var result = _maxSubArray.MaxSubArray(nums);
            Assert.AreEqual(expectedValue, result.Item1);
            CollectionAssert.AreEqual(expectedArrayValues, result.Item2.ToArray());
        }

        [Test]
        public void Test2()
        {
            var nums = new[] { 1 };
            var expectedArrayValues = new[] { 1 };
            var expectedValue = 1;
            var result = _maxSubArray.MaxSubArray(nums);
            Assert.AreEqual(expectedValue, result.Item1);
            CollectionAssert.AreEqual(expectedArrayValues, result.Item2.ToArray());
        }

        [Test]
        public void Test3()
        {
            var nums = new[] { 5, 4, -1, 7, 8 };
            var expectedArrayValues = new[] { 5, 4, -1, 7, 8 };
            var expectedValue = 23;
            var result = _maxSubArray.MaxSubArray(nums);
            Assert.AreEqual(expectedValue, result.Item1);
            CollectionAssert.AreEqual(expectedArrayValues, result.Item2.ToArray());
        }
    }
}