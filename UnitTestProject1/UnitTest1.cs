using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.Prestaciones;

namespace UnitTestProject1
{
    [TestClass]
    public class PrestacionesTests
    {
        [TestMethod]
        public void canGetYear()
        {
            string inicio = "2008-06-20";
            string final = "2017-06-19";
            decimal salario = 22500;

            var prestaciones = new Prestaciones(inicio, final, salario);

            Assert.AreEqual(9, prestaciones.getYears());
            
        }

        [TestMethod]
        public void canGetDays()
        {
            string inicio = "2008-06-20";
            string final = "2017-05-20";
            decimal salario = 22500;

            var prestaciones = new Prestaciones(inicio, final, salario);

            Assert.AreEqual(0, prestaciones.getDays());
        }

        [TestMethod]
        public void canGetMothsNumber()
        {
            string inicio = "2008-06-20";
            string final = "2017-07-20";
            decimal salario = 22500;

            var prestaciones = new Prestaciones(inicio, final, salario);
        }
    }
}
