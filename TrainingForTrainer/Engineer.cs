namespace TrainingForTrainer
{
    public class Engineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            return ENGINEER;
        }

        public override int Payment(Employee employee)
        {
            return employee.MonthlySalary;
        }
    }
}