﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        [Ignore]
        public void Take()
        {
            //O operador Take é usado para selecionar os primeiros objetos da colecao
            int[] numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var resultado = from num in numeros.Take(5) select num;

            int[] teste = {5, 4, 1, 3, 9};

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        [TestMethod]
        public void Skip()
        {
            //O operador skip ignora os primeiros n objetos de uma coleção

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9};

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
    }
}
