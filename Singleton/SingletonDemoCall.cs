
namespace DesignPatterns.Singleton
{
    public class SingletonDemoCall
    {
        public static void Run()
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton1 = Singleton.GetInstance();

            if (singleton.Equals(singleton1))
            {
                Console.WriteLine("Two Singleton instance is same");
            }

            singleton.SometOtherBusinessLogic();
            singleton1.SometOtherBusinessLogic();
        }
    }
}
