using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01642795Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        ///     Recieves a number, outputs that number after four mathematical operations have been applied to it (multiply by 10, subtract 4, divide by 2, and add the number recieved)
        /// </summary>
        /// <param name="id"> The input number (as an integer) </param>
        /// <returns>
        ///     GET api/NumberMachine/10 --> 58
        ///     GET api/NumberMachine/-5 --> -32
        ///     GET api/NumberMachine/30 --> 178
        /// </returns>
        public int Get(int id)
        {
            int operation1 = id * 10;
            int operation2 = operation1 - 4;
            int operation3 = operation2 / 2;
            int operation4 = operation3 + id;
            return operation4;
        }
    }
}
