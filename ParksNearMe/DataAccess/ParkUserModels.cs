using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParksNearMe.DataAccess
{
    public class ParkUser
    {
        [Key]
        public int userId { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public List<UserFavPark> myFavParks { get; set; }
    }

    public class FavPark
    {
        [Key]
        public int parkId { get; set; }
        public String parkCode { get; set; }
        public String parkName { get; set; }
        public List<UserFavPark> userFavParks { get; set; }
    }

    public class UserFavPark
    {
        [Key]
        public int userParkId { get; set; }
        public ParkUser user { get; set; }
        public FavPark park { get; set; }
    }
}
