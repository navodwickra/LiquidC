using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactManager.Controllers
{
    public class ContactController : ApiController
    {
        public Contact[] GetContact()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Glenn Block"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Dan Roth"
                }
            };
        }

        public Contact GetContact(int id) 
        {
            if (id == 1)
            {
                return new Contact { Id = 1, Name = "Glenn Block" };
            }
            else 
            {
                return new Contact { Id = 2, Name = "Dan Roth" };
            }
        }

      
    }
}
