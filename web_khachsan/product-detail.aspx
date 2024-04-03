<%@ Page Title="Chi tiết phòng" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="product-detail.aspx.cs" Inherits="web_khachsan.product_detail" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<form runat="server">
    <!-- Single product details -->
        <div class="small-container single-product">
            <div class="row">
                
                <div class="col-2">
                        <asp:Image ID="productImg" runat="server" CssClass="" Width="100%" />

                    <!-- <div class="small-img-row">
                        <div class="small-img-col">
                            <img src="./images/thuc_an1.jpg" width="100%" class="small-img">
                        </div>
                        <div class="small-img-col">
                            <img src="./images/phukien1.jpg" width="100%" class="small-img">
                        </div>
                        <div class="small-img-col">
                            <img src="./images/spkhac2.jpg" width="100%" class="small-img">
                        </div>
                    </div> -->
                </div>
                

                <div class="col-2">
                    <p> <a href="index.aspx">Trang Chủ</a> / Chi tiết phòng</p>
                    <h1><asp:Label ID="name" runat="server" Text="Label"></asp:Label></h1>
                    <h4 style="color:red"><asp:Label ID="price" runat="server" Text="Label"></asp:Label>đ</h4>
                    <!--<select>
                        <option>Select Color</option>
                        <option>Silver</option>
                        <option>Gold</option>
                        <option>Titan</option>
                        <input type="number" value="1" name="number" runat="server" id="quantity" min="0">
                    </select>-->
                        
                    <!--<input type="number" value="1" min="0">-->
                    <h3>Hướng dẫn đặt phòng</h3>
                    <br>
                    <p>Bước 1: Nhập "khoảng thời gian" ở lại khách sạn</p>
                    <p>Bước 2: Nhập "số phòng</p>
                    <p>Bước 3: Bấm chọn ngày bắt đầu trong lịch ngày tháng</p>
                    <p>Bước 4: Bấm "Đặt ngay" và điền thông tin để hoàn tất đặt phòng</p>
                </div>
                
            </div>
        </div>
        <div class="small-container">
            <div class ="row" style="background-color:antiquewhite; padding:20px">
                <h2 style="width:100%; text-align:center">Đặt Phòng</h2>
                <form id="bookingForm">
                    <div class="col-2" style="padding:0 20px 0 20px">
                        <label for="name">Tên</label>
                        <input type="text" id="name" name="name" required />
                    </div>


                    <div class="col-2"style="padding:0 20px 0 20px">
                        <label for="checkin">Ngày Nhận Phòng:</label>
                        <input type="date" id="checkin" name="checkin" required>
                    </div>

                    <div class="col-2" style="padding:0 20px 0 20px">
                        <label for="phone">Số Điện Thoại:</label>
                        <input type="text" id="phone" name="phone" required>
                    </div>
                    
                    <div class="col-2" style="padding:0 20px 0 20px">
                        <label for="checkout">Ngày Trả Phòng:</label>
                        <input type="date" id="checkout" name="checkout" required>
                    </div>

                    <div class="col-2" style="padding:0 20px 0 20px">
                    <label for="numRooms">Số Phòng:</label>
                    <input type="number" id="numRooms" name="numRooms" required>
                    </div>

                    <div class="col-2" style="padding:0 20px 0 20px">
                    <asp:Button ID="btnthem" runat="server" CommandArgument='<%# Eval("id") %>' CssClass="btn" OnClick="btnthem_Click" Text="Đặt phòng ngay" style="width: 190px; height:100px; cursor: pointer" OnClientClick="addToCart()"/>
                    </div>
                </form>
            </div>
        </div>
                

<!--Title-->
        <div class="small-container">
            <div class="row row-2">
                <h2>Sản phẩm tương tự</h2>
                <p>Nhiều hơn</p>
            </div>
        </div>
<!--Product-->

        <div class="small-container">
        
            <div class="row">
                <div class="col-4" >
                    <a href="#">
                        <img src="./images/phong5.jpg"/>
                        <h4>Superior Garden View 5</h4>
                        <p>380000 đ</p>
                    </a>
                </div>
    
                <div class="col-4">
                    <a href="#">
                        <img src="./images/phong11.jpg"/>
                        <h4>Balcony Deluxe Garden 5</h4>
                        <p>450000 đ</p>
                    </a>
                </div>
    
                <div class="col-4">
                    <a href="#">
                        <img src="./images/phong18.jpg"/>
                        <h4>Family Deluxe Garden View 6</h4>
                        <p>500000 đ</p>
                    </a>
                </div>
            </div>
        </div>
 </form>
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

        //Prouduct Galery
        var productImg = document.getElementById("productImg");
        var smallImg = document.getElementsByClassName("small-img");

        smallImg[0].onclick = function () {
            productImg.src = smallImg[0].src;
        }
        smallImg[1].onclick = function () {
            productImg.src = smallImg[1].src;
        }
        smallImg[2].onclick = function () {
            productImg.src = smallImg[2].src;
        }

        function search() {
            var searchBox = document.querySelector('.search-box');
            if (searchBox.style.display == "none") {
                searchBox.style.display = "block";
            } else {
                searchBox.style.display = "none";
            }
        }

        function addToCart() {
            alert("Đặt phòng thành công!");
            
        }

    </script>
</asp:Content>
