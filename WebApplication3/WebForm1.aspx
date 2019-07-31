
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
<title>QrCode</title>
</head> 
<body>
    <div class="container">
        <div class="col-md-4">
          <h3>ADA MÜHENDİSLİK DOĞALGAZ - GÜLŞEN AKÇELİK</h3>  

  <p>Adres :KURUÇEŞME MAH. 205/3 SOK. NO:10/A BUCA / İZMİR - BUCA</p>

 <p> Faaliyet :PROJE İÇ TESİSAT YAPIM, BAKIM-ONARIM</p>

 <p>Telefon : 453 27 32 - 0507 291 65 64</p> 

  <p>Faks : 454 00 08</p>
<p>Mail:ada@gmail.com</p>
  Web Adresi : <asp:Label ID="Label1" runat="server" Text="Label">www.Adamuhendislik.com</asp:Label>
           
        </div>
        <div class="col-md-4">
            <br />
            <br />
            <br />
            <hr />
              <form id="form1" runat="server">
                  <asp:DropDownList style="margin-left:115px;" ID="DropDownList1" runat="server">
                      <asp:ListItem Value="350" Text="350x350" />
                      <asp:ListItem Value="500" Text="500x500" />
                       <asp:ListItem Value="750" Text="750x750" />
                       <asp:ListItem Value="1000" Text="1000x1000" />
                  </asp:DropDownList>
                 <!--<asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>-->
                  
            <br />
            <br />
            <br />
       <hr />
            <asp:Button style="margin-left:130px;" ID="Button1" runat="server" Class="btn btn-success" Text="Button" OnClick="Button1_Click" />
         
            <hr />
       
           
         
    </form>
        </div>
        <div class="col-md-4">
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
  
     </div>

</body>
</html>
