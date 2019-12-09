/* Designed, developed and maintained by Daredevils
--Developer Change History
1. Created by Anil , Vijay , Hemant , Roshan, Akriti on 09th dec 2019
*/



using IOSdk.RequestModels;

namespace IOSdk
{
    public class API
    {
        public UserRegisterationModel Register(UserRegisterationModel payload)
        {
            var result=new HttpUtility().call<UserRegisterationModel>(payload);
            return result;
        }
    }
}
