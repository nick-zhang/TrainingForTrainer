namespace TrainingForTrainer
{
    public abstract class EmployeeType
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public abstract int GetTypeCode();
        public abstract int Payment(Employee employee);
    }
}
