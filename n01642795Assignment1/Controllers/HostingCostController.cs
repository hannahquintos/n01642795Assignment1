using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01642795Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        ///     Recieves a number of days which has elapsed since the beginning of the hosting, outputs 3 strings that describe the total hosting cost (cost per fortnights, tax, and total)
        /// </summary>
        /// <param name="id"> The input number of days elapsed since hosting (as an integer) </param>
        /// <returns>
        ///     GET api/HostingCost/0 --> "1 fortnights at $5.50/FN = $5.50 CAD" "HST 13% = $0.72 CAD" "Total = $6.22 CAD"
        ///     GET api/HostingCost/14 --> "2 fortnights at $5.50/FN = $11.00 CAD" "HST 13% = $1.43 CAD" "Total = $12.43 CAD"
        ///     GET api/HostingCost/15 --> "2 fortnights at $5.50/FN = $11.00 CAD" "HST 13% = $1.43 CAD" "Total = $12.43 CAD"
        ///     GET api/HostingCost/21 --> "2 fortnights at $5.50/FN = $11.00 CAD" "HST 13% = $1.43 CAD" "Total = $12.43 CAD"
        ///     GET api/HostingCost/28 --> "3 fortnights at $5.50/FN = $16.50 CAD" "HST 13% = $2.15 CAD" "Total = $18.65 CAD"
        /// </returns>
        public IEnumerable<string> Get(int id) // use IEnumerable<string> in order to output multiple strings
        {
            // For string 1 ("# fortnights at $5.50/FN = $_.__ CAD"): 
                // 1) determine the # of fortnights based on the number of days elapsed {id}
                // 2) determine the cost by multiplying the # of fortnights by $5.50 (the cost per fortnight)

                    // 1) solve for # of fortnights
                    int fortnights = id / 14;
                    fortnights = fortnights + 1; //add 1 because it starts counting the first fortnight at 0 days

                    // 2) calculate cost
                    double cost = fortnights * 5.50;
                    string preciseCost = cost.ToString("0.00"); //to format to two decimal places

                    // string 1 message
                    string costMessage = fortnights + " fortnights at $5.50/FN = $" + preciseCost + " CAD";


            // For string 2 ("HST 13% = $_.__ CAD"):
                // 1) determine the tax (what is 13% of the cost?)

                    // 1) calculate tax
                    double tax = cost * 0.13;
                    string precisetax = tax.ToString("0.00");

                    // string 2 message
                    string taxMessage = "HST 13% = $" + precisetax + " CAD";

            // For string 3 ("Total = $_.__ CAD"):
                // 1) determine the total cost (cost plus tax)

                    // 1) calculate total
                    double total = cost + tax;
                    string precisetotal = total.ToString("0.00");

                    // string 3 message
                    string totalMessage = "Total = $" + precisetotal + " CAD";

            // return the 3 strings
                return new string[] {costMessage, taxMessage, totalMessage};
        }
    }
}
