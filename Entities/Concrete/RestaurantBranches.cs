using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using DeliveryAPI.Core.Entities;

namespace DeliveryAPI.Entities.Concrete
{
    public class RestaurantBranches : IEntity
    {
   
        public int Id { get; set; }

        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }


    }




}
