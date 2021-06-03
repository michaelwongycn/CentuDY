using CentuDY.Factory;
using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class MedicineController
    {
        public static string insertMedicine(string name, string description, string strStock, string strPrice)
        {
            if (name == "")
            {
                return "Name must be filled";
            }
            if (description == "")
            {
                return "Description must be filled";
            }
            if (description.Length <= 10)
            {
                return "Description must be longer than 10 characters";
            }
            if (strStock == "")
            {
                return "Stock must be filled";
            }
            if (strPrice == "")
            {
                return "Price must be filled";
            }
            long temp = 0;
            if (!long.TryParse(strStock, out temp))
            {
                return "Stock number must be numeric";
            }
            if (!long.TryParse(strPrice, out temp))
            {
                return "Price number must be numeric";
            }
            int stock = int.Parse(strStock);
            if (stock <= 0)
            {
                return "Stock must be more than 0";
            }
            int price = int.Parse(strPrice);
            if (price <= 0)
            {
                return "Price must be more than 0";
            }
            Medicine m = MedicineFactory.createMedicine(name, description, stock, price);
            MedicineHandler.AddMedicine(m);
            return "Insert Success";
        }
        public static string updateMedicine(int medicineId, string newName, string newDescription, string strStock, string strPrice)
        {
            if (newName == "")
            {
                return "Name must be filled";
            }
            if (newDescription == "")
            {
                return "Description must be filled";
            }
            if (description.Length <= 10)
            {
                return "Description must be longer than 10 characters";
            }
            if (strStock == "")
            {
                return "Stock must be filled";
            }
            if (strPrice == "")
            {
                return "Price must be filled";
            }
            long temp = 0;
            if (!long.TryParse(strStock, out temp))
            {
                return "Stock number must be numeric";
            }
            if (!long.TryParse(strPrice, out temp))
            {
                return "Price number must be numeric";
            }
            int newStock = int.Parse(strStock);
            if (newStock <= 0)
            {
                return "Stock must be more than 0";
            }
            int newPrice = int.Parse(strPrice);
            if (newPrice <= 0)
            {
                return "Price must be more than 0";
            }

            if(!MedicineHandler.UpdateMedicine(medicineId, newName, newDescription, newStock, newPrice))
            {
                return "Medicine not found";
            }
            return "Update Success";
        }
    }
}