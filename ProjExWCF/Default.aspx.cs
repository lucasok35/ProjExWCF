﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjExWCF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicoWCF.ServicoClient wcf = new ServicoWCF.ServicoClient();
            GridView1.DataSource = wcf.Consultar("");
            GridView1.DataBind();

        }
    }
}