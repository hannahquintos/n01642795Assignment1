using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace n01642795Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        ///     Outputs a greeting message
        /// </summary>
        /// <returns>
        ///     POST api/Greeting --> "Hello World!"
        /// </returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        ///     Recieves a number of people, outputs an appropriate greeting message for that number of people
        /// </summary>
        /// <param name="id"> The input number of people (as an integer) </param>
        /// <returns>
        ///     GET api/Greeting/3 --> "Greetings to 3 people!"
        ///     GET api/Greeting/6 --> "Greetings to 6 people!"
        ///     GET api/Greeting/0 --> "Greetings to 0 people!"
        /// </returns>
        public string Get(int id)
        {
            string greeting = "Greetings to " + id + " people!";
            return greeting;
        }
    }
}
