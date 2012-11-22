namespace TrainingForTrainer
{
    public class Manager : EmployeeType
    {
        public override int GetTypeCode()
        {
            return MANAGER;
        }

        public override int Payment(Employee employee)
        {
            return employee.MonthlySalary + employee.Bonus;
        }
    }
}