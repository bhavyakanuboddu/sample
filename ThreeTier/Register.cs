using System;
using BussinessLayer;
namespace ThreeTier
{
    /// <summary>
    /// Register class takes the details from the user
    /// calls the RegisteringUser method in bussinessLayer
    /// </summary>
    class Register : Program.IForm
    {
       public string Details()
        {
            string userName, password, firstName, lastName;
            int uniqueNum;
            Console.Write("enter firstname:");
            firstName = Console.ReadLine();
            Console.Write("enter Lastname:");
            lastName= Console.ReadLine();
            Console.Write("enter uniquenumber for your identity:");
            uniqueNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter userName to Register:");
            userName = Console.ReadLine();
            Console.Write("enter password to Register:");
            password = Console.ReadLine();
            BLClass obj = new BLClass();
            string result= obj.RegisteringUser(userName, password, firstName, lastName, uniqueNum);
            return result;
        }
     }
}
