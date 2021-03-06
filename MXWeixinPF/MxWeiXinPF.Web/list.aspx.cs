﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MxWeiXinPF.Common;
using MxWeiXinPF.Templates;

namespace MxWeiXinPF.Web
{
    public partial class list : TBasePage
    {
        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
           
            if (errInitTemplates != "")
            {
                Response.Write(errInitTemplates);
                return;
            }
            //1获得模版基本信息
            BLL.wx_templates tBll = new BLL.wx_templates();
            templateListFileName = tBll.GetLieBiaoTemplatesFileNameByWid(wid);
            if (templateListFileName == null || templateListFileName.Trim() == "")
            {
                templateListFileName = "type1";
            }
            tPath = MyCommFun.GetRootPath() + "/templates/list/" + templateListFileName + "/news_list.html";
            TemplateMgr template = new TemplateMgr(tPath, wid);
            template.tType = TemplateType.Class;
            template.openid = MyCommFun.RequestOpenid();
            template.OutPutHtml(templateListFileName, wid);

        }
    }
}