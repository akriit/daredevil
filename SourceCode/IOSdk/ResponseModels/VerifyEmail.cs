/* Designed, developed and maintained by Daredevils
--Developer Change History
1. Created by Anil , Vijay , Hemant , Roshan, Akriti on 09th dec 2019
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.ResponseModels
{



    public class VerifyEmail
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
