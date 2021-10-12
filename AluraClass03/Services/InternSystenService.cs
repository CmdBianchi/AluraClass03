using Models;

namespace Services
{
    public class InternSytemService 
    {
        public string LogingChecker( ValidationService employee, string passWord )
        {
            bool authenticationUser = employee.Authentication( passWord );

            if( authenticationUser )
                return "WELLCOME";
            else
                return "INVALID PASSWORD";
        }
    }
}
