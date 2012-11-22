using System;

namespace TrainingForTrainer
{
    public class Employee
    {
        private readonly int type;

        public int Type
        {
            get { return type; }
        }

        private readonly int monthlySalary;
        private readonly int commission;
        private readonly int bonus;

        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public Employee(int type, int monthlySalary, int commission, int bonus)
        {
            this.type = type;
            this.monthlySalary = monthlySalary;
            this.commission = commission;
            this.bonus = bonus;
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
