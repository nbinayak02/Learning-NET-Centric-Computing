using System;
namespace multipleInheritance
{

    interface CentralGovernment
    {
        void CentralGovRules();

    }

    interface ProvinceGovernment
    {
        void ProvinceGovRules();
    }

    public class LocalGovernment : CentralGovernment, ProvinceGovernment
    {
        public void CentralGovRules()
        {
            Console.WriteLine("The local government has followed all the rules of Central Government");
        }

        public void ProvinceGovRules()
        {
            Console.WriteLine("The local government has followed all the rules of Province Government");
        }
    }

    class Program
    {
        public static void Main()
        {
            LocalGovernment lg = new LocalGovernment();
            lg.CentralGovRules();
            lg.ProvinceGovRules();
        }
    }

}