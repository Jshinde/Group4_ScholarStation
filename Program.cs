using ScholarStation.Users;
using System;
/**
 * @author Cole Peaden
 * @version 2.1
 * @date 1/26/18
 * 
 * This class is a tester for the IPerson Interface 
 * as well as the users in the User package.
 *
 */
namespace ScholarStation
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson student = new StandardUser();
            IPerson admin = new Administrator();
            IPerson prof = new Professor();
            IPerson deptRep = new DeptRepresentative();

            student.Name = "Cole Peaden";
            student.ID = 1000;
            student.Password = "Password!";

            admin.Name = "Mr. Computer Fixer";
            admin.ID = 1001;
            admin.Password = "GodMode1";

            prof.Name = "Dr. Brian Eddy";
            prof.ID = 1002;
            prof.Password = "BallinCodeWizard#EngineerStatus";

            deptRep.Name = "Dr. Computer Man";
            deptRep.ID = 1003;
            deptRep.Password = "KingComputer23";

            String adminUser = admin.GetType().Name;
            Console.WriteLine("User Type: " + adminUser + "\n" + admin.ToString() + "\n");

            String deptUser = deptRep.GetType().Name;
            deptUser = deptUser.Substring(0, (deptRep.GetType().Name.Length - 14)); //substring to make titles make sense to users.
            Console.WriteLine("User Type: " + deptUser + "\n" + deptRep.ToString() + "\n");

            String profUser = prof.GetType().Name;
            Console.WriteLine("User Type: " + profUser + "\n" + prof.ToString() + "\n");

            String userType = student.GetType().Name;
            userType = userType.Substring(0, (student.GetType().Name.Length - 4)); //substring to make titles make sense to users.
            Console.WriteLine("User Type: " + userType+ "\n" + student.ToString());
            Console.ReadKey();

        }
    }
}
