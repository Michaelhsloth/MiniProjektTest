namespace ordination_test;

using shared.Model;
using static shared.Util;

[TestClass]
public class OrdinationLaegemiddelTest
{
    [TestMethod]
    public void DagligFastRigtigLaegeMiddel()
    {
        Laegemiddel laegemiddler = new Laegemiddel();

        laegemiddler = new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml");

        DateTime startDato = new DateTime(2021, 1, 10);
        DateTime slutDato = new DateTime(2021, 1, 12);
        Laegemiddel laegemiddel = laegemiddler;
        double morgen = 2;
        double middag = 0;
        double aften = 1;
        double nat = 0;
        DagligFast dagligFast = new DagligFast(
            startDato,
            slutDato,
            laegemiddel,
            morgen,
            middag,
            aften,
            nat
        );

        Assert.AreEqual(laegemiddler, dagligFast.laegemiddel);
    }

    [TestMethod]
    public void DagligSkævRigtigLaegeMiddel()
    {
        Laegemiddel laegemiddler = new Laegemiddel();

        laegemiddler = new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml");
        Dosis[] dosis = new Dosis[4];
        dosis[0] = new Dosis(CreateTimeOnly(15, 0, 0), 7);
        dosis[1] = new Dosis(CreateTimeOnly(18, 0, 0), 9);
        dosis[2] = new Dosis(CreateTimeOnly(22, 0, 0), 3);
        dosis[3] = new Dosis(CreateTimeOnly(23, 0, 0), 1);

        DateTime startDato = new DateTime(2021, 1, 10);
        DateTime slutDato = new DateTime(2021, 1, 12);
        Laegemiddel laegemiddel = laegemiddler;

        DagligSkæv dagligSkæv = new DagligSkæv(startDato, slutDato, laegemiddel, dosis);

        Assert.AreEqual(laegemiddler, dagligSkæv.laegemiddel);
    }

    [TestMethod]
    public void DagligPNRigtigLaegeMiddel()
    {
        Laegemiddel laegemiddler = new Laegemiddel();

        laegemiddler = new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml");

        DateTime startDato = new DateTime(2021, 1, 10);
        DateTime slutDato = new DateTime(2021, 1, 12);
        double antal = 2;
        Laegemiddel laegemiddel = laegemiddler;

        PN dagligPN = new PN(startDato, slutDato, antal, laegemiddel);

        Assert.AreEqual(laegemiddler, dagligPN.laegemiddel);
    }

    [TestMethod]
    public void EnhedVægtTjekLet()
    {
        Laegemiddel laegemiddler = new Laegemiddel();

        laegemiddler = new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml");

        double enhedPrKg;
        double vægt = 25;

        if (vægt < 25)
        {
            enhedPrKg = laegemiddler.enhedPrKgPrDoegnLet;
        }
        else if (vægt <= 120)
        {
            enhedPrKg = laegemiddler.enhedPrKgPrDoegnNormal;
        }
        else
        {
            enhedPrKg = laegemiddler.enhedPrKgPrDoegnTung;
        }

        Assert.AreEqual(enhedPrKg, laegemiddler.enhedPrKgPrDoegnLet);
    }
}
