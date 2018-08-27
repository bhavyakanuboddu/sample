using System;
namespace ThreeTier
{
    class Program
    {
        public interface IForm
        {
            string Details();
        }
      public abstract class Creator
        {
            public abstract IForm GetDetails(string input);
        }
        static void Main(string[] args)
        {
            Creator obj = new ConcreteCreator();
            for (int i = 0; i < 4; i++)
            {
                IForm objIForm = obj.GetDetails(Console.ReadLine());
                Console.WriteLine(objIForm.Details());
            }
            Console.ReadKey();
        }
    }
}
