using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01642795Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        ///     Recieves a number, outputs a number 10 more than that number
        /// </summary>
        /// <param name="id"> The input number (as an integer) </param>
        /// <returns>
        ///     GET api/AddTen/21 --> 31
        ///     GET api/AddTen/0 --> 10
        ///     GET api/AddTen/-9 --> 1
        /// </returns>
        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}