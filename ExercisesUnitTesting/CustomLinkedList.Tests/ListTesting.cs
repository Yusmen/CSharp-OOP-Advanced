using CustomLinkedList;
using NUnit.Framework;
using System;

namespace Tests
{

    [TestFixture]
    public class Tests
    {
        private const int initialCount = 0;

        [Test]
        public void CtorShouldSetCountToZero()
        {
            DynamicList<int> list = new DynamicList<int>();


            Assert.AreEqual(list.Count, initialCount);

        }

        [Test]
        public void IndexOperatorShouldReturnValue()
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(13);

            int element = list[0];

            Assert.AreEqual(element, 13);
        }

        [Test]
        public void IndexOperatorShouldSetValue()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(13);

            list[0] = 42;

            Assert.AreEqual(list[0], 42);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]

        public void IndexOpertaorShouldThrowExceptionWhengwttingInvalidIndex
            (int index)
        {
            DynamicList<int> list = new DynamicList<int>();


            for (int i = 0; i < list.Count; i++)
            {
                list.Add(i);
            }

            int result = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => result = list[index]);

        }
        [Test]
        [TestCase(-1)]
        [TestCase(int.MaxValue)]
        public void IndexOpertaorShouldThrowExceptionWhenSettingInvalidIndex
            (int index)
        {
            DynamicList<int> list = new DynamicList<int>();
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(i);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => list[index] = 68, "Index had to be valid");

        }
        [Test]
        public void ContainsReturnsTrueValue()
        {
            DynamicList<long> list = new DynamicList<long>();

            list.Add(1415);

            Assert.IsTrue(list.Contains(1415) == true);
        }
        [Test]
        public void IndexOfRetunrnsCorrectValue()
        {
            DynamicList<long> list = new DynamicList<long>();
            list.Add(1415);

            Assert.That(list.IndexOf(1415), Is.EqualTo(0));

        }
        public void RemoveAtReturnscorrectValue()
        {
            DynamicList<long> list = new DynamicList<long>();
            list.Add(1415);

            Assert.That(list.RemoveAt(0), Is.EqualTo(1415));
        }

        

    }
}