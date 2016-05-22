using DrinksServer.Controllers.DTOs;
using DrinksServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DrinksServer.Controllers
{
    public class DrinksController : ApiController
    {
        private IDrinksRepository _drinksRepository;

        public DrinksController(IDrinksRepository drinksRepository)
        {
            _drinksRepository = drinksRepository;
        }

        // GET: api/Drinks
        public IEnumerable<DrinkDTO> Get()
        {
            return _drinksRepository.GetAll()
                .Select(drinkInventory => new DrinkDTO(drinkInventory));
        }

        // GET: api/Drinks/5
        public IHttpActionResult Get(string name)
        {
            var drinkInventory = _drinksRepository.Get(name);
            return drinkInventory != null ? Ok(new DrinkDTO(drinkInventory)) : (IHttpActionResult)NotFound();
        }

        // POST: api/Drinks
        public IHttpActionResult Post([FromBody]DrinkDTO drinkDto)
        {
            var drink = new Drink(drinkDto.DrinkName);
            var drinkInventory = new DrinkInventory(drink, drinkDto.Quantity);

            var succeeded = _drinksRepository.Add(drinkInventory);
            return succeeded ? (IHttpActionResult)Ok() : BadRequest("A drink with this name already exists");
        }

        // PUT: api/Drinks/5
        public IHttpActionResult Put(string name, [FromBody]DrinkDTO drinkDto)
        {
            var drinkInventory = _drinksRepository.Get(name);
            if (drinkInventory == null)
            {
                return NotFound();
            }

            var succeeded = drinkInventory.ChangeQuantity(drinkDto.Quantity);
            return succeeded ? (IHttpActionResult)Ok() : BadRequest("illegal quantity");
        }

        // DELETE: api/Drinks/5
        public IHttpActionResult Delete(string name)
        {
            var succeeded = _drinksRepository.Delete(name);
            return succeeded ? (IHttpActionResult)Ok() : NotFound();
        }
    }
}
