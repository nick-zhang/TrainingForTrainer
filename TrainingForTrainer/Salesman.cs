namespace TrainingForTrainer
{
    public class Salesman : EmployeeType
    {
        public override int GetTypeCode()
        {
            return SALESMAN;
        }

        public override int Payment(Employee employee)
        {
            return employee.MonthlySalary + employee.Commission;
        }
    }
}