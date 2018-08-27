using System;
using BussinessLayer;
namespace ThreeTier
{
    /// <summary>
    ///  Login class  takes the credentials from user required to login 
    /// calls the Loginvalidation method in bussinessLayer for further validation.
    /// </summary>
    /// <returns></returns>
    class Login : Program.IForm
    {
        public string Details()
        {
            string userName, password;
            Console.Write("enter userName:");
            userName = Console.ReadLine();
            Console.Write("enter password");
            password = Console.ReadLine();
            BLClass obj = new BLClass();
            bool result = obj.LoginValidation(userName, password);
            if(result)
            {
                return "you have logined successfully";
            }
            else
            {
                return "your username or password is incorrect.please provide valid one.or you are trying to login firsttime please do register.";
            }
         }
    }
}
