using System;
namespace ThreeTier
{
    class ConcreteCreator : Program.Creator
    {
        /// <summary>
        /// this method overrides the method in abstract class creator and cretae required objects.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override Program.IForm GetDetails(string input)
        {
         switch(input)
            {
                case "login":return new Login();
                case "register":return new Register();
                case "forgotpassword":return new ForgotPassword();
                default:throw new ApplicationException(string.Format("invalid input"));
            }
        }
    }
}
