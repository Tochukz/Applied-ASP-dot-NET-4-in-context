﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithRoutes
{
    public partial class CustomerList : System.Web.UI.Page
    {
        public List<Models.Customer> Customers;
        protected void Page_Load(object sender, EventArgs e)
        {
            Customers = Data.Repository.GetCustomers();
        }
    }
}