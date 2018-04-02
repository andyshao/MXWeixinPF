﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mz_img_list.aspx.cs" Inherits="MxWeiXinPF.Web.admin.magazine.mz_img_list" %>

<%@ Import Namespace="MxWeiXinPF.Common" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>首页幻灯片列表</title>
    <script type="text/javascript" src="../../scripts/jquery/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../../scripts/jquery/jquery.lazyload.min.js"></script>
    <script type="text/javascript" src="../../scripts/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="../js/layout.js"></script>
    <link href="../skin/default/style.css" rel="stylesheet" type="text/css" />
    <link href="../../css/pagination.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            imgLayout();
            $(window).resize(function () {
                imgLayout();
            });
            //图片延迟加载
            $(".pic img").lazyload({ load: AutoResizeImage, effect: "fadeIn" });
            //点击图片链接
            $(".pic img").click(function () {
                //$.dialog({ lock: true, title: "查看大图", content: "<img src=\"" + $(this).attr("src") + "\" />", padding: 0 });
                var linkUrl = $(this).parent().parent().find(".foot a").attr("href");
                if (linkUrl != "") {
                    location.href = linkUrl; //跳转到修改页面
                }
            });

            //创建图文的窗口 
            $("#aLookIndex").click(function () {
                console.log("begin");
                var contenturl = "url:templates/showPhone.aspx";
                var m = $.dialog({
                    id: 'dialogGuiZe',
                    fixed: true,
                    lock: true,
                    max: false,
                    min: false,
                    title: "查看模版效果",
                    content: contenturl,
                    height: 600,
                    width: 420,
                    close: function () {
                        this.reload();
                    }
                });
                console.log("end");
            })

        });
        //排列图文列表
        function imgLayout() {
            var imgWidth = $(".imglist").width();
            var lineCount = Math.floor(imgWidth / 222);
            var lineNum = imgWidth % 222 / (lineCount - 1);
            $(".imglist ul").width(imgWidth + Math.ceil(lineNum));
            $(".imglist ul li").css("margin-right", parseFloat(lineNum));
        }
        //等比例缩放图片大小
        function AutoResizeImage(e, s) {
            var img = new Image();
            img.src = $(this).attr("src")
            var w = img.width;
            var h = img.height;
            var wRatio = w / h;
            if ((220 / wRatio) >= 165) {
                $(this).width(220); $(this).height(220 / wRatio);
            } else {
                $(this).width(165 * wRatio); $(this).height(165);
            }
        }
    </script>
</head>

<body class="mainbody">
    <form id="form1" runat="server">
        <!--导航栏-->
        <div class="location">
            <a class="home" href="magazien_list.aspx"><i></i><span>杂志列表</span></a>
            <i class="arrow"></i>
            <a href="javascript:void(0);"><span>杂志图片列表</span></a>
        </div>
        <!--/导航栏-->

        <!--工具栏-->
        <div class="toolbar-wrap">
            <div id="floatHead" class="toolbar">
                <div class="l-list">
                    <ul class="icon-list">
                        <li><a class="add" href="mz_img_edit.aspx?action=<%=MXEnums.ActionEnum.Add %>&mzid=<%=mzid %>"><i></i><span>新增</span></a></li>
                        <li>
                            <asp:LinkButton ID="btnSave" runat="server" CssClass="save" OnClick="btnSave_Click"><i></i><span>保存</span></asp:LinkButton></li>
                        <li><a class="all" href="javascript:;" onclick="checkAll(this);"><i></i><span>全选</span></a></li>
                        <li>
                            <asp:LinkButton ID="btnDelete" runat="server" CssClass="del" OnClientClick="return ExePostBack('btnDelete');" OnClick="btnDelete_Click"><i></i><span>删除</span></asp:LinkButton></li>
                    </ul>
                </div>
            </div>
        </div>
        <!--/工具栏-->
        <!--图片列表-->
        <asp:Repeater ID="rptList2" runat="server">
            <HeaderTemplate>
                <div class="imglist">
                    <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    <div class="details<%#Eval("url").ToString() != "" ? "" : " nopic"%>">
                        <div class="check">
                            <asp:CheckBox ID="chkId" CssClass="checkall" runat="server" /><asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" />
                        </div>
                        <%#Eval("url").ToString() != "" ? "<div class=\"pic\"><img src=\"../skin/default/loadimg.gif\" data-original=\"" + Eval("url") + "\" /></div><i class=\"absbg\"></i>" : ""%>
                        <%--<h1><span><%#Eval("title")%></span></h1>--%>
                        <%-- <div class="remark" style="height: 20px;">
                            <%#Eval("zhaiyao").ToString() == "" ? "暂无描述说明..." : Eval("zhaiyao").ToString()%>
                        </div>--%>
                        <div class="tools">
                            <asp:TextBox ID="txtSortId" runat="server" Text='<%#Eval("sort_id")%>' CssClass="sort" onkeypress="return (/[\d]/.test(String.fromCharCode(event.keyCode)));" />
                            <span style="float: right; line-height: 26px; font-size: 12px;">排序：</span>
                        </div>
                        <div class="foot">
                            <p class="time"><%#string.Format("{0:yyyy-MM-dd HH:mm:ss}", Eval("createDate"))%></p>
                            <a href="mz_img_edit.aspx?action=<%#MXEnums.ActionEnum.Edit %>&mzid=<%=mzid %>&id=<%#Eval("id")%>" title="编辑" class="edit">编辑</a>
                        </div>
                    </div>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                <%#rptList2.Items.Count == 0 ? "<div align=\"center\" style=\"font-size:12px;line-height:30px;color:#666;\">暂无记录</div>" : ""%>
  </ul>
</div>
            </FooterTemplate>
        </asp:Repeater>
        <!--/图片列表-->

        <!--内容底部-->
        <div class="line20"></div>
        <div class="pagelist">
            <div class="l-btns">
                <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" CssClass="pagenum" onkeydown="return checkNumber(event);" OnTextChanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
            </div>
            <div id="PageContent" runat="server" class="default"></div>
        </div>
        <!--/内容底部-->
    </form>
</body>
</html>
