using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev.Web.ViewModels
{
    public class RandomUserViewModel
    {       
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool ExamIsActive { get; set; }
    }
}