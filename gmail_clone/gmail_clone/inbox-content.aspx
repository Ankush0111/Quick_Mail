<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inbox-content.aspx.cs" Inherits="gmail_clone.inbox_content" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="StyleSheet2.css" type="text/css" rel="Stylesheet" />
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link href="StyleSheet3.css" type="text/css" rel="Stylesheet" />
        <link href="SettingsStyle.css" type="text/css" rel="Stylesheet" />
    <link href="StyleSheet.css" type="text/css" rel="Stylesheet" />
      <style type="text/css">
     
     #aboxr
     {
         width:300px;
         height:auto;
         float:right;
         padding-right:20px;
         padding-top:20px;
     }
     .bt
     {
         width:200px;
        padding:6px;
        background-color:Black;
        border:2px solid SILVER;
        border-radius:5px;
        text-align:center;
        font-weight:bold;
        font-family:Calibri;
        font-size:24px;
        color:Red;
     }
     .utxt
     {
         font-family:Verdana;
         color:White;
     }
     #next1
     {
         width:100%;
         height:100px;
         background-color:Silver;
         border:1px solid GRAY;
         margin:80px auto;
     }
     #boxx1
     {
         width:900px;
         height:auto;
         margin:0 auto;
     }
     .ix
     {
         width:90px;
         height:80px;
         border:2px solid GRAY;
         border-radius:10px;
     }
     .xb1
     {
         font-family:Georgia;
         font-size:16px;
         letter-spacing:2px;
     }
     #lbx
     {
         width:400px;
         height:auto;
         float:left;
     }
     #rbx
     {
         width:450px;
         height:80px;
         float:right;
         background-color:Gray;
         border:1px solid BLACK;
         padding-top:10px;
         border-bottom-left-radius:30px;
         border-bottom-right-radius:30px;
         box-shadow:2px 2px 2px Black;
     }
     #rbx1
     {
     width:100%;
     height:500px;
     background-color:ThreeDDarkShadow;
     border-bottom-left-radius:30px;
     border-bottom-right-radius:30px;
     box-shadow:2px 2px Blue; 
      
     }
     #rbx2
     {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Solid Blue;
         border-top-left-radius:20px;
         border-top-right-radius:20px;
         
     }
     #rbx3
     {
     width:100%;
     height:30px;    
     }
     #rbx4
     {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Solid Blue;
         border-top-left-radius:20px;
         border-top-right-radius:20px;
         
     }
     #rbx5
      {
     width:100%;
     height:30px;    
     }
     #rbx6
     {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Solid Blue;
         border-top-left-radius:20px;
         border-top-right-radius:20px;
         
     }
     #rbx8
      {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Blue;
     }
     #rbx9
     {
      width:99.5%;   
     }
     #tab1
     {
      float:right;
      padding-right:20px;   
     }
     #Button2
     {
     border-radius:5px;
     background-color:Red;    
     }
     #Button3
     {
     border-radius:5px;
     background-color:Red;    
     }
     #tab
     {
      float:left;   
      padding-left:80px;  
      }
      #outer2
      {
          width:840px;
          height:auto;
          padding:14px;
          border:1px solid SILVER;
          margin:0 auto;
          background:linear-gradient(orange,red);
          background:-moz-linear-gradient(orange,red);
          background:-webkit-linear-gradient(orange,red);
          box-shadow:1px 1px 10px BLACK;
      }
      #tx
      {
          width:98%;
          height:auto;
          text-align:center;
          background-color:Silver;
          border:1px solid GRAY;
          color:White;
          font-family:Verdana;
          font-weight:bold;
          letter-spacing:2px;
      }
      .grid
      {
          width:90%;
          margin:0 auto;
          text-align:center;
      }
      #boxi
      {
       position:fixed;
       top:250px;
       left:300px;
        height:300px;
        width:600px; 
        background:linear-gradient(red,maroon);
        background:-moz-linear-gradient(red,maroon); 
        background:-webkit-linear-gradient(red,maroon);
        border:2px Black;
        border-radius:20px;
        opacity:0.7;
       }
      #content {
            width: 50%;
            margin: 0 auto;
            margin-top: 50px; /* Adjust the top margin as needed */
            background-color: #ffffff;
            padding: 20px;
            border: 1px solid #cccccc;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: left; /* Adjust text alignment if needed */
        }
         </style>

</head>
<body>
    <form id="form1" runat="server">
    
        <div id="header">
    
        <div id="title">Quick Mail</div>
        
        
        <div id="aboxr">
        <table cellpadding="5" cellspacing="5">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" CssClass="utxt"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Logout" CssClass="bt"  />
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
                    <asp:Image ID="Image1" runat="server" CssClass="ix" />
                </td>
                <td valign="middle">
                
                    <asp:Label ID="Label2" runat="server" CssClass="xb1"></asp:Label>
                
                </td>
            </tr>
        
        </table>
        </div>

        <div id="rbx">
        <table id="tab" cellspacing="3" cellpadding="3">
        <tr>
        <td>
         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="inbox.png" 
                Height="50px" Width="60px"/><br />
           &nbsp;&nbsp; <asp:Label ID="Label7" runat="server" Text="Inbox"></asp:Label>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="send.png" 
                    Height="50px" Width="60px" /><br />
                <asp:Label ID="Label8" runat="server" Text="Sent Items"></asp:Label>
            </td>
           <td>
               <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="draft.png"
                   Height="50px" Width="60px" /><br />
               &nbsp;&nbsp;
               <asp:Label ID="Label9" runat="server" Text="Drafts"></asp:Label>
           </td> 
           <td>
               <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="mail-settings.png" 
                   Height="50px" Width="60px" /><br />
               &nbsp;
               <asp:Label ID="Label10" runat="server" Text="Settings"></asp:Label>
           </td>
        </tr>
        </table>
        
        </div>
        </div>
    </div>
   
        <div id="content">
            <div>
                <h2>Title:</h2>
                <asp:Label ID="lblTitle" runat="server" CssClass="xb1"></asp:Label>
            </div>
            <div>
                <h2>Body:</h2>
                <asp:Label ID="lblBody" runat="server" CssClass="xb1"></asp:Label>
            </div>
            <div>
                <h2>Date:</h2>
                <asp:Label ID="lblDate" runat="server" CssClass="xb1"></asp:Label>
            </div>
            <div>
                <h2>Attachment URL:</h2>
                <asp:HyperLink ID="hlAttachment" runat="server" CssClass="xb1"></asp:HyperLink>
            </div>
        </div>


    </form>
</body>
</html>
