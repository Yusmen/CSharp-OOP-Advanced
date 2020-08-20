using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfTttacked()
        {
            Dummy dummy = new Dummy(10, 10);

            dummy.TakeAttack(5);

            Assert.That(dummy.Health == 5);
        }

        [Test]
        public void DeadDummyThrowExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0, 100);


            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));

        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(0, 100);


            var expectedResult = 100;
            var actualResult = dummy.GiveExperience();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void  AliveDummyCantGiveXP()
        {

            Dummy dummy = new Dummy(10, 100);
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

        }



    }
}
