
using System;
namespace DesafioAPI.Models
{
    public class Message
    {
        public Int64 Destination { get; set; }
        public Users Sender { get; set; }
        public string Messagem { get; set; }
    }
}