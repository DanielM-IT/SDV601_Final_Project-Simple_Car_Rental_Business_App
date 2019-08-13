using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarRentalBusiness_FD_
{
    [Serializable]
    public class ClsVehicleBusiness
    {
        private static string filename = "E";

        private static Dictionary<string, ClsVehicle> _VehicleList = new Dictionary<string, ClsVehicle>();

        public static Dictionary<string, ClsVehicle> VehicleList
        {
            get => _VehicleList;
            set => _VehicleList = value;
        }

        public static decimal TotalCashflow()
        {
            decimal lcTotal = 0;
            foreach (ClsVehicle lcVehicle in VehicleList.Values)
                lcTotal += lcVehicle.TotalVehicleCashflow();
            return lcTotal;
        }

        public static void Save()
        {
            using (FileStream lcFileStream = new FileStream(filename, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, VehicleList);
            }
        }

        public static void Retrieve()
        {
            using (FileStream lcFilestream = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                VehicleList = (Dictionary<string, ClsVehicle>)lcFormatter.Deserialize(lcFilestream);
            }
        }

    }
}
