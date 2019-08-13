using System;
using System.Collections.Generic;

namespace CarRentalBusiness_FD_
{
    [Serializable]
    public class ClsVehicle
    {
        private static FrmVehicle _VehicleForm = new FrmVehicle();

        private List<ClsActivity> _ActivityList = new List<ClsActivity>();

        private string _RegistrationNo;
        private string _Make;
        private string _Model;
        private decimal _Year;
        private decimal _DailyHire;

        public List<ClsActivity> ActivityList
        {
            get => _ActivityList;
        }
        public string RegistrationNo
        {
            get => _RegistrationNo;
            set => _RegistrationNo = value;
        }
        public string Make
        {
            get => _Make;
            set => _Make = value;
        }
        public string Model
        {
            get => _Model;
            set => _Model = value;
        }
        public decimal Year
        {
            get => _Year;
            set => _Year = value;
        }
        public decimal DailyHire
        {
            get => _DailyHire;
            set => _DailyHire = value;
        }

        public bool ViewEdit()
        {
            return _VehicleForm.ShowDialog(this);
        }

        public override string ToString()
        {
            return _RegistrationNo;
        }

        public string ToStringQuickView()
        {
            return "RegistrationNo:  " + _RegistrationNo + "\n" + "Make:  " + _Make + "\n" + "Model:  " + _Model + "\n" + "Year:  " + _Year + "\n" + "Daily Charge:  " + _DailyHire;
        }

        public decimal TotalVehicleCashflow()
        {
            decimal lcTotal = 0;
            foreach (ClsActivity lcVehicle in ActivityList)
            lcTotal += lcVehicle.CalcCashFlowAmount();
            return lcTotal;
        }

    }
}
