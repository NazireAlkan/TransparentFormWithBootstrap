<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TransparentDeneme.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Deneme</title>
    <link href="css.css" rel="stylesheet" />
    <link href="Bootsrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Bootsrap/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="bg-image">
            <div class="container min-vh-100 d-flex justify-content-center align-items-center">
                 <div class="form formclass shadow-lg-custom p-4 pb-2">
                    <div class="labelclass">
                        <label for="exampleInputEmail" runat="server" class="form-label labelclass mb-1">E-mail</label>
                        <asp:TextBox ID="exampleInputEmail" runat="server" TextMode="Email" CssClass="form-control transparent-texbox mb-1" aria-describedby="emailHelp"></asp:TextBox>
                        <div id="emailHelp" class="form-text mb-3">We'll never share your email with anyone else.</div>
                    </div>
                    <div class="labelclass">
                        <label for="exampleInputPassword1" runat="server" class="form-label labelclass mb-1">Password</label>
                        <asp:TextBox ID="exampleInputPassword1" runat="server" TextMode="Password" CssClass="form-control transparent-texbox mb-4"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Button ID="BtnRegister" runat="server" CssClass ="btn btn-outline-dark buttonclass btn-sm mb-3"  style="text-align:center; display: block;" Text="Register Me" OnClick="Button1_Click" />
                        
                    </div>
                     <div class="labelclass text-center">
                         <strong><asp:Label ID="Label1" runat="server" CssClass=" text-dark"></asp:Label></strong>
                     </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
                    
                    