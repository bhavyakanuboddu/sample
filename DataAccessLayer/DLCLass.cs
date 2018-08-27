using System.Collections.Generic;
namespace DataAccessLayer
{
   public class DLCLass
    {
      static  IDictionary<string, string> userDic = new Dictionary<string, string>();
      static  IDictionary<string, string> nameDic = new Dictionary<string, string>();
      static   List<int> uniqueNumList = new List<int>();
       static  List<string> rePasswordList = new List<string>();
        /// <summary>
        /// this method takes arguemnts from bussiness and adds them to the userDic.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="uniqueNumber"></param>
       public  void RegisteringUser(string userName,string password,string firstName,string lastName,int uniqueNumber)
        {
            userDic.Add(new KeyValuePair<string, string>(userName, password));
            nameDic.Add(new KeyValuePair<string, string>(firstName, lastName));
            uniqueNumList.Add(uniqueNumber);
        }
        /// <summary>
        /// this method returns the uniquenum list to bussinessLayer.
        /// </summary>
        /// <returns></returns>
       public List<int> SendingNumList()
        {
            return uniqueNumList;
        }
        /// <summary>
        /// this method updates the password of the user after changing.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="rePassword"></param>
        public void ForgotPasswordMethod(string userName,string password,string rePassword)
        {
            userDic[userName] = password;
            rePasswordList.Add(rePassword);
        }
        /// <summary>
        /// this method returns the dictionary to bussinessLayer.
        /// </summary>
        /// <returns></returns>
       public IDictionary<string, string> sendingDic()
        {
            return userDic;
        }
    }
}
