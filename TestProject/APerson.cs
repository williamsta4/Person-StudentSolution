using ClassLibrary;

namespace TestProject
{
    [TestClass]
    public class APerson
    {
        [TestMethod]
        public void CanShareAnAddressWithAnotherPerson()
        {
            Address address = new Address { Street = "101 Any Street", City = "Any City", State = "TN", ZipCode = "37614" };
            var sut = new Person { Address = address };
            var another = new Person();
            another.Address = sut.Address;
            another.Address.Street = "200 Other Street";
            Assert.AreEqual(sut.Address, another.Address);
        }
    }
}