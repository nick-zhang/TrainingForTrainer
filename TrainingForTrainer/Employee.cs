using System;

namespace TrainingForTrainer
{
    public class Employee
    {
        private readonly EmployeeType employeeType;

        public int Type
        {
            get { return employeeType.GetTypeCode(); }
        }

        private readonly int monthlySalary;
        private readonly int commission;
        private readonly int bonus;

        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public Employee(int monthlySalary, int commission, int bonus, EmployeeType employeeType)
        {
            this.monthlySalary = monthlySalary;
            this.commission = commission;
            this.bonus = bonus;
            this.employeeType = employeeType;
        }

        public int Payment()
        {
            switch (Type)
            {
                case ENGINEER:
                    return monthlySalary;
                case SALESMAN:
                    return monthlySalary + commission;
                case MANAGER:
                    return monthlySalary + bonus;
                default:
                    throw new ApplicationException("Incorrect Employee");
            }
        }
    }

}
