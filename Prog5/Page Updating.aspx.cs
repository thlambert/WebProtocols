﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog1.Prog5
{

    
    public partial class Page_Updating : System.Web.UI.Page
    {
        private const string ConStr = "Data Source=Alpha;" +
            "Initial Catalog = UWPCS3870; Persist Security Info=True;" +
            "User ID = MSCS; Password=MasterInCS";
        private static System.Data.SqlClient.SqlDataAdapter prodAdapter;
        private static System.Data.SqlClient.SqlCommand prodCmd = new System.Data.SqlClient.SqlCommand();
        private static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.DataTable tblProduct = new System.Data.DataTable("Product");
        protected void Page_Load(object sender, EventArgs e)
        {
            //SQLDataClass.getAllProducts();
            //dtlProduct.DataSource = SQLDataClass.tblProduct;
            //dtlProduct.DataBind();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            dtlProduct.PageIndex = e.NewPageIndex;
            dtlProduct.DataBind();
        }

        protected void dtlProduct_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {

        }

        protected void dtlProduct_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {

        }
    }
}