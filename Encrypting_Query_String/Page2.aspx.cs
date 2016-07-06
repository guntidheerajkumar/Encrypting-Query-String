using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encrypting_Query_String
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EncryptedQueryString args = new EncryptedQueryString(Request.QueryString["args"]);
            Response.Write(string.Format("arg1={0}, arg2={1}", args["arg1"], args["arg2"]));
        }
    }
}