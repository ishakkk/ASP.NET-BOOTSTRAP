<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazokuluDerler.OgrenciGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
      
         <div class="form-group">


            <strong>


            <asp:Label for="TxtId" runat="server" Text="ID"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="form-group">


            <strong>


            <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div class="form-group">


            <strong>


            <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

         <br />
        <div class="form-group">


            <strong>


            <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numarası"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

         <br />
        <div class="form-group">


            <strong>


            <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifresi"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
         <br />
        <div class="form-group">


            <strong>


            <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğrafı"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>

        </div>



        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>
