<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListele.aspx.cs" Inherits="YazokuluDerler.OgrenciListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID
            </th>
            <th>Öğrenci Ad
            </th>
            <th>Öğrenci Soyad
            </th>
            <th>Öğrenci Numara
            </th>
            <th>Öğrenci Şifre
            </th>
            <th>Öğrenci Fotoğraf</th>
            <th>Bakiye</th>
            <th>İşlemler</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("Ad")%></td>
                        <td><%#Eval("Soyad")%></td>
                        <td><%#Eval("Numara")%></td>
                        <td><%#Eval("Sifre")%></td>
                        <td><%#Eval("FOTO")%></td>
                        <td><%#Eval("Bakiye")%></td>   
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.aspx?OGRID="+ Eval("ID")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OGRID="+ Eval("ID")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
