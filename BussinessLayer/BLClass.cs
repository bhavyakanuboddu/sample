using System;
using System.Collections.Generic;
using DataAccessLayer;
namespace BussinessLayer
{
  public class BLClass
    {
        DLCLass obj = new DLCLass();
        /// <summary>
        /// this method calls the method in dataLayer inorder to register the user.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="uniqueNumber"></param>
        /// <returns></returns>
        public string RegisteringUser(string userName, string password, string firstName, string lastName,int uniqueNumber)
        {
            obj.RegisteringUser(userName, password, firstName, lastName, uniqueNumber);
            return "registered Successfully";
        }
        /// <summary>
        /// this method verifies the login credentials of the user.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public  bool LoginValidation(string userName,string password)
        {
            IDictionary<string, string> userDic = obj.sendingDic();
            if (userDic.Contains(new KeyValuePair<string, string>(userName, password)))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// this method verifies the details which are required for changing password when user forgets his password.
        /// </summary>
        /// <param name="uniqueNumber"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="rePassword"></param>
        /// <returns></returns>
      public  bool ForgotPasswordValidation(int uniqueNumber, string userName, string password, string rePassword)
        {
           List<int> uniqueNumList = obj.SendingNumList();
            bool exists = uniqueNumList.Exists(element => element == uniqueNumber);
            if(exists)
                {
                IDictionary<string, string> userDic = obj.sendingDic();
                obj.ForgotPasswordMethod( userName,  password, rePassword);
                if (userDic[userName] == rePassword)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("password missmatch");
                    System.Environment.Exit(1);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("uniquenumber not matched");
                System.Environment.Exit(1);
                return false;
            }
        }
    }
}
