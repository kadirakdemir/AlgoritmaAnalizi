using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev.Web.ViewModels
{
    public class ExamViewModel
    {      
        public string Question { get; set; }
        public DateTime InsertDate { get; set; }
        public string Answer { get; set; }
        public string RandomUserViewModelId { get; set; }
        public string RandomUserName { get; set; }
    }
}