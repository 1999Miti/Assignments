using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using WebApplication8.Models;

public partial class _Default : System.Web.UI.Page
{
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    protected void Page_Load(object sender,EventArgs e)
    {
        log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/log4net.config")));

    }
    protected void ClickNLog(object sender,EventArgs e)
    {
        log.Warn("just clicked");
    }
}