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

        public int MonthlySalary
        {
            get { return monthlySalary; }
        }

        public int Commission
        {
            get { return commission; }
        }

        public int Bonus
        {
            get { return bonus; }
        }

        private readonly int monthlySalary;
        private readonly int commission;
        private readonly int bonus;

        public Employee(int monthlySalary, int commission, int bonus, EmployeeType employeeType)
        {
            this.monthlySalary = monthlySalary;
            this.commission = commission;
            this.bonus = bonus;
            this.employeeType = employeeType;
        }

        public int Payment()
        {
            return employeeType.Payment(this);
        }
    }
}
