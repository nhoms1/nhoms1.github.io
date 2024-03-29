<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="userinformation.aspx.cs" Inherits="web_khachsan.userinformation" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div>
            <h2 style="text-align: center">Thông Tin Cá Nhân</h2>
        </div>

        <div class="wrapper">
            <div class="left">
                <img src="images/userprofile.jpg" alt="user" width="100">
                <h4 style="color: black" >Tên của bạn</h4>
                <input class="inputregister" type="text" runat="server" id="infoname" name="infoname" placeholder="Your Name" required="required" />
                <p style="color: black">Tài khoản thường</p>
            </div>
        
            <div class="right">
                <div class="info">
                    <h3>Thông tin</h3>
                        <div class="info_data">
                             <div class="data">
                                <h4>Email</h4>
                                <input  class="inputregister" type="email" runat="server" id="infoemail" name="infoemail" placeholder="Your Email" required="required" />
                             </div>
                             <div class="data">
                               <h4>Số điện thoại</h4>
                               <p>0123456789</p>
                             </div>
                        </div>
                </div>
      
            <div class="projects">
                <h3>Bản thân</h3>
                    <div class="projects_data">
                        <div class="data">
                            <h4>Học tập</h4>
                            <p>Đã tốt nghiệp trung học phổ thông</p>
                            <p>Đang học tại <strong>Đại học ...</strong></p>
                            <p>Sống tại <strong>Hà Nội</strong></p>
                            <p>Đến từ <strong>Hà Nam</strong></p>
                        </div>
                        <div class="data">
                            <h4>Công việc</h4>
                            <p>Ngửa tay xin tiền bố mẹ</p>
                            <p>Chém gió hàng ngày</p>
                        </div>
                    </div>
            </div>

            <div class="social_media">
                <ul>
                    <li><a href="https://www.facebook.com/NguyenVuhnx2/"><i class="fab fa-facebook-f"></i></a></li>
                    <li><a href="https://twitter.com/?lang=vi"><i class="fab fa-twitter"></i></a></li>
                    <li><a href="https://www.instagram.com/"><i class="fab fa-instagram"></i></a></li>
                </ul>
            </div>
        </div>
    </div>

        <input  type="submit" value="Save" class="btn" style="height: 40px"/>
        <br />
    <div class="col-2" style="text-align: center">
        
        <a href="index.aspx" class="btn" style="margin-right: 10px">Về Trang Chủ</a>
        <a href="logout.aspx" class="btn">Đăng xuất</a>
    </div>

    </form>
    
    <script>
        var dob = document.getElementById("dobRegister");
        var loi = document.getElementById("MainContent_loi");
        datenow = new Date();
        datedob = new Date(dob.value);
        if (datenow.getTime() < datedob.getTime()) {
            loi.innerText = "Vui lòng nhập đúng ngày sinh.bạn đang nhập ngày sinh lớn hơn ngày hiện tại";
            dob.focus();
            return false;
        }

    </script>
    
</asp:Content>
