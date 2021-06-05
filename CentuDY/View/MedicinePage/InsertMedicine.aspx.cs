﻿using CentuDY.Controller;
using CentuDY.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.MedicinePage
{
    public partial class InsertMedicine : System.Web.UI.Page
    {
        static string name;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            name = NameTxt.Text;
            string description = DescTxt.Text;
            string strStock = StockTxt.Text;
            string strPrice = PriceTxt.Text;

            if (name == "" || description == "" || strStock == "" || strPrice == "")
            {
                LblMessage.Text = MedicineController.AddMedicine(name,description,strStock,strPrice);
                LblMessage.Visible = true;
            }
            else
            {
                LblMessage.Text= MedicineController.AddMedicine(name, description, strStock, strPrice);
                LblMessage.Visible = true;         
            }
        }
    }
}