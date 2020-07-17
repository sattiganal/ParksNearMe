using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksNearMe.DataAccess;
using ParksNearMe.Models;
using FavPark = ParksNearMe.DataAccess.FavPark;

namespace ParksNearMe.Controllers
{
    public class ParksController : Controller
    {
        private AppDBContext dbContext;

        public ParksController(AppDBContext context)
        {
            dbContext = context;
        }
        public IActionResult MyFavs()
        {
            ParkUser user1 = new ParkUser();
            user1.firstName = "Jon";
            user1.lastName = "Doe";
            user1.email = "jon.doe@something.com";

            ParkUser user2 = new ParkUser();
            user2.firstName = "John";
            user2.lastName = "Smith";
            user2.email = "john.smith@something.com";

            FavPark park1 = new FavPark();
            park1.parkCode = "P1";
            park1.parkName = "P1 National Park";

            FavPark park2 = new FavPark();
            park2.parkCode = "P2";
            park2.parkName = "P2 State Park";

            FavPark park3 = new FavPark();
            park3.parkCode = "P3";
            park3.parkName = "P3 Memorial";

            FavPark park4 = new FavPark();
            park4.parkCode = "P4";
            park4.parkName = "P4 National Park";

            FavPark park5 = new FavPark();
            park5.parkCode = "P5";
            park5.parkName = "P5 Monument";

            UserFavPark ufp1 = new UserFavPark();
            ufp1.user = user1;
            ufp1.park = park1;

            UserFavPark ufp2 = new UserFavPark();
            ufp2.user = user1;
            ufp2.park = park2;

            UserFavPark ufp3 = new UserFavPark();
            ufp3.user = user1;
            ufp3.park = park3;

            UserFavPark ufp4 = new UserFavPark();
            ufp4.user = user2;
            ufp4.park = park1;

            UserFavPark ufp5 = new UserFavPark();
            ufp5.user = user2;
            ufp5.park = park4;

            dbContext.userFavs.Add(ufp1);
            dbContext.userFavs.Add(ufp2);
            dbContext.userFavs.Add(ufp3);
            dbContext.userFavs.Add(ufp4);
            dbContext.userFavs.Add(ufp5);
            dbContext.SaveChanges();

            ParkUser user = dbContext.users
                                      .Include(p => p.myFavParks)  
                                      .Where(p => p.email == "jon.doe@something.com")
                                      .First();

            FavPark park = dbContext.FavParks
                          .Include(p => p.userFavParks)
                          .Where(p => p.parkCode == "P4")
                          .First();

            DataAccess.FavPark favPark = dbContext.FavParks
                                      .Include(p => p.userFavParks)
                                      .Where(p => p.userFavParks.Count > 1)
                                      .OrderBy(P => P.userFavParks.Count)
                                      .First()
                                      ;

            MyFavParksView favParksView = new MyFavParksView();
            favParksView.currentUser = user;
            favParksView.favePark = park;
            favParksView.mostFavPark = favPark;

            return View(favParksView);
        }
    }
}
