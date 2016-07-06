using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encrypting_Query_String
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void _BtnRedirect_Click(object sender, EventArgs e)
        {
            EncryptedQueryString args = new EncryptedQueryString();
            args["arg1"] = "val1";
            args["arg2"] = "val2";
            Response.Redirect(String.Format("Page2.aspx?args={0}", args.ToString()));
        }
    }
}