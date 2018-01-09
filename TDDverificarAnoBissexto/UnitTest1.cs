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

        /*testes para anos bissextos*/

        [TestMethod]
        public void QuandoAnoFor2000DevolveAno2000eBisssexto()
        {
            String anoTeste = "2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
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
        public void QuandoAnoFor000000DevolveAno000000eBisssexto()
        {
            String anoTeste = "000000";
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
        public void QuandoAnoFor0DevolveAno0eBisssexto()
        {
            String anoTeste = "0";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        /*anos oferecidos na descrição do teste que são bissextos
         * 1600
         * 1732
         * 1888
         * 1944
         * 2008
         */
        [TestMethod]
        public void QuandoAnoFor1600DevolveAno1600eBisssexto()
        {
            String anoTeste = "1600";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor1888DevolveAno1888eBisssexto()
        {
            String anoTeste = "1888";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }


        [TestMethod]
        public void QuandoAnoFor1732DevolveAno1732eBisssexto()
        {
            String anoTeste = "1732";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor1944DevolveAno1944eBisssexto()
        {
            String anoTeste = "1944";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor2008DevolveAno2008eBisssexto()
        {
            String anoTeste = "1944";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " é Bissexto", resultado);
        }

        /*Testes para anos não bissextos*/

        [TestMethod]
        public void QuandoAnoFor1000DevolveAno1000naoeBisssexto()
        {
            String anoTeste = "1000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor2015DevolveAno2015naoeBisssexto()
        {
            String anoTeste = "2015";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }


        /*anos oferecidos na descrição do teste que não são bissextos
         * 1742
         * 1889
         * 1951
         * 2011
         */
        [TestMethod]
        public void QuandoAnoFor1742DevolveAno1742naoeBisssexto()
        {
            String anoTeste = "1742";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor1889DevolveAno1889naoeBisssexto()
        {
            String anoTeste = "1889";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor1951DevolveAno1951naoeBisssexto()
        {
            String anoTeste = "1951";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor2011DevolveAno2011naoeBisssexto()
        {
            String anoTeste = "2011";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano " + anoTeste + " não é Bissexto", resultado);
        }

        /*Teste para entrada de anos inválidas*/
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
        public void QuandoAnoForMais2000DevolveAnoInvalido()
        {
            String anoTeste = "+2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoForMenos2000DevolveAnoInvalido()
        {
            String anoTeste = "-2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]//estouro na conversão de inteiro
        public void QuandoAnoFor300000000000DevolveAnoInvalido()
        {
            String anoTeste = "300000000000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }        

        [TestMethod]
        public void QuandoAnoForAsterisco2000DevolveAnoInvalido()
        {
            String anoTeste = "*2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }

        [TestMethod]
        public void QuandoAnoFor2000Barra2000DevolveAnoInvalido()
        {
            String anoTeste = "2000/2000";
            Ano ano = new Ano();
            String resultado = ano.VerificarAnoBissexto(anoTeste);
            Assert.AreEqual("Ano Invalido", resultado);
        }
        


    }
}
