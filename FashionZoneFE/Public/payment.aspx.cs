﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FashionZone.FE.Public
{
    public partial class payment : Utils.BasePage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            ((PublicMaster)Master).SetImgBackground("", "ContentIII");
		}
	}
}