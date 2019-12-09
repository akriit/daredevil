/* Designed, developed and maintained by Daredevils
--Developer Change History
1. Created by Anil , Vijay , Hemant , Roshan, Akriti on 09th dec 2019
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.RequestModels
{
    // verify user registration
    public class UserRegisterationModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Gender { get; set; }
    }
}
