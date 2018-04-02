﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="template_bottom_list.aspx.cs" Inherits="MxWeiXinPF.Web.admin.templates.template_bottom_list" %>

<%@ Import Namespace="MxWeiXinPF.Common" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>底部模版列表</title>
    <script type="text/javascript" src="../../scripts/jquery/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../../scripts/jquery/jquery.lazyload.min.js"></script>
    <script type="text/javascript" src="../../scripts/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="../js/layout.js"></script>
    <link href="../skin/default/style.css" rel="stylesheet" type="text/css" />
    <link href="../../css/pagination.css" rel="stylesheet" type="text/css" />
    <link href="../skin/mystyle.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {

            $("#btnSave").click(function () {
                var list = $('input:radio[name="gTemplate"]:checked').attr("tip");
                if (list == null) {

                    $("#txtSelectTemplateId").val("15");
                }
                else {
                    $("#txtSelectTemplateId").val(list);
                }

               

            });




        });


    </script>
</head>

<body class="mainbody">
    <form id="form1" runat="server">
        <!--导航栏-->
        <div class="location">
            <a class="home"><i></i><span>底部菜单风格列表</span></a>
            <asp:HiddenField ID="hidWTId" runat="server" Value="0" />
            <asp:TextBox ID="txtSelectTemplateId" runat="server" Text="0" Style="display: none;"></asp:TextBox>
        </div>
        <!--/导航栏-->

        <!--tab-->
        <div class="content-tab-wrap">
            <div id="floatHead" class="content-tab">
                <div class="content-tab-ul-wrap">
                    <ul>
                         <li><a href="../article/category_bottomMenu_list.aspx?channel_id=7" >底部菜单管理</a></li>
                        <li><a href="javascript:;" onclick="tabs(this);" class="selected">底部菜单风格</a></li>
                      <%--   <li><a href="javascript:;" onclick="tabs(this);">二级页面模版</a></li>
                        <li><a href="javascript:;" onclick="tabs(this);">颜色选择</a></li>--%>
                    </ul>
                </div>
            </div>
        </div>

        <!--/tab-->

        <div class="tab-content">
            <!--图片列表-->
            <asp:Repeater ID="rptList2" runat="server" OnItemCommand="rptList_ItemCommand">
                <HeaderTemplate>
                    <div class="templatelist" style=" width:1000px;margin:0 auto;">
                        <ul>
                </HeaderTemplate>
                <ItemTemplate>
                    <li>
                        <div class="templatelidiv">
                            <label for='<%#"rad"+Eval("id")%>'>
                                <asp:Image ID="Image1" runat="server" ImageUrl=' <%#Eval("aboutPic")%>' />

                                <div class="templateName" style="height: 20px; padding-top: 5px;">
                                    <%# "<input id=\"rad"+Eval("id")+"\" type=\"radio\" name=\"gTemplate\" tip=\""+Eval("id")+"\" /> "%>
                                    <%#Eval("tName")%>
                                </div>
                            </label>
                        </div>
                    </li>
                </ItemTemplate>
                <FooterTemplate>
                    <%#rptList2.Items.Count == 0 ? "<div align=\"center\" style=\"font-size:12px;line-height:30px;color:#666;\">暂无模版</div>" : ""%>
              </ul>
            </div>
                </FooterTemplate>
            </asp:Repeater>
            <!--/图片列表-->
        </div>
         
         
        <!--工具栏-->
        <div class="page-footer">
            <div class="btn-list">
                <asp:Button ID="btnSave" runat="server" Text="提交保存" CssClass="btn" OnClick="btnSave_Click" />
            </div>
            <div class="clear"></div>
        </div>
        <!--/工具栏-->
    </form>
</body>
</html>

