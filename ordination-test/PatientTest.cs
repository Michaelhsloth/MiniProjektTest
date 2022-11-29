namespace ordination_test;

using shared.Model;

[TestClass]
public class PatientTest
{
    [TestMethod]
    public void PatientHasCPR()
    {
        string cpr = "160563-1234";
        string navn = "John";
        double vægt = 83;

        Patient patient = new Patient(cpr, navn, vægt);
        Assert.AreEqual(cpr, patient.cprnr);
    }

    [TestMethod]
    public void PatientForkertCPR()
    {
        string cpr = "160563-1234";
        string navn = "John";
        double vægt = 83;

        Patient patient = new Patient(cpr, navn, vægt);
        Assert.AreNotEqual("150855-4321", patient.cprnr);
    }

    [TestMethod]
    public void PatientHasName()
    {
        string cpr = "160563-1234";
        string navn = "John";
        double vægt = 83;

        Patient patient = new Patient(cpr, navn, vægt);
        Assert.AreEqual(navn, patient.navn);
    }
}
