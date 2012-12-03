using System.Collections.Generic;

namespace TrainingForTrainer
{
    public class SoftwareSet : ISoftware
    {
        private readonly string name;
        private readonly IList<ISoftware> softwares;

        public SoftwareSet(string name, IList<ISoftware> softwares)
        {
            this.name = name;
            this.softwares = softwares;
        }

        public string Name()
        {
            return name;
        }

        public double TotalPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}