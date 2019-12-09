/* Designed, developed and maintained by Daredevils
--Developer Change History
1. Created by Anil , Vijay , Hemant , Roshan, Akriti on 09th dec 2019
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.ResponseModels
{
    
    public class LoginResponse
    {
        [JsonProperty("access_token")]
        public Guid AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public DateTimeOffset ExpiresIn { get; set; }
    }
}
