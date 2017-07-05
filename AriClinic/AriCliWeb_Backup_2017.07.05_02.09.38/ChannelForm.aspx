<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChannelForm.aspx.cs" Inherits="ChannelForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>
            Canal
        </title>
        <telerik:RadStyleSheetManager id="RadStyleSheetManager1" runat="server" />
        <link href="AriClinicStyle.css" rel="stylesheet" type="text/css" />
        <link rel="shortcut icon" type="image/x-icon" href="favicon.ico"/>
    </head>
    <body>
        <form id="form1" runat="server">
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
                <Scripts>
                    <%--Needed for JavaScript IntelliSense in VS2010--%>
                    <%--For VS2008 replace RadScriptManager with ScriptManager--%>
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                    <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
                </Scripts>
            </telerik:RadScriptManager>
            <script type="text/javascript" src="GeneralFormFunctions.js">
                //Put your JavaScript code here.
            </script>
            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            </telerik:RadAjaxManager>
            <telerik:RadSkinManager ID="RadSkinManager1" Runat="server" Skin="Office2007">
            </telerik:RadSkinManager>
            <telerik:RadInputManager ID="RadInputManager1" runat="server">
                <telerik:TextBoxSetting Validation-IsRequired="true">
                    <TargetControls>
                        <telerik:TargetInput ControlID="txtName" />
                    </TargetControls>
                </telerik:TextBoxSetting>
            </telerik:RadInputManager>
            <telerik:RadToolTipManager ID="RadToolTipManager1" runat="server" 
                                       AutoTooltipify="true" RelativeTo="Element" Position="TopCenter">
            </telerik:RadToolTipManager>
            <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" Height="210px" 
                                  Width="420px" 
                                  style="z-index: 1; left: 0px; top:0px; position: absolute; height: 231px; width: 420px">
                <table width="100%">
                    <tr>
                        <td colspan="6">
                            <div id="TitleArea" class="titleBar2">
                                <img alt="minilogo" src="images/mini_logo.png" align="middle" />
                                <asp:Label ID="lblTitle" runat="server" Text="Canal"></asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <div id="ChannelId" class="normalText">
                                <asp:Label ID="lblChannelId" runat="server" Text="ID:" 
                                           ToolTip="Identificador de canal, lo usa internamente el sistema"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtChannelId" runat="server" Enabled="false" Width="89px"></asp:TextBox>
                            </div>
                        </td>
                        <td colspan="4">
                            <div id="Name" class="normalText">
                                <asp:Label ID="lblName" runat="server" Text="Nombre del canal:" 
                                           ToolTip="Nombredel canal"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtName" runat="server" Width="287px" TabIndex="1"></asp:TextBox>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                            <div ID="Message" class="messageText">
                                <asp:Label ID="lblMessage" runat="server" Text="Mensajes:"></asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                            <div ID="Buttons" class="buttonsFomat">
                                <asp:ImageButton ID="btnAccept" runat="server" 
                                                 ImageUrl="~/images/document_ok.png" onclick="btnAccept_Click" ToolTip="Guardar y salir" TabIndex="4" />
                                &nbsp;
                                <asp:ImageButton ID="btnCancel" runat="server" 
                                                 ImageUrl="~/images/document_out.png" CausesValidation="False" 
                                                 onclick="btnCancel_Click" ToolTip="Salir sin guardar" TabIndex="5" />
                            </div>
                        </td>
                    </tr>
                </table>

            </telerik:RadAjaxPanel>
        </form>
    </body>
</html>
