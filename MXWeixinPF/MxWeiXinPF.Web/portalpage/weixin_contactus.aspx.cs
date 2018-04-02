﻿using MxWeiXinPF.Common;
using MxWeiXinPF.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MxWeiXinPF.Web.portalpage
{
    public partial class weixin_contactus : PortalBasePage
    {
        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (errInitTemplates != "")
            {
                Response.Write(errInitTemplates);
                return;
            }


            tPath = MyCommFun.GetRootPath() + "/templates_portal/aboutus.html";
            PortalTemplate template = new PortalTemplate(tPath);
            template.tType = TemplateType.News;

            template.OutPutHtml(templateIndexFileName);
        }
    }
}