using Odev.Web.Clients.Interfaces;
using Odev.Web.Models;
using Odev.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev.Web.Clients
{
    public class UserClientManager : BaseClientManager<RootObject>, IUserClientManager
    {
        RandomUserViewModel model;
        IList<RandomUserViewModel> randomUsers=new List<RandomUserViewModel>();
        public IList<RandomUserViewModel> GetRandomUsers()
        {
            foreach (var item in GetAll().RandomUsers)
            {
                model = new RandomUserViewModel();
                model.Id = item.login.uuid;
                model.Name = item.name.first + " " + item.name.last;
                model.PhoneNumber = item.phone;
                model.UserName = item.login.username;
                model.Email = item.email;
                randomUsers.Add(model);
            }
            return randomUsers;
        }
    }
}