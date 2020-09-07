﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// This is where i give you all the information about my peeps.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName="Tim",LastName="Corey",Id=1});
            people.Add(new Person { FirstName = "Sue", LastName = "Storm",Id=2});
            people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins" ,Id=3});
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <param name="userId">yThe unique identifire for this person.</param>
        /// <param name="age"> we want to know how old they are.</param>
        /// <returns> A list of first names ...duk  </returns>
        [Route("api/Pepole/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId,int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
