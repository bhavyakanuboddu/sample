using System;
using BussinessLayer;
namespace ThreeTier
{
    /// <summary>
    /// forgot password class takes details from user reqired for changing their password .
    /// calls forgotpasswordvalidation method in bussiness layer.
    /// </summary>
    class ForgotPassword : Program.IForm
    {
      public string Details()
        {
            string  password, rePassword,userName;
            int uniqueNum;
            Console.Write("enter userName");
            userName = Console.ReadLine();
            Console.Write("please enter your uniqueNumber for verification:");
            uniqueNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your new password:");
            password = Console.ReadLine();
            Console.Write("please enter your new Password again:");
            rePassword = Console.ReadLine();
            BLClass obj = new BLClass();
            bool result = obj.ForgotPasswordValidation(uniqueNum, userName, password, rePassword);
            if(result)
            {
                return "password has been changed successfully.";
            }
            else
            {
                return "password has not chnaged, try once again.";
            }
        }
    }
}
