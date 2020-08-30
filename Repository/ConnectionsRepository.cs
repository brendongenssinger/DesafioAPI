using System.Collections;
using System.Collections.Generic;
using DesafioAPI.Models;
using System;
using System.Linq;
namespace DesafioApi.Repository
{
    public class ConnectionRepository
    {
        
        private readonly Dictionary<Guid,Users> _conection =  new Dictionary<Guid, Users>();            

        internal void Add(string uniqueID,Users user)
        {
            if(string.IsNullOrEmpty(uniqueID))
                AddInternal(user);
            else
                if(!_conection.ContainsKey(Guid.Parse(uniqueID)))
                    AddInternal(user);
        }

        private void AddInternal(Users pUser)
        {
            var user = new Users
            {
                dtConnection = DateTime.Now,
                Key = Guid.NewGuid(),
                Name = pUser.Name
            };

            _conection.Add(user.Key,user);
        }

        public List<Users> GetUsersAll()
        {
            return _conection.Values.ToList();
        }
    }
}