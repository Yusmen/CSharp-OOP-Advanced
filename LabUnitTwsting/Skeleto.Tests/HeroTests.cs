﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void HeroGainXP()
        {

            /*IWeapon fakeWeapon = new FakeWeapon();
            ITarget fakeTarget = new FakeTarget();

            Hero hero = new Hero(fakeWeapon, "Pesho");

            hero.Attack(fakeTarget);

            var actualResult = hero.Experience;
            var expectedResult = 10;

            Assert.AreEqual(actualResult, expectedResult);*/

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Mock<ITarget> fakeTarget = new Mock<ITarget>();

            fakeWeapon.Setup(x => x.AttackPoints).Returns(10);
            fakeWeapon.Setup(x => x.DurabilityPoints).Returns(15);

            fakeTarget.Setup(x => x.Health).Returns(0);
            fakeTarget.Setup(x => x.GiveExperience()).Returns(10);
            fakeTarget.Setup(x => x.IsDead()).Returns(true);

            Hero hero = new Hero(fakeWeapon.Object, "Gosho");

            hero.Attack(fakeTarget.Object);

            var actualResult = hero.Experience;
            var expectedResult = 10;

            Assert.AreEqual(actualResult, expectedResult);





        }

    }
}
