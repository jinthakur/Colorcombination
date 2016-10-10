<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits=".WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server"><asp:scriptmanager runat="server"></asp:scriptmanager>
    <div>
    <table>
                                        <tr>
                                            <td> Min  value color: </td>
                                        </tr>
                                        <tr valign="top">
                                            <td>
                                                <telerik:RadColorPicker ShowIcon="true" RenderMode="Lightweight" runat="server" ID="RadColorPickerMin" SelectedColor="#ffff99" PaletteModes="All" CssClass="ColorPickerPreview"
                                                    KeepInScreenBounds="true" AutoPostBack="False" meta:resourcekey="RadColorPickerMin">
                                                </telerik:RadColorPicker>
                                            </td>
                                        </tr>
                                        <tr valign="top">
                                            <td> Max  value color:  </td>
                                        </tr>
                                        <tr valign="top">
                                            <td>
                                                <telerik:RadColorPicker ID="RadColorPickerMax" ShowIcon="true" runat="server" AutoPostBack="False" CssClass="ColorPickerPreview" SelectedColor="#33cc33" KeepInScreenBounds="true" PaletteModes="All" RenderMode="Lightweight" meta:resourcekey="RadColorPickerMax">
                                                </telerik:RadColorPicker>
                                                <asp:Button ID="Button1" runat="server" Text="Button" />
                                                <br />
                                                <asp:ListBox ID="ListBox1" runat="server" Width ="100px"></asp:ListBox>
                                                <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                                            </td>
                                        </tr>
                                    </table>
    </div>
    </form>
</body>
</html>
