using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Claims : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var enterprisePrincipal = User as Accenture.Security.Eso.Web.IEnterprisePrincipal;
        var enterpriseIdentity = enterprisePrincipal.EnterpriseIdentity;
        Response.Write(string.Format("Enterprise ID = {0}", enterpriseIdentity.EnterpriseId ));
    }
}