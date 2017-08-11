using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzureTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "The time this started is " + GlobalVariables.launchTime;
            
        }
    }

    public static class GlobalVariables
    {
       static DateTime? _launchTime=null;

        public static DateTime launchTime {
            get {
        if (!_launchTime.HasValue)
                {
                    _launchTime = DateTime.Now;
                }
                return _launchTime.Value;

            }
            }
        
    }
}