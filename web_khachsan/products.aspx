<%@ Page Title="khách sạn" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="web_khachsan.products" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="small-container">
            <div class="row row-2">
                <h2><asp:Label ID="titleproducts" runat="server" Text="Tất cả phòng"></asp:Label></h2>
                <div class="dropdown"> 
                    <button class="dropbtn">Chọn <span class="ti-arrow-circle-down"</span></button>
                    <div class="dropdown-content">
                        <a href="products.aspx">Tất cả phòng</a>
                        <a href="products.aspx?type=1">Hue Hotel</a>
                        <a href="products.aspx?type=2">Timothy Homestay Hue</a>
                        <a href="products.aspx?type=3">Trường Tiền Hotel</a>
                        <a href="products.aspx?type=4">Melia Vinpearl Hotel Hue</a>
                    </div>
                </div>
            </div>

            <div class="row">
                <asp:ListView ID="ListViewAllProducts" runat="server">
                    <ItemTemplate>
                        <div class="col-4">
                        <a href="product-detail.aspx?id=<%# Eval("id") %>"><img src="<%# Eval("img") %>"/></a>
                        <h4 style="text-align:center"><%# Eval("name") %></h4>
                        <p style="text-align:center"><%# Eval("price") %> đ</p>
                        <p hidden="hidden"><%#Eval("type") %></p>
                    </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>

            <div class="page-btn">
                <span>1</span>
                <span>2</span>
                <span>3</span>
                <span>4</span>
                <span>&#8594;</span>
            </div>
        </div>
        
        <!-- JS-->
    <script>
        var MenuItems = document.getElementById("MenuItems");
        MenuItems.style.maxHeight = "0px";

        function menutoggle() {
            if (MenuItems.style.maxHeight == "0px") {
                MenuItems.style.maxHeight = "200px";
            } else {
                MenuItems.style.maxHeight = "0px";
            }
        }


        function search() {
            var searchBox = document.querySelector('.search-box');
            if (searchBox.style.display == "none") {
                searchBox.style.display = "block";
            } else {
                searchBox.style.display = "none";
            }

        }
    </script>
</asp:Content>
