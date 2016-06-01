using System;
using NUnit.Framework;

namespace Evo2.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestSumaIgual()
        {
            Class1 clase = new Class1();
            const int sum1 = 3;
            const int sum2 = 2;
            const int esperado = 5;

            var actual = clase.Suma(sum1, sum2);

            Assert.AreEqual(esperado, actual);
        }
        [TestCase]
        public void TestRestaIgual()
        {
            Class1 clase = new Class1();
            const int res1 = 6, res2 = 2;
            const int esperado = 5;

            var actual = clase.Resta(res1, res2);

            Assert.AreNotEqual(esperado, actual);
        }

        [TestCase]
        public void TestBoolExiste()
        {
            Class1 clase = new Class1();
            const int numero = 2;

            Assert.IsTrue(clase.Existe(numero), "Es verdadero");
        }


        [TestCase]
        public void TestString()
        {
            Class1 clase = new Class1();
            string p = "hola";
            Assert.AreEqual(p, clase.Palabra());
        }
        [TestCase]
        public void TestStringMoIgual()
        {
            Class1 clase = new Class1();
            string p = "hola mundo";
            Assert.AreNotEqual(p, clase.Palabra());
        }

        [TestCase]
        public void TestISNOTNULL()
        {
            Class1 clase = new Class1();

            Assert.IsNotNull(clase.RetornaLista());
        }
    }
}
