using Microsoft.AspNetCore.Identity;
using Project.EntityLayer.Enums;
using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityLayer.Models
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
