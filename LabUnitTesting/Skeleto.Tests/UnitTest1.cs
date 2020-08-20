using NUnit.Framework;
using System;
namespace Tests
{
    public class Tests
    {
        

        [Test]
        public void TestIfWeaponLosesDurabilityAfterEachAttac()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(axe.DurabilityPoints, 9);
        }

        [Test]
        public void AttackingWithBrokenWeapon()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));


            Assert.Throws(typeof(InvalidOperationException), () => axe.Attack(dummy));
            
        }


    }
}