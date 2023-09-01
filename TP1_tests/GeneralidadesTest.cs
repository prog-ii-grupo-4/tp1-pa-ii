using TP1_pa_ii;

namespace TP1_tests
{
    [TestClass]
    public class GeneralidadesTest
    {
        [TestMethod]
        public void TestPunto1()
        {
            int primerNumero = 8;
            int segundoNumero = 10;

            int resultado = Generalidades.Sumar(primerNumero, segundoNumero);
            int resultadoEsperado = 18;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestPunto2()
        {
            string palabra = "acertado";
            
            string resultado = Generalidades.CortarString(palabra);
            string resultadoEsperado = "acer";

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestDiaDeLaSemana()
        {
            DiasDeLaSemana dia = DiasDeLaSemana.Viernes;

            Assert.AreEqual("Viernes", Generalidades.MostrarDiaDeLaSemana(dia));
        }
    }
}