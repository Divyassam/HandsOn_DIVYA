using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMedicine
{
    [TestFixture]
    class TestClass
    {
        public static Program objMainProgram;
        public static Medicine medicine;
        [SetUp]
        public void Init()
        {
            objMainProgram = new Program();
            medicine = objMainProgram.CreateMedicineDetail("Paracetamol", "Acetaminophen", "Potassium sorbate", Convert.ToDateTime("2023-10-20"), 20);
        }

        [Test]
        [TestCase("Paracetamol", "Acetaminophen", "Potassium sorbate", "2023-10-20", 20)] //Check medicine obj creation

        public void CreateMedicine_AllValid_Sucess(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            medicine = objMainProgram.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);
            Assert.AreEqual(medicine.Name, name);
            Assert.AreEqual(medicine.GenericMedicineName, genericMedicineName);
            Assert.AreEqual(medicine.Composition, composition);
            Assert.AreEqual(medicine.ExpiryDate, expiryDate);
            Assert.AreEqual(medicine.PricePerStrip, pricePerStrip);
            TestContext.WriteLine("Medicine object created successfully");

        }


        [Test]
        [TestCase("Paracetamol", "", "Potassium sorbate", "2023-10-20", 20)] //Exception -- GenericMedicineName parameter NULL
        public void CreateMedicine_nullName_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", result.Message);
        }


        [Test]
        [TestCase("Paracetamol", "Acetaminophen", "Potassium sorbate", "2023-10-20", -10)] //Exception -- price parameter < 0
        public void CreateMedicine_negativePrice_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", result.Message);
        }

        [Test]
        [TestCase("Paracetamol", "Acetaminophen", "Potassium sorbate", "2019-10-20", 20)] //Exception -- expiryDate parameter  < currentdate
        public void CreateMedicine_invalidExpiryDate_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", result.Message);
        }



        [Test]
        [TestCase(10,"2021-10-20", "London")] //Check carton obj creation
        public void CreateCartone_AllValid_Sucess(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {          
            CartonDetail cartonDetail = objMainProgram.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null);
            Assert.AreEqual(cartonDetail.MedicineStripCount, medicineStripCount);
            Assert.AreEqual(cartonDetail.LaunchDate, launchDate);
            Assert.AreEqual(cartonDetail.RetailerAddress, retailerAddress);
            Assert.AreEqual(cartonDetail.Medicine, medicine);
            TestContext.WriteLine("Medicine object created successfully");

         }

        [Test]
        [TestCase(-5,"2021-10-20", "London")]//Exception -- value less than 0 for medicine strip count
        public void CreateCarton_negativeStripCount_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
            Assert.AreEqual("Incorrect strip count. Please check", result.Message);
        }


        [Test]
        [TestCase(10, "2024-03-07", "London")] //Exception --launch date greater than expiry date
        public void CreateCarton_InvalidLaunchDate_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
            Assert.Contains(result.Message, new List<string> { "Incorrect launch date. Please provide valid value", "Launch date greater than expiry date. Please check"});
        }


        [Test]
        [TestCase(10, "2021-10-20", "London")] //Exception -- medicine value NULL
        public void CreateCarton_NullMedicine_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = objMainProgram.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null);          
            Assert.Null(result);
            TestContext.WriteLine("Null carton");            
        }

    }
}
