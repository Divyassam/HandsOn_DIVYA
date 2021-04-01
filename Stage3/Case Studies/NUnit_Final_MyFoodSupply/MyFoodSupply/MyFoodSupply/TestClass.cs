using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoodSupply
{
    [TestFixture]
    class TestClass
    {
        Program objMainProgram ;
        FoodDetail food;
        [SetUp]
        public void Init()
        {
            objMainProgram = new Program();
            food=objMainProgram.CreateFoodDetail("Burger", 1, Convert.ToDateTime("2021-10-20"), 100);
        }

        [Test]
        [TestCase("Sandwich",1,"2021-10-20",100)] //Check food obj creation    
        public void CreateFood_AllValid_Success(string name, int dishType, DateTime expiryDate, double price)
        {
             food = objMainProgram.CreateFoodDetail(name, dishType, expiryDate, price);
             Assert.AreEqual(food.Name, name);
             TestContext.WriteLine("Food Item created successfully!!");           
        }

        [Test]
        [TestCase("", 1, "2021-10-20", 100)] //Exception -- name parameter NULL
        public void CreateFood_NullName_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", result.Message);
        }

        [Test]
        [TestCase("Sandwich", 1, "2021-10-20", 300)] //Exception -- price parameter < 0
        public void CreateFood_InvalidPrice_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", result.Message);
        }

        [Test]
        [TestCase("Sandwich", 1, "2017-10-20", 100)] //Exception -- expiryDate parameter  < currentdate
        public void CreateFood_InvalidDate_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", result.Message);
        }


        

        [Test]
        [TestCase(100,"2021-05-03", "Tom",250)] //Check Supply obj creation
        public void CreateSupply_AllValid_Success(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            SupplyDetail supply = objMainProgram.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food);
            Assert.AreEqual(supply.Count, foodItemCount);
            Assert.AreEqual(supply.RequestDate, requestDate);
            Assert.AreEqual(supply.SellerName, sellerName);
            Assert.AreEqual(supply.TotalCost, packingCharge + food.Price * foodItemCount);
            Assert.AreSame(supply.FoodItem, food);
            TestContext.WriteLine("Supply object created successfully");


        }


        [Test]
        [TestCase(-10, "2021-05-03", "Tom", 250)]//Exception -- value less than 0 for food item count
        public void CreateFood_NegativeItemCount_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.AreEqual("Incorrect food item count. Please check", result.Message);
        }


        [Test]
        [TestCase(100, "2015-05-03", "Tom", 250)]//Exception -- date less than today
        public void CreateFood_InvalidDate_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result = Assert.Throws<Exception>(() => objMainProgram.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.Contains(result.Message, new List<string> { "Incorrect food request date. Please provide valid value", "Request date greater than expiry date. Please check" });
        }


        [Test]
        [TestCase(10, "2021-05-03", "Tom", 250)] //Exception -- fooditem value NULL
        public void CreateFood_NullItem_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            SupplyDetail supply = objMainProgram.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, null);
            Assert.Null(supply);
            TestContext.WriteLine("Null Supply");
           
        }

    }
}
