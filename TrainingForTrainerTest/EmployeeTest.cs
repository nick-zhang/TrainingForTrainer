using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingForTrainer;

namespace TrainingForTrainerTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void ShouldGetEngineerPayment()
        {
            var engineer = new Employee(3000, 0, 0, new Engineer());
            Assert.AreEqual(3000, engineer.Payment());
        }
       
        [TestMethod]
        public void ShouldGetSalesmanPaymentWithCommission()
        {
            var salesman = new Employee(3000, 100, 0, new Salesman());
            Assert.AreEqual(3000 + 100, salesman.Payment());
        }
        
        [TestMethod]
        public void ShouldGetManagerPaymentWithBonus()
        {
            var salesman = new Employee(3000, 0, 200, new Manager());
            Assert.AreEqual(3000 + 200, salesman.Payment());
        }
    }
}
