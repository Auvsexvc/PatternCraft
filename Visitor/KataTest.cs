using NUnit.Framework;
using Visitor;

[TestFixture]
public class KataTest
{
    private Random random = new Random();

    [Test]
    public void _0_VisitLight()
    {
        IVisitor bullet = new TankBullet();
        ILightUnit light = new Marine();

        light.Accept(bullet);

        Assert.AreEqual(100 - 21, light.Health);
    }

    [Test]
    public void _1_VisitArmored()
    {
        IVisitor bullet = new TankBullet();
        IArmoredUnit armored = new Marauder();

        armored.Accept(bullet);

        Assert.AreEqual(125 - 32, armored.Health);
    }

    [Test]
    public void _2_RandomTests()
    {
        for (int n = 0; n < 10; n++)
        {
            IVisitor bullet = new TankBullet();
            ILightUnit light = new Marine();
            IArmoredUnit armored = new Marauder();

            var lHealth = light.Health;
            var aHealth = armored.Health;

            for (int i = 0; i < 10; i++)
            {
                if (random.NextDouble() <= 0.5)
                {
                    light.Accept(bullet);
                    armored.Accept(bullet);

                    lHealth -= 21;
                    aHealth -= 32;
                }

                Assert.AreEqual(lHealth, light.Health);
                Assert.AreEqual(aHealth, armored.Health);
            }
        }
    }
}