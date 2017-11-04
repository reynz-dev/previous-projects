using System;
using App.BusinessLogicLayer.Validators;

namespace DataGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var members = MemberValidations.GetMembers();

            foreach (var record in members)
            {
                Console.WriteLine($"{record.FirstName} {record.LasttName}");
            }
            
            Console.Read();
        }
    }
}
