using System.Collections.Generic;

namespace TrainingForTrainer
{
    public class Brand : ISoftware
    {
        private readonly string name;
        private readonly IList<ISoftware> softwares;

        public Brand(string name, IList<ISoftware> softwares)
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