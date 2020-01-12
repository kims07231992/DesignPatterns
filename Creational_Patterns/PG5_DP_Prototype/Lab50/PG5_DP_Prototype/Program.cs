using PG5_DP_Prototype.Companies;
using PG5_DP_Prototype.Companies.Branches;
using PG5_DP_Prototype.Companies.Branches.Departments;
using PG5_DP_Prototype.Companies.Branches.Departments.Emplolyees;
using PG5_DP_Prototype.Companies.CardOffice;
using PG5_DP_Prototype.Companies.CardOffice.Cards;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            var amazon = new Company("Amazon", "A"); // create a company

            // create branches
            var pusanBranch = new Branch("Busan", amazon);
            var pankyoBranch = new Branch("Pangyo", amazon);
            var seoulBranch = new Branch("Seoul", amazon);

            // create departments
            var marketingDepartment = new Department("Marketing", pusanBranch);
            var ITDepartment = new Department("IT", pankyoBranch);
            var accountingDepartment = new Department("Accounting", seoulBranch);

            // create prototype of CompanyCard
            var marketingPrototypeCard = new MarketingCard();
            var ITPrototypeCard = new ITDepartmentCard();
            var accountingPrototypeCard = new AccountingCard();

            // create employees and print
            CreateEmployeeAndPrint(marketingDepartment, marketingPrototypeCard);
            CreateEmployeeAndPrint(ITDepartment, ITPrototypeCard);
            CreateEmployeeAndPrint(accountingDepartment, accountingPrototypeCard);
        }
        private static void CreateEmployeeAndPrint(Department department, CompanyCard prototypeCard)
        {
            var employeesNum = 100; // set number of empolyees per department
            for (int i = 0; i < employeesNum; i++)
            {
                var employeeName = "employee" + i;
                var employee = new Employee(employeeName, department);
                var card = prototypeCard.Clone();

                card.Name = employee.Name; // change name from prototype of CompanyCard for each employee
                employee.CompanyCard = card;
                employee.CompanyCard.Print();
            }
        }
    }
}
