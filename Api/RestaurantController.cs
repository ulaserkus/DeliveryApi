using DeliveryAPI.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Api
{
    [Route("api/restaurantbranches")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private IRestaurantBranchService _restaurantBranchService;

        public RestaurantController(IRestaurantBranchService restaurantBranchService)
        {
            _restaurantBranchService = restaurantBranchService;

        }

        [HttpGet]
        public IActionResult GetList()
        {
            var result = _restaurantBranchService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("closest/{latitude}/{longtitude}")]
        public IActionResult GetClosestLocations( double latitude,  double longtitude)
        {
            var result = _restaurantBranchService.GetClosestLocation(latitude,longtitude);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }


    }
}
