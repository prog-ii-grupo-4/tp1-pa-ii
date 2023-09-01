using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_pa_ii;

namespace TP1_tests
{
    [TestClass]
    public class ConversionesTest
    {
        [TestMethod]
        public void TestPunto3()
        {
            string resultado = Conversiones.InformarColor(Colores.Azul);
            string resultadoEsperado = "Color azul";

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestPunto4y5()
        {
            int a = 20;

            string resultado = Conversiones.EvaluarMayorA10(a);
            string resultadoEsperado = "El valor de a es mayor a 10";
            
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestPunto7()
        {
            int resultado = Conversiones.SentenciaWhile();
            bool resultadoEsperado = true;

            Assert.AreEqual(resultadoEsperado, resultado > 50);
        }
    }
}
