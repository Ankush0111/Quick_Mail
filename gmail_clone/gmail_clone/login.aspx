<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="gmail_clone.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="styleSheet1.css" />
    <link
      href="https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,300;1,500&display=swap"
      rel="stylesheet"
    />
    <link
      rel="stylesheet"
      href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
    />
    <title>Log In</title>
    <style>
    .login2 {
        display: grid;
        grid-template-columns: auto auto;
        background-color: white;
        border-radius: 25px;
        padding: 50px;
        width: 1415px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
        margin-left: 55px;
        margin-top: 100px;
    }
    .logo img {
        width: 400px;
        height: auto;
    }
        #Button1 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <%--<div class="full">--%>
      <div class="login2">
        <div class="info">
          <div class="logo">
            <img src="qmail.jpg" alt="">
          </div>
          <br />
         <p>Welcome to the world of Communications.</p>
         <p><span id="element"></span></p>
        </div>
        <!--login container-->
        <div class="login_contain">
          <div class="heading">
            <h1>Sign In</h1>
          </div>
          <div class="forms">
            <div class="email">
              <h4>Email</h4>
            </div>
            <div class="input1">
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Name"></asp:TextBox>
            </div>
            <div class="psw">
              <h4>Enter Password</h4>
            </div>
            <div class="input2">
                <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Pasword" type="password"></asp:TextBox>
            </div>
          </div>
            <div class="input2">
                    <a href="Default.aspx" />Have not an account! Sign Up</a>
            </div>
            <div class="submit">
                <asp:Button ID="Button1" runat="server" Text="Log In" Width="100%" Height="43px" OnClick="Button1_Click"/>            
            </div>
          </div>
        </div>
      <%--</div>--%>
    <script src="https://unpkg.com/typed.js@2.0.16/dist/typed.umd.js"></script>
    <script>
        var typed = new Typed("#element", {
            strings: ["Send your mails fast to your recipient."],
            typeSpeed: 40,
        });
    </script>
    </form>
</body>
</html>
