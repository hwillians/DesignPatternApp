using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Business.Tests
{
    [TestClass()]
    public class EmployeServiceTests
    {
        [TestMethod()]
        public void GetListEmployesTest()
        {
            var entrepriseService = new EmployeService(new MockStorage());
            var employes = entrepriseService.GetListEmployes();
            Assert.AreEqual(employes.Count, 2);

        }

    }
}