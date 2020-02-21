namespace Hierarchy02
{
    class ContractEmployee : Employee
    {
        private float payPerHour;
        private string contractPeriod;
        
        public ContractEmployee(int id, string name, float payPerHour, string contractPeriod) : base(id, name)
        {
            this.payPerHour = payPerHour;
            this.contractPeriod = contractPeriod;
        }

        public override string ToString()
        {
            return $"Id: {id} \nName: {name} \nPay Per Hour: {payPerHour} \nContract Period: {contractPeriod}";
        }
    }
}
