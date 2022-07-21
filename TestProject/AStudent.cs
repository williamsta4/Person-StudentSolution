using ClassLibrary;
namespace TestProject;

[TestClass]
public class AStudent
{
    [TestMethod]
    public void IsTheInternshipInAnInternship()
    {
        var sut = new Student();
        var internship = new Internship(sut);
        Assert.AreEqual(sut, internship.Intern);
        Assert.AreEqual(sut.Internship, internship);
    }
}
