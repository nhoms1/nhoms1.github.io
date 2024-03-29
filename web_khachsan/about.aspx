<%@ Page Title="Giới thiệu - Khách sạn Huế" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="web_khachsan.about" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="about-us">
            <div class="tieu_de">
                <h1 style="text-align:center; color:red;"><i><strong>HUE HOTEL</strong></i></h1><br />
            </div>
            <div class="tieu_de-phu">
                <h2>THƯ NGỎ</h2>
                <br />
                <p>
                    <span style="text-decoration:underline;">Kính gửi:</span>
                    Quý khách hàng và đối tác.
                </p>
                <br>
                <p>Trước tiên, Khách sạn Huế
                    <strong>
                        <span style="color:red;">HUE HOTEL - Huế Classic Hotel</span>
                    </strong>
                    xin gửi lời chúc sức khỏe và lời chào trân trọng nhất đến Quý khách hàng và đối tác.
                </p>
                <br />
                <p>Khách sạn
                    <strong>
                        <span style="color:red;">HUE HOTEL</span>
                    </strong>
                    được thiết kế theo lối kiến trúc cổ điển, đơn giản và sang trọng, Tất cả các phòng đều được trang bị đầy đủ tiện nghi, nội thất hiện đại theo tiêu chuẩn 3 sao với tầm nhìn
                    bao quát toàn bộ các phòng đều view sân vườn, hàng cây xanh như ngọc nét cổ kính thơ mộng của Thôn Vỹ, từ đó cũng tương ứng với các phòng:
                    <strong>
                        <i>Superior Garden View, Balcony Deluxe Garden View, Family Deluxe Garden View và đặc biệt Bed-room Apartment.</i>
                    </strong>
                    Ngoài dịch vụ lưu trú, Khách sạn còn cung cấp đầy đủ các dịch vụ tiện ích nâng cao và thưởng ngoạn như: du thuyền sông Hương, nhã nhạc Cung Đình, Tham quan Đại Nội Huế, Lăng tẩm cổ kính, 
                    mang đến cho Quý khách những giây phút tuyệt vời khi lưu trú tại đây.
                </p>
                <br />
                <p>
                    <strong>
                        <span style="color:red;">HUE HOTEL</span>
                    </strong>
                    còn sở hữu sân vườn lý tưởng ở tầng 3, View đựơc toàn cảnh Thành phố Huế – là nơi phục vụ buffet BBQ, cũng như các bữa tiệc chiêu đãi, tiệc gala, cơm đoàn, v..v… 
                    Bên cạnh đó, khu vực sân vườn tầng trệt kết nối các nhà hàng: Vườn Ai…, Chay Phương Nam, Café Vỹ Dạ Xưa, với không gian đa dạng chắc chắn sẽ đáp ứng mọi nhu cầu về ẩm thực của Quý khách.
                </p>
                <br />
                <p>
                    <strong>
                        <span style="color:red;">HUE HOTEL</span>
                    </strong>
                    nằm ven bờ sông Hương thơ mộng – đây là vị trí rất thuận lợi cho việc giao thương và khám phá du lịch Cồn Hến, bến thuyền Toà Khâm, cầu Đập Đá. Đến với 
                    <strong>
                        <span style="color:red;">HUE HOTEL</span>
                    </strong>
                    Quý khách sẽ có những ấn tượng khó quên không chỉ bởi vẻ đẹp về kiến trúc cổ điển, sự tiện nghi với nội thất sang trọng mà còn bởi sự phục vụ nhiệt tình, chu đáo của đội ngũ nhân viên khách sạn.
                </p>
                <br />
                <p>Khách sạn
                    <strong>
                        <span style="color:red;">HUE HOTEL</span>
                    </strong>
                    luôn mong muốn sẽ là địa chỉ tin cậy khi Quý khách đến nghỉ ngơi hay công tác tại thành phố Huế. Chúng tôi cam kết sẽ nỗ lực không ngừng để nâng cao chất lượng dịch vụ, giữ vững niềm tin, 
                    đáp ứng nhu cầu đa dạng của khách hàng và đối tác trong suốt quá trình phát triển bền vững của mình.
                </p>
                <br />
                <p>Rất hân hạnh được đón tiếp và phục vụ Quý khách, rất mong được hợp tác cùng Quý đối tác trong và ngoài nước!</p>
                <br />
                <p>Trân trọng.</p>
                <br />
                <p style="text-align:right">
                    <strong>
                        <span style="color:red;">HUE HOTEL</span>
                    </strong>
                </p>
                <p style="text-align:right">
                    <strong>
                        <span style="color:red;">(Hue Classic Hotel)</span>
                    </strong>
                </p>

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
