using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDAno
{
    [TestClass]
    public class TesteVerificarAnoBissexto
    {
        [TestMethod]
        public void QuandoNaoChamadoDevolveNada()
        {
        }

        [TestMethod]
        public void QuandoAnoFor2000DevolveAno2000eBisssexto()
        {
            String anoTeste = "2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor1000DevolveAno1000naoeBisssexto()
        {
            String anoTeste = "1000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoForTextoDevolveAnoInvalido()
        {
            String anoTeste = "Texto";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor20Dot12DevolveAnoInvalido()
        {
            String anoTeste = "20.12";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor20Virgula12DevolveAnoInvalido()
        {
            String anoTeste = "20,12";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoForMais2000Invalido()
        {
            String anoTeste = "+2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoFOrMenos2000Invalido()
        {
            String anoTeste = "-2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor3000000DevolveAno3000000eBisssexto()
        {
            String anoTeste = "3000000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor2016DevolveAno2016eBisssexto()
        {
            String anoTeste = "2016";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor2015DevolveAno2015naoeBisssexto()
        {
            String anoTeste = "2015";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor0DevolveAno0eBisssexto()
        {
            String anoTeste = "0";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]//estouro na conversão de inteiro
        public void QuandoAnoFor300000000000DevolveAno300000000000eBisssexto()
        {
            String anoTeste = "300000000000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor000000DevolveAno000000eBisssexto()
        {
            String anoTeste = "000000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoForAsterisco2000DevolveAnoeBisssexto()
        {
            String anoTeste = "*2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor2000Barra2000DevolveAnoeBisssexto()
        {
            String anoTeste = "2000/2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }


    }
}
