using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaNotas1._2;

namespace PruebaNotaTest1._2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            /*double mediaesperada = 5.143;
            int suspensoEsperado = 3;
            int aprobadoEsperado = 1;
            int notableEsperado = 2;
            int sobresalienteEsperado = 1;
            */
        }

        [TestMethod]
        public void Test1()
        {
            int listaNota = 0;
            int suspensoEsperado = 3;
            _ = new List<int>();

            try
            {
                listaNota.CompareTo(suspensoEsperado);
            }

            catch
            {
                throw new Exception("Error, la lista no contiene elementos");
            }
        }


        [TestMethod]
        public void Test2()
        {
            int suspensoActual = 3;
            int suspensoEsperado = 3;
            _ = new EstadisticasNotas();

            Assert.AreEqual(suspensoActual, suspensoEsperado);
        }


        [TestMethod]
        public void Test3()
        {
            int aprobadoActual = 4;
            int aprobadoEsperado = 1;
            _ = new EstadisticasNotas();

            Assert.AreNotEqual(aprobadoActual, aprobadoEsperado);
        }



        [TestMethod]
        public void Test4()
        {
            int notableActual = 2;
            int notableEsperado = 2;
            _ = new EstadisticasNotas();

            Assert.AreEqual(notableActual, notableEsperado);

        }


        [TestMethod]
        public void Test5()
        {
            int sobresalienteActual = 5;
            int sobresalienteEsperado = 1;
            _ = new EstadisticasNotas();

            Assert.AreNotEqual(sobresalienteActual, sobresalienteEsperado);
            
        }


    }
}
