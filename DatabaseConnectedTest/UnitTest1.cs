using System;
using System.Collections.Generic;
using DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace DatabaseConnectTest
{
    [TestClass]
    public class UnitTest1
    {
        private RestaurantDAO _restaurantDAO = RestaurantDAO.GetInstance();
        [TestMethod]
        public void TestConexiuneBD()
        {
            _restaurantDAO = RestaurantDAO.GetInstance();

        }

        [TestMethod]

        public void TestAddMasaTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.AddMasa(new Masa(7, 2, StatusEnum.Liber)));
        }

        [TestMethod]
        public void TestRemoveMasaTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.RemoveMasa(9));
        }

        [TestMethod]

        public void TestAddMasaFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.AddMasa(new Masa(1, 2, StatusEnum.Liber)));
        }

        [TestMethod]

        public void TestRemoveMasaFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.RemoveMasa(0));
        }

        [TestMethod]

        public void TestUpdateMasaTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.UpdateMasa(new Masa(3, 2, StatusEnum.Liber)));
        }

        [TestMethod]

        public void TestUpdateMasaFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.UpdateMasa(new Masa(1, -2, StatusEnum.Liber)));
        }
        [TestMethod]
        //de testat pe alt laptop
        public void TestAddComandaTrue()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["Diavolo"] = 1;
            dict["Sprite"] = 1;

            Assert.AreEqual(true, _restaurantDAO.AddComanda(new Comanda(99, Convert.ToDateTime("3.4.2020"), 1, 5,
             dict)));
        }

        [TestMethod]
        public void TestRemmoveComandaTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.RemoveComanda(99));
        }

        [TestMethod]//de testat!
        public void TestAddComandaFalse()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["Diavolo"] = 1;
            dict["Sprite"] = 1;

            Assert.AreEqual(false, _restaurantDAO.AddComanda(new Comanda(1, Convert.ToDateTime("3.4.2020"), 1, 1,
             dict)));
        }

        [TestMethod]
        public void TestRemmoveComandaFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.RemoveComanda(-100));
        }

        [TestMethod]

        public void TestAddProdusTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.AddProdus(new Produs("Tzuica", 100, 300, Masura.Litru, 7)));
        }

        [TestMethod]
        public void TestRemoveProdusTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.RemoveProdus("Tzuica"));
        }
        [TestMethod]

        public void TestAddProdusFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.AddProdus(new Produs("Sprite", 100, 300, Masura.Litru, 7)));
        }

        [TestMethod]
        public void TestRemoveProdusFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.RemoveProdus(null));
        }

        [TestMethod]
        public void TestUpdateProdusTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.UpdateProdus(new Produs("Sprite", 7, 2, Masura.Litru, 7)));
        }

        [TestMethod]
        public void TestUpdateProdusFalse()
        {
            Assert.AreEqual(true, _restaurantDAO.UpdateProdus(new Produs("Sprite1", 7, 2, Masura.Litru, 7)));
        }

        [TestMethod]
        public void TestAddMeniuTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.AddMeniu(new Meniu(8, "ceva")));
        }
        [TestMethod]

        public void TestRemoveMeniuTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.RemoveMeniu(8));
        }
        [TestMethod]
        public void TestAddMeniuFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.AddMeniu(new Meniu(1, "ceva")));
        }
        [TestMethod]

        public void TestRemoveMeniuFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.RemoveMeniu(-8));
        }
        [TestMethod]
        public void TestUpdateMeniuTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.UpdateMeniu(new Meniu(7, "bauturi carbogazoase")));

        }
        [TestMethod]
        public void TestUpdateMeniuFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.UpdateMeniu(new Meniu(-1, "bauturi carbogazoase")));
        }

        [TestMethod]
        public void TestAddOspatarTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.AddOspatar(new Ospatar(5, "James Bond", "1234567890", "bond.james")));
        }
        [TestMethod]
        public void TestRemoveOspatarTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.RemoveOspatar(5));
        }

        [TestMethod]
        public void TestAddOspatarFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.AddOspatar(new Ospatar(1, "James Bond", "1234567890", "bond.james")));
        }
        [TestMethod]
        public void TestRemoveOspatarFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.RemoveOspatar(-1));
        }

        [TestMethod]
        public void TestUpdateOspatarTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.UpdateOspatar(new Ospatar(4, "Nichiforeac Cristina", "003254698", "cristina.nichiforeac")));
        }

        [TestMethod]
        public void TestUpdateOspatarFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.UpdateOspatar(new Ospatar(-4, "Nichiforeac Cristina", "745699871", "ceva")));
        }

        [TestMethod]
        public void TestAddLoginTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.AddLogin(new Login("capsunel frumusel", "1234", new DateTime(2008, 6, 1), 0)));
        }

        [TestMethod]
        public void TestRemoveLoginTrue()
        {
            Assert.AreEqual(true, _restaurantDAO.RemoveLogin("capsunel frumusel"));
        }

        [TestMethod]
        public void TestAddLoginFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.AddLogin(new Login(null, "1234", new DateTime(2008, 6, 1), 0)));
        }

        [TestMethod]
        public void TestRemoveLoginFalse()
        {
            Assert.AreEqual(false, _restaurantDAO.RemoveLogin(null));
        }


    }
}
