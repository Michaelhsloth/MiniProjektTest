namespace ordination_test;

using shared.Model;



[TestClass]

public class OrdinationLaegemiddelsEnhedsTest
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
        DagligFast dagligFast = new DagligFast(startDato, slutDato, laegemiddel, morgen, middag, aften, nat);

        Assert.AreEqual(laegemiddler, dagligFast.laegemiddel);
    }

}