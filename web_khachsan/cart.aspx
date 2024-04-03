<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="web_khachsan.cart" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!--Cart-->
    <div class="small-container cart-page">
        <form id="formcart" runat="server">
            Bạn có: <asp:Label ID="TotalProduct" runat ="server"></asp:Label> sản phẩm
            <table>
                <tr>
                    <th>STT</th>
                    <th>Sản phẩm</th>
                    <!--<th>Số lượng</th>-->
                    <th>Đơn giá</th>
                </tr>
                <asp:ListView ID="cartList" runat ="server">
                    <ItemTemplate>
                        <tr runat="server">
                            <td><%# Container.DataItemIndex + 1 %></td>
                            <td>
                                <div class="cart-info">
                                    <img src="<%# Eval("img") %>" alt="product image" >
                                    <div>
                                         <p><%# Eval("name") %></p>
                                         <a href="product-detail.aspx?id=<%# Eval("id") %>">Thông tin chi tiết</a><br />
                                         <small>Giá: <%# Eval("price") %> đ</small>
                                         <br>
                                         <asp:Button runat="server" OnClick="btnRemove_Click" CommandArgument='<%# Eval("id") %>' Text="Xóa" BackColor="#35D0BA" ForeColor="White" CssClass="btn-remove"/>
                                     </div>
                                 </div>
                            </td>
                           
                            <td><%# Eval("price") %> đ</td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
                    
                </table>

                <div class="total-price">
                    <table>
                        <tr>
                            <td>Thuế</td>
                            <td>0 đ</td>
                        </tr>
                        <tr>
                            <td>Tổng tiền</td>
                            <td><asp:Label ID="TotalPriceProduct" runat="server" Text="Total"></asp:Label> đ</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button runat="server" CssClass="btn" CommandArgument='<%# Eval("id") %>' Text="Thanh toán &#8594;" OnClick="btnCheckout_Click" />
                                <!--<a href="" class="btn">Proceed To Checkout &#8594;</a>-->
                            </td>
                        </tr>
                        </table>
                    </div>
        </form>
    </div>
    <!-- JS-->
    <script>
        //Menu
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
