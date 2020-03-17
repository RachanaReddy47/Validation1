﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation1
{
    public partial class MyMaster3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
                Response.Write("Welcome " + Request.Cookies["name"].Value);                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Expires = DateTime.Now.AddSeconds(1);
            Response.Redirect("Login.aspx");


        }
    }
}