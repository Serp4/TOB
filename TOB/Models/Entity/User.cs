using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TOB.Models.Entity
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        private string NormalizedUserName { get;  set; }
        public string Email { get; set; }
        private string NormalizedEmail { get;  set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Active { get; set; }
    }
}
