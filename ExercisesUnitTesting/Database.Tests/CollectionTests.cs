using Database;
using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private const int ArraySize = 16;
        private const int InitialArrayIndex = -1;

        [Test]
        public void EmptyConstructorShouldInitData()
        {
            CustomStack customStack = new CustomStack();

            Type type = typeof(CustomStack);

            var field = (int[])type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "collection")
                .GetValue(customStack);

            var length = field.Length;
            Assert.That(length, Is.EqualTo(ArraySize));
        }

        [Test]
        public void EmptyConstructorShouldInitIndexToMinusOne()
        {
            CustomStack customStack = new CustomStack();

            Type type = typeof(CustomStack);

            var indexValue = (int)type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(customStack);


            Assert.That(indexValue, Is.EqualTo(InitialArrayIndex));
        }
        [Test]

        public void CtorShouldThrowInvalidOperationException
            ()
        {

            int[] arr = new int[17];

            Assert.Throws<InvalidOperationException>(() => new CustomStack(arr));

        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 13 })]
        [TestCase(new int[] { 13, 42, 69 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void CtorShouldSetIndexCorrectly(int[] values)
        {

            CustomStack customStack = new CustomStack(values);

            int expectedIndex = values.Length - 1;
            Type type = typeof(CustomStack);

            var indexValue = (int)type
               .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
               .First(f => f.Name == "index")
               .GetValue(customStack);

            Assert.That(indexValue, Is.EqualTo(expectedIndex));
        }
        /*
        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15 })]
        public void AddShouldIncreaseIndexCorrectly(int[] values)
        {
            CustomStack customStack = new CustomStack(values);
            Type type = typeof(CustomStack);

            customStack.Add(16);

            int indexValue = (int)type
               .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
               .First(f => f.Name == "index")
               .GetValue(customStack);

            int expectedIndex = values.Length;

            Assert.That(indexValue, Is.EqualTo(expectedIndex));
        }
        */
        [Test]
        public void AddWhenDatabaseIsFullShouldThrow()
        {
            int[] arr = new int[16];

            CustomStack customStack = new CustomStack(arr);

            Assert.Throws<InvalidOperationException>(() => customStack.Add(1));
        }
        [Test]
        public void RemoveShouldIncreaseIndex()
        {
            int[] arr = new int[10];
            CustomStack customStack = new CustomStack(arr);

            Type type = typeof(CustomStack);


            customStack.Remove();
            int index = (int)type
               .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
               .First(f => f.Name == "index")
               .GetValue(customStack);

            
            int expectedResult = arr.Length - 2;


            Assert.That(index, Is.EqualTo(expectedResult));


        }
        [Test]
        public void RemoveFromEmptyDatabaseShouldThrowException()
        {
            CustomStack customStack = new CustomStack();

            Assert.Throws<InvalidOperationException>(() => customStack.Remove());
        }

    }
}