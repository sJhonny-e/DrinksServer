using DrinksServer.DAL;
using DrinksServer.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksServer.Tests.DAL
{
    [TestFixture()]
    public class DrinksRepositoryTests
    {
        private DrinksRepository _repository;
        private DrinkInventory bosco = new DrinkInventory(new Drink("bosco"), 4);

        [SetUp]
        public void Setup()
        {
            _repository = new DrinksRepository();
        }

        [Test]
        public void Add_WhenDrinkDoesntExistAlready_AddsTheDrink()
        {
            Assert.IsTrue(_repository.Add(bosco));

            Assert.AreEqual(bosco, _repository.Get("bosco"));
        }

        [Test]
        public void Add_WhenTryingToAddAnIdenticalDrink_Fails()
        {
            Assert.IsTrue(_repository.Add(bosco));
            var otherBosco = new DrinkInventory(new Drink("boSCo"), 64);

            Assert.IsFalse(_repository.Add(otherBosco));
        }

        [Test]
        public void Get_IsCaseInsensitive()
        {
            _repository.Add(bosco);
            Assert.AreEqual(bosco, _repository.Get("BosCO"));
        }
    }
}
