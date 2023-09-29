using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01642795Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        ///     Recieves a number, outputs the square of that number
        /// </summary>
        /// <param name="id"> The input number (as an integer) </param>
        /// <returns>
        ///     GET api/Square/2 --> 4
        ///     GET api/Square/-2 --> 4
        ///     GET api/Square/10 --> 100
        /// </returns>
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
