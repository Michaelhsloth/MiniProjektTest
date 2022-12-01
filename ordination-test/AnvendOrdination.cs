namespace ordination_test;

using shared.Model;
using static shared.Util;

[TestClass]
public class AnvendOrdination
{
    [TestMethod]
    public void TestAnvend()
    {
        Laegemiddel laegemiddler = new Laegemiddel();

        laegemiddler = new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml");

        DateTime startDato = new DateTime(2022, 12, 3);
        DateTime slutDato = new DateTime(2022, 12, 5);
        double antal = 2;
        Laegemiddel laegemiddel = laegemiddler;

        DateTime anvendtDato = new DateTime(2022, 12, 4);

        PN pn = new PN(startDato, slutDato, antal, laegemiddel);

        if (anvendtDato >= pn.startDen && anvendtDato <= pn.slutDen)
        {
            Assert.IsTrue(true);
        }
        else
        {
            Assert.IsTrue(false);
        }
    }
}
