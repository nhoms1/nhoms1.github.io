<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="web_khachsan.index" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="margin-top:-30px">
        <div class="col-2">
            <div class="slideshow-container">
                <div class="mySlides fade">
                  <div class="numbertext">1 / 4</div>
                    <img src="images/banner01.jpg" />
                </div>

                <div class="mySlides fade">
                  <div class="numbertext">2 / 4</div>
                    <img src="images/banner02.jpg" />
                </div>

                <div class="mySlides fade">
                  <div class="numbertext">3 / 4</div>
                    <img src="images/banner03.jpg" />
                </div>
  
                  <div class="mySlides fade">
                  <div class="numbertext">4 / 4</div>
                      <img src="images/banner04.jpg" />
                </div>
            </div>
            <div style="text-align:center; margin-top:-40px" >
                <span class="dot"></span>
                <span class="dot"></span>
                <span class="dot"></span>
                <span class="dot"></span>
            </div>
        </div>
    </div>

                                                                    <!-- PHÒNG KHÁCH SẠN-->
    <div class="small-container" style="margin-top:10px">
        <h2 class="title">KHÁCH SẠN</h2>
        <div class="row" style="margin-top:-60px">
            <asp:ListView ID="ListViewFearturedProducts" runat="server">
                <ItemTemplate>
                    <div class="col-4">
                        <a href="product-detail.aspx?id=<%# Eval("id") %>">
                            <img src="<%# Eval("img") %>"/></a>
                        <h4><%# Eval("name") %></h4>
                        <p><%# Eval("price") %>đ</p>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
                                                                    <!-- banner5 -->
    <div class="row" style="background-image:url(images/banner5.jpg); height:300px; margin-top:-30px">
        <div class="col-2"></div>
        <div class="col-2" style="transform:none; text-align:center; ">
            <h3 style="margin-top:20px; color:white">HUE TRAVEL</h3>
        <p style="color:white; margin-top:15px;margin-right:40px">Nằm ngay trung tâm thành phố với không gian sang trọng, vị trí thuận lợi, gần các địa điểm du lịch nổi tiếng của Huế.</p>
        <a href="products.aspx" class="btn">Đặt phòng ngay</a>
        </div>
    </div>
          
            <!--Tiện ích-->
    <h2 class="title" style="margin-top:30px">TIỆN ÍCH TẠI HUẾ</h2>
    <div class="small-container">
        <div class="row" style="margin-top:-60px">
            <div class="col-3">
                <img src="images/tienich1.jpg" />
                <p style="color:black">Tour nghe ca Huế trên sông Hương</p>
            </div>
            <div class="col-3">
                <img src="images/tienich2.jpg" />
                <p style="color:black">Nhà hàng chay với hơn 50 món.</p>
            </div>
            <div class="col-3">
                <img src="images/tienich3.jpg" />
                <p style="color:black">Nhà hàng với các món Á – Âu.</p>
            </div>
            <div class="col-3">
                <img src="images/tienich4.jpg" />
                <p style="color:black">Dịch cụ xe đưa đón sân bay.</p>
            </div>
            <div class="col-3">
                <img src="images/tienich5.jpg" />
                <p style="color:black">Dịch vụ thuê xe dạo quanh thành phố.</p>
            </div>
            <div class="col-3">
                <img src="images/tienich6.jpg" />
                <p style="color:black">Vị trí thuận lợi gần các điểm du lịch</p>
            </div>
        </div>

        <p style="text-align:center; font-size:20px">Liên hệ Tiếp Tân để được hướng dẫn cụ thể!</p>
    </div>



    <!-- banner6 -->
   <div class="row" style="background-image:url(images/banner6.jpg); height:300px">
       <div class="col-4" style="transform:none; text-align:center">
       <p style="color:white; margin-top:16px; font-size:60px">32
           <span style="font-size:14px">PHÒNG</span>
       </p>
       </div>
       <div class="col-4" style="transform:none; text-align:center; ">
       <p style="color:white; margin-top:15px; font-size:60px">20
           <span style="font-size:16px">DỊCH VỤ TIỆN ÍCH</span>
       </p>
       </div>
       <div class="col-4" style="transform:none; text-align:center">
           <p style="color:white; margin-top:15px;font-size:60px"> 25
               <span style="font-size:16px">NHÂN VIÊN QUẢN LÝ</span>
           </p>
       </div>
       <div class="col-4" style="transform:none; text-align:center">
           <p style="color:white; margin-top:15px; font-size:60px">1
               <span style="font-size:16px">NĂM KINH NGHIỆM</span>
           </p>
       </div>
    </div>


    <script>
        var slideIndex = 0;
        showSlides();

        function showSlides() {
            var i;
            var slides = document.getElementsByClassName("mySlides");
            var dots = document.getElementsByClassName("dot");
            for (i = 0; i < slides.length; i++) {
                slides[i].style.display = "none";
            }
            slideIndex++;
            if (slideIndex > slides.length) { slideIndex = 1 }
            for (i = 0; i < dots.length; i++) {
                dots[i].className = dots[i].className.replace(" active", "");
            }
            slides[slideIndex - 1].style.display = "block";
            dots[slideIndex - 1].className += " active";
            setTimeout(showSlides, 4000); // Chuyển ảnh sau 4 giây
        }

    </script>
    
</asp:Content>
