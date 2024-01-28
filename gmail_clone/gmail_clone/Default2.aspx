<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="gmail_clone.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet2.css" type="text/css" rel="Stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="StyleSheet3.css" type="text/css" rel="Stylesheet" />
    <link href="SettingsStyle.css" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        #aboxr {
            width: 300px;
            height: auto;
            float: right;
            padding-right: 20px;
            padding-top: 20px;
        }

        .bt {
            width: 200px;
            padding: 6px;
            background-color: Black;
            border: 2px solid SILVER;
            border-radius: 5px;
            text-align: center;
            font-weight: bold;
            font-family: Calibri;
            font-size: 24px;
            color: Red;
        }

        .utxt {
            font-family: Verdana;
            color: White;
        }

        #next1 {
            width: 100%;
            height: 100px;
            background-color: Silver;
            border: 1px solid GRAY;
            margin: 80px auto;
        }

        #boxx1 {
            width: 900px;
            height: auto;
            margin: 0 auto;
        }

        .ix {
            width: 90px;
            height: 80px;
            border: 2px solid GRAY;
            border-radius: 10px;
        }

        .xb1 {
            font-family: Georgia;
            font-size: 16px;
            letter-spacing: 2px;
        }

        #lbx {
            width: 400px;
            height: auto;
            float: left;
        }

        #rbx {
            width: 450px;
            height: 80px;
            float: right;
            background-color: Gray;
            border: 1px solid BLACK;
            padding-top: 10px;
            border-bottom-left-radius: 30px;
            border-bottom-right-radius: 30px;
            box-shadow: 2px 2px 2px Black;
        }

        #rbx1 {
            width: 100%;
            height: 500px;
            background-color: ThreeDDarkShadow;
            border-bottom-left-radius: 30px;
            border-bottom-right-radius: 30px;
            box-shadow: 2px 2px Blue;
        }

        #rbx2 {
            width: 100%;
            height: 40px;
            background: linear-gradient(red,maroon);
            background: -webkit-linear-gradient(red,maroon);
            background: -moz-linear-gradient(red,maroon);
            box-shadow: 2px 2px Solid Blue;
            border-top-left-radius: 20px;
            border-top-right-radius: 20px;
        }

        #rbx3 {
            width: 100%;
            height: 30px;
        }

        #rbx4 {
            width: 100%;
            height: 40px;
            background: linear-gradient(red,maroon);
            background: -webkit-linear-gradient(red,maroon);
            background: -moz-linear-gradient(red,maroon);
            box-shadow: 2px 2px Solid Blue;
            border-top-left-radius: 20px;
            border-top-right-radius: 20px;
        }

        #rbx5 {
            width: 100%;
            height: 30px;
        }

        #rbx6 {
            width: 100%;
            height: 40px;
            background: linear-gradient(red,maroon);
            background: -webkit-linear-gradient(red,maroon);
            background: -moz-linear-gradient(red,maroon);
            box-shadow: 2px 2px Solid Blue;
            border-top-left-radius: 20px;
            border-top-right-radius: 20px;
        }

        #rbx8 {
            width: 100%;
            height: 40px;
            background: linear-gradient(red,maroon);
            background: -webkit-linear-gradient(red,maroon);
            background: -moz-linear-gradient(red,maroon);
            box-shadow: 2px 2px Blue;
        }

        #rbx9 {
            width: 99.5%;
        }

        #tab1 {
            float: right;
            padding-right: 20px;
        }

        #Button2 {
            border-radius: 5px;
            background-color: Red;
        }

        #Button3 {
            border-radius: 5px;
            background-color: Red;
        }

        #Button4 {
            border-radius: 5px;
            background-color: Red;
        }

        #tab {
            margin-left: auto;
            margin-right: auto;
        }

        #outer2 {
            width: 840px;
            height: auto;
            padding: 14px;
            border: 1px solid SILVER;
            margin-left: auto;
            margin-right:auto;
            background: linear-gradient(orange,red);
            background: -moz-linear-gradient(orange,red);
            background: -webkit-linear-gradient(orange,red);
            box-shadow: 1px 1px 10px BLACK;
        }

        #tx {
            width: 98%;
            height: auto;
            text-align: center;
            background-color: Silver;
            border: 1px solid GRAY;
            color: White;
            font-family: Verdana;
            font-weight: bold;
            letter-spacing: 2px;
        }

        .ctab {
            width: 100%;
            height: auto;
            border-collapse: collapse;
        }

            .ctab tr {
                height: 60px;
            }

            .ctab td {
                color: Black;
                font-weight: bold;
            }

        .ctxt {
            width: 98%;
            padding: 6px;
            border: 1px solid SILVER;
            box-shadow: 0px 0px 2px BLACK;
        }

        .ctxt1 {
            width: 98%;
            height: 300px;
            padding: 6px;
            border: 1px solid SILVER;
            box-shadow: 0px 0px 2px BLACK;
        }

        .cbt {
            width: 100px;
            padding: 6px;
            background-color: Maroon;
            border: 2px solid SILVER;
            color: White;
            font-size: 16px;
            font-weight: bold;
        }

        #chat1 {
            position: fixed;
            bottom: 60px;
            right: 20px;
            width: 250px;
            padding: 4px;
            height: 200px;
            border: 1px solid SILVER;
            overflow-y: scroll;
        }

        #chat3 {
            position: fixed;
            bottom: 260px;
            right: 20px;
            width: 250px;
            padding: 4px;
            height: 100px;
            border: 1px solid SILVER;
        }

        #chat2 {
            position: fixed;
            bottom: 10px;
            right: 20px;
            width: 250px;
            height: 40px;
            border: 1px solid GRAY;
        }

        .chat {
            border: 1px solid RED;
            width: 246px;
            height: 36px;
        }

        #b {
            position: absolute;
            float: right;
            right: 40px;
            width: 98px;
            height: auto;
            border-radius: 4px;
            box-shadow: 2px 2px 8px Yellow;
        }

        #Button3 {
            background-color: Aqua;
        }

        #ImageButton5 {
            position: absolute;
            float: right;
            right: 10px;
            top: 5px;
        }

        .cbox {
            width: 100%;
        }

            .cbox th {
                background-color: White;
                border: 0px;
            }

            .cbox td {
                border: 0px;
            }

        .style1 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div id="header">

            <div id="title">Qmail</div>


            <div id="aboxr">
        <table cellpadding="5" cellspacing="5">
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" CssClass="utxt"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Logout" CssClass="bt" OnClick="Button1_Click"  />
            </td>
        </tr>
        </table>
        </div>

        </div>

        <div id="next1">
            <div id="boxx1">

                <div id="lbx">
                    <table cellpadding="5" cellspacing="5">

                        <tr>
                            <td>
                                <a href="Default2.aspx">
                                    <asp:Image ID="Image1" runat="server" CssClass="ix" /></a>
                            </td>
                            <td valign="middle">
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>

                    </table>
                </div>

                <div id="rbx">
                    <table id="tab" cellspacing="3" cellpadding="3">
                        <tr>
                            <td>
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" Width="60px" src="inbox.png" OnClick="ImageButton1_Click" />
                                <br />
                                &nbsp;&nbsp;
                                <asp:Label ID="Label2" runat="server" Text="Inbox"></asp:Label>

                            </td>
                            <td>
                                <asp:ImageButton ID="ImageButton2" runat="server"
                                    Height="50px" Width="60px" src="send.png" OnClick="ImageButton2_Click" />
                                <br />
                                &nbsp;&nbsp;
                                Sent

                            </td>
                            <td>
                                <asp:ImageButton ID="ImageButton3" runat="server"
                                    Height="50px" Width="60px" src="draft.png" OnClick="ImageButton3_Click"/><br />
                                &nbsp;&nbsp;
                                Draft

                            </td>
                            <td>
                                <asp:ImageButton ID="ImageButton4" runat="server"
                                    Height="50px" Width="60px" src="mail-settings.png" OnClick="ImageButton4_Click1" /><br />
                                &nbsp;
                                <asp:Label ID="Label7" runat="server" Text="Setting"></asp:Label>
                            </td>
                         
                        </tr>
                    </table>

                </div>
            </div>
        </div>




        <div id="outer2">
            <div id="tx">Compose Your Mail</div>
            <table class="ctab" cellpadding="4" cellspacing="4" bgcolor="#FFFF99">
                <tr>
                    <td colspan="2">&nbsp;TO :<br />
                        <asp:TextBox ID="TextBox5" runat="server" Width="660px" Style="margin-left: 74px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">CC :<br />
                        <asp:TextBox ID="TextBox1" runat="server" Width="660px" Style="margin-left: 74px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">TITLE :<br />
                        <asp:TextBox ID="TextBox2" runat="server" Width="660px" Style="margin-left: 74px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">BODY :<br />
                        <asp:TextBox ID="TextBox3" runat="server" Width="660px" Height="150px" Style="margin-left: 74px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Attachment :<br />
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="303px" Style="margin-left: 74px" /></td>
                        <td class="btns" align="right" colspan="2" style="
                        display: grid;
                        grid-template-columns: auto auto;
                        gap: 10px;">
                        <asp:Button ID="Button4" runat="server" Text="Save" OnClick="Button4_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Sent" OnClick="Button2_Click" />
                    </td>

                </tr>
            </table>
        </div>


        <!---layer for settings--->
       <%-- <div id="layers" runat="server"></div>
        <div id="outers" runat="server">
            <div id="x" runat="server">
                <a id="ImageButton5" href="Default2.aspx">
                    <img alt="cancel" height="20px" width="20px" /></a>
            </div>
            <div id="inners" runat="server">
                <div id="t" runat="server">
                    <table id="t1" cellspacing="4" cellpadding="4" runat="server">

                        <tr>
                            <td class="style1">Password:</td>
                            <td class="style1">
                                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Phone:</td>
                            <td>
                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Photo:</td>
                            <td>
                                <asp:ImageButton ID="Image2" runat="server" Height="40px" Width="40px" /></td>
                        </tr>
                    </table>
                    <asp:FileUpload ID="FileUpload2" runat="server" /><br />
                    <br />
                    <div id="b">
                        <asp:Button ID="Button3" runat="server" />
                    </div>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>--%>
    </form>
</body>
</html>

