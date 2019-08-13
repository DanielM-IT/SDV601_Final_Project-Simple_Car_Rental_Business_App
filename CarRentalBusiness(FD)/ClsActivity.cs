using System;

namespace CarRentalBusiness_FD_
{
    [Serializable]
    public abstract class ClsActivity
    {
        protected ClsVehicle _Vehicle;

        private string _Name;
        private decimal _InputAmount = 1;
        private DateTime _ActivityDate = DateTime.Today;
        public static readonly string[] ActivityType = { "Hiring", "Service", "Relocation" };

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public decimal InputAmount
        {
            get => _InputAmount;
            set => _InputAmount = value;
        }
        public DateTime ActivityDate
        {
            get => _ActivityDate;
            set => _ActivityDate = value;
        }

        public static ClsActivity NewActivity(int prChoice, ClsVehicle prVehicle)
        {
            switch (prChoice)
            {
                case 0:
                    return new ClsHiringActivity() { _Vehicle = prVehicle };
                case 1:
                    return new ClsServiceActivity() { _Vehicle = prVehicle };
                default:
                    return new ClsRelocationActivity() { _Vehicle = prVehicle };
            }

        }

        public abstract bool ViewEdit();

        public override string ToString()
        {
            return string.Format("{0, -15}", typeOfActivity()) + string.Format("{0, -15}", _Name) + string.Format("{0, -15}", CalcCashFlowAmount()) + string.Format("{0, -15}", _ActivityDate.ToShortDateString());
        }

        public abstract decimal CalcCashFlowAmount();

        protected abstract string typeOfActivity();

    }
}
