using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int CustomerId { get; set; }
        public string Password { get; set; }
        public string CarName { get; set; }

    }
}
