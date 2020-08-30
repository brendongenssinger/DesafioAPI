using System;
namespace DesafioAPI.Models
{
    public class Users
    {
        public string Name { get; set; }
        public Guid Key { get; set; }
        public DateTime dtConnection { get; set; }
    }
}