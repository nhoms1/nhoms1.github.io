/* Header */
header {
    display: flex;
    align-items: center; /* Căn giữa theo chiều dọc */
    padding: 20px;
    background-color: #0088CC;
}

nav {
    display: flex; /* Sử dụng flexbox cho menu và logo */
    align-items: center; /* Căn giữa theo chiều dọc */
}

.logo {
    max-width: 100px;
    margin-right: 10px;
}

nav ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    display: flex;
}

nav ul li {
    margin-right: 20px;
}

nav ul li:last-child {
    margin-right: 0;
}
nav ul li a {
    color: #ffffff;
    text-decoration: none;
    transition: color 0.3s ease;
}

nav ul li a:hover {
    color: #FFC400;
}
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

.navbar {
    display: flex;
    align-items: center;
    padding: 20px;
}


nav {
    flex: 1;
    text-align: right;
}

nav ul {
    display: inline-block;
    list-style-type: none;
}

nav ul li {
    display: inline-block;
    margin-right: 20px;
}

#MenuItems a:hover {
    color: #1F7A70;
}
/*Color: #35D0BA */
a {
    text-decoration: none;
    color: black;
}

p {
    color: #e91313;
}

.container {
    max-width: 1300px;
    margin: auto;
    padding-left: 25px;
    padding-right: 25px;
}

* {
    box-sizing: border-box
}

.box-booking{
    background-color:antiquewhite;
    max-width:100px;
    margin:0 auto;
}

input[type="text"], input[type="date"], input[type="number"]{
    width:50%;
    padding:10px;
    margin:5px 0;
    border:1px solid #ccc;
    border-radius:4px;
    box-sizing:border-box;
}

body {
    font-family: Verdana,sans-serif;
}

/* Slideshow container */
.slideshow-container {
    max-width: 1000px;
    position: relative;
}


/* Number text (1/3 etc) */
.numbertext {
    color: #f2f2f2;
    font-size: 12px;
    padding: 8px 12px;
    position: absolute;
    top: 0;
}

/* The dots/bullets/indicators */
.dot {
    height: 13px;
    width: 13px;
    margin: 0 2px;
    background-color: #bbb;
    border-radius: 50%;
    display: inline-block;
    transition: background-color 0.6s ease;
}

.active {
    background-color: #717171;
}

/* Fading animation */
.fade {
    -webkit-animation-name: fade;
    -webkit-animation-duration: 1.5s;
    animation-name: fade;
    animation-duration: 1.5s;
}



@-webkit-keyframes fade {
    from {
        opacity: .4
    }

    to {
        opacity: 1
    }
}

@keyframes fade {
    from {
        opacity: .4
    }

    to {
        opacity: 1
    }
}

.banner5 {
    width:calc(50%-10px);
    margin: 0 5px;

}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
    .text {
        font-size: 11px
    }
}

.row {
    display: flex;
    align-items: center;
    flex-wrap: wrap;
    justify-content: space-around;
}

.col-2 {
    flex-basis: 50%;
    min-width: 300px;
}

    .col-2 img {
        max-width: 100%;
        padding: 50px 0;
    }

    .col-2 h1 {
        font-size: 60px;
        line-height: 50px;
        margin: 25px 0;
    }

.btn {
    display: inline-block;
    background: black;
    color: #fff;
    padding: 8px 30px;
    margin: 30px 0;
    border-radius: 30px;
    transition: background 0.5s;
}

.btn-remove {
    cursor: pointer;
}

.btn-logout {
    width: 170px;
    height: 40px;
}

.btn:hover {
    background: #1abc9c
}

search-btn:hover {
    background: #1F7A70
}

.header .row {
    margin-top: 70px;
}

.ti-shopping-cart {
    width: 35px;
    height: 20px;
}

.ti-search {
    cursor: pointer;
    height: 20px;
    color: black;
    display: inline-block;
}

.search-box {
    display: none;
}

.categories {
    margin: 70px 0;
}

.col-3 {
    flex-basis: 30%;
    min-width: 250px;
    margin-bottom: 30px;
}

.col-3 img {
    width: 300px;
    height: 185px;
}


.small-container {
    max-width: 1080px;
    margin: auto;
    padding-left: 25px;
    padding-right: 25px;
}

.col-4 {
    flex-basis: 25%;
    padding: 10px;
    min-width: 200px;
    margin-bottom: 50px;
    transition: transform 0.5s;
}

    .col-4:hover {
        transform: translateY(-10px);
    }

    .col-4 img {
        width: 100%;
    }

.title {
    text-align: center;
    margin: 0 auto 80px;
    position: relative;
    line-height: 60px;
    color: #555;
}

    .title::after {
        content: '';
        background: #35D0BA;
        width: 80px;
        height: 5px;
        border-radius: 5px;
        position: absolute;
        bottom: 0;
        left: 50%;
        transform: translateX(-50%)
    }

h4 {
    color: #555;
    font-weight: normal;
}

.col-4 p {
    font-size: 14px;
}

/* Offer */
.offer {
    background: radial-gradient(#fff, #99eadd);
    margin-top: 80px;
    padding: 30px 0;
}

.col-2 .offer-img {
    padding: 50px;
}

.col-2 > p {
    color: #000;
}

small {
    color: #555;
}

/* Brands */
.brands {
    margin: 100px auto;
}

.col-5 {
    width: 160px;
}

    .col-5 img {
        width: 100%;
        cursor: pointer;
        filter: grayscale(100%);
    }

        .col-5 img:hover {
            filter: grayscale(0);
        }

.brands-col-1, .brands-col-2, .brands-col-3, .brands-col-4 {
    margin-bottom: 20px;
}

.brands-col-1 {
    margin-left: 100px;
    width: auto;
}

.brands-col-2 {
    margin-left: 50px;
    width: auto;
    flex: 1;
}

.brands-col-3, .brands-col-4 {
    margin-left: 50px;
    width: auto;
}

.brands-col-4 {
    margin-right: 100px;
}

/* footer */
.footer {
    background: #000;
    color: #8a8a8a;
    font-size: 14px;
    padding: 60px 0 20px;
}

    .footer p {
        color: #8a8a8a;
    }

    .footer h3 {
        color: #fff;
        margin-bottom: 20px;
    }

.footer-col-1, .footer-col-2, .footer-col-3, .footer-col-4 {
    min-width: 250px;
    margin-bottom: 20px;
}

.footer-col-2 {
    flex-basis: 25%;
}

.footer-col-1 {
    flex: 1;
    text-align: center;
}

    .footer-col-1 img {
        width: 150px;
        margin-bottom: 20px;
    }

.footer-col-3, .footer-col-4 {
    flex-basis: 25%;
}

ul {
    list-style-type: none;
}

.app-logo {
    margin-top: 20px;
}

    .app-logo img {
        width: 140px;
    }

.footer hr {
    border: none;
    background: #b5b5b5;
    height: 1px;
    margin: 20px 0;
}

.copyright {
    text-align: center;
}

.ti-menu {
    width: 28px;
    margin-left: 20px;
    display: none;
}


/* All Products Page*/

.row-2 {
    justify-content: space-between;
    margin: 100px auto 50px;
}

.dropbtn {
    background-color: #35D0BA;
    color: white;
    padding: 16px;
    font-size: 16px;
    border: none;
    cursor: pointer;
    padding: 5px;
    height: 35px;
}

.dropdown {
    position: relative;
    display: inline-block;
}

.dropdown-content {
    display: none;
    position: absolute;
    background-color: #f9f9f9;
    min-width: 136px;
    box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
    z-index: 1;
}

    .dropdown-content a {
        color: black;
        padding: 12px 16px;
        text-decoration: none;
        display: block;
    }

        .dropdown-content a:hover {
            background-color: #f1f1f1
        }

.dropdown:hover .dropdown-content {
    display: block;
}

.dropdown:hover .dropbtn {
    background-color: #3e8e41;
}

/* Show the dropdown menu (use JS to add this class to the .dropdown-content container when the user clicks on the dropdown button) */
.show {
    display: block;
}

.page-btn {
    margin: 0 auto 80px;
}

    .page-btn span {
        display: inline-block;
        border: 1px solid #35D0BA;
        margin-left: 10px;
        width: 40px;
        height: 40px;
        text-align: center;
        line-height: 40px;
        cursor: pointer;
    }

        .page-btn span:hover {
            background: #35D0BA;
            color: #fff;
        }

/* Single Product */
.single-product {
    margin-top: 80px;
}

    .single-product .col-2 img {
        padding: 0;
    }

    .single-product .col-2 {
        padding: 20px;
    }

    .single-product h4 {
        margin: 20px 0;
        font-size: 22px;
        font-weight: bold;
    }

    .single-product select {
        display: block;
        padding: 10px;
        margin-top: 20px;
    }

    .single-product input {
        width: 50px;
        height: 40px;
        padding-left: 10px;
        font-size: 20px;
        margin-right: 10px;
        border: 1px solid #35D0BA;
    }

input:focus {
    outline: none;
}

.single-product .ti-menu-alt {
    color: #35D0BA;
    padding-top: 15px;
    margin-left: 10px;
}

.small-img-row {
    display: flex;
    justify-content: space-between;
}

.small-img-col {
    flex: 24%;
    cursor: pointer;
}

/* Cart Items */
.cart-page {
    margin: 80px auto;
}

table {
    width: 100%;
    border-collapse: collapse;
}

.cart-info {
    display: flex;
    flex-wrap: wrap;
}

th {
    text-align: left;
    padding: 5px;
    color: #fff;
    background: black;
    font-weight: normal;
}

td {
    padding: 10px 5px;
}

    td input {
        width: 40px;
        height: 30px;
        padding: 5px;
    }

    td a {
        color: #35D0BA;
        font-size: 12px;
    }

    td img {
        width: 130px;
        height: 80px;
        margin-right: 10px;
    }

.total-price {
    display: flex;
    justify-content: flex-end;
}

    .total-price table {
        margin-top: 10px;
        border-top: 3px solid black;
        width: 100%;
        max-width: 350px;
    }

td:last-child {
    text-align: right;
}

th:last-child {
    text-align: right;
}

/* About */
.about-us {
    display: flex;
    width: 100%;
    flex-direction: column;
    background-size: cover;
}

.tieu_de {
}

    .tieu_de p {
        margin-left: 100px;
        margin-right: 100px;
        color: black;
    }

.tieu_de-phu {
    margin-left: 100px;
    margin-right: 100px;
}

    .tieu_de-phu p {
        color: black;
    }

.banner4-img {
    height: 400px;
}

.card-img {
    border-radius: 5px;
}

    .card-img img {
        width: 250px;
    }

.cards .card {
    width: 16rem;
    margin: 20px;
}

.card p {
    font-size: 14px;
}




/* Account Page */
.account-page {
    padding: 50px 0;
}

.form-container {
    background: #fff;
    width: 300px;
    height: 430px;
    position: relative;
    text-align: center;
    padding: 20px 0;
    margin: auto;
    box-shadow: 0 0 20px 0px rgba(0,0,0,0.1);
    overflow: hidden;
}

    .form-container span {
        font-weight: bold;
        padding: 0 4px 0;
        color: #555;
        cursor: pointer;
        width: 100px;
        display: inline-block;
    }

.form-btn {
    display: inline-block;
}

.form-container form {
    max-width: 300px;
    padding: 0 20px 0;
    position: absolute;
    top: 130px;
    transition: transform 1s;
}

form input {
    width: 100%;
    height: 30px;
    margin: 10px 0;
    padding: 0 10px;
    border: 1px solid #ccc;
}

form .account-btn {
    width: 100%;
    border: none;
    cursor: pointer;
    margin: 10px 0;
    display: inline-block;
    background: #35D0BA;
    color: #fff;
    padding: 8px 30px;
    margin: 30px 0;
    border-radius: 30px;
    transition: background 0.5s;
}

    form .account-btn:focus {
        outline: none;
    }

    form .account-btn:hover {
        background-color: #157063;
        color: #fff;
    }

#LoginForm {
    left: -300px;
}

#RegForm {
    left: 0
}

#Indicator {
    width: 100px;
    border: none;
    background: #35D0BA;
    height: 3px;
    margin-top: 8px;
    transform: translateX(100px);
    transition: transform 1s;
}

/* News */

.new_container {
    margin: auto;
    max-width: 1300px;
}

.new_container-title {
    padding: 10px;
}

.new_container_main {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
}


.big-img {
    width: 50%;
    position: relative;
    padding: 3px;
}

    .big-img img {
        width: 100%;
    }

    .big-img span {
        position: absolute;
        bottom: 0;
        left: 0;
        width: 100%;
        padding: 10px;
        color: #fff;
        font-size: 23px;
        background-color: rgba(0, 0, 0, 0.5);
        box-sizing: border-box;
    }

.big-img-txt {
    display: none;
    font-weight: normal;
    font-size: 13px;
    color: #fff;
}

.small-img {
    float: left;
    width: 50%;
    height: 443.8px;
    ;
    overflow: hidden;
    padding: 3px;
}

ul.small-img li {
    height: 227px;
    margin-bottom: 5px;
}

.small-img img {
    float: left;
    width: 60%;
    margin-right: 5px;
}

ul.small-img li span {
    font-size: 17px;
}

.small-img-txt {
    color: black;
}

.new_container-title-1,
.new_container-title-2 {
    color: red;
    float: left;
    width: 50%;
    height: auto;
    padding: 3px;
}

.new-box-1,
.new-box-2 {
    float: left;
    width: 50%;
    height: 400px;
    padding: 3px;
    margin-top: 10px;
}

.news-item {
    flex: 2;
    width: 100%;
    margin-top: 10px;
    margin-bottom: 10px;
    overflow: auto;
}

    .news-item img {
        width: 50%;
        float: left;
        object-fit: cover;
        margin-right: 5px;
    }

.new-box-1-top,
.new-box-2-top {
    height: 240px;
    padding: 3px;
}

    .new-box-1-top span,
    .new-box-2-top span {
        width: 312px;
        height: auto;
        float: left;
        font-size: 17px;
    }

.news-item-title {
    flex: 3;
    width: 60%;
    font-size: 18px;
    margin-left: 8px;
}

.new-box-1-bottom {
    margin-top: 15px;
    width: auto;
    height: auto;
}

.new-box-2-bottom {
    margin-top: 12px;
    width: auto;
    height: auto;
}

.text {
    color: #333;
    margin: 1.5rem 0 2rem 0;
}

.information {
    display: flex;
    color: #555;
    margin: 0.7rem 0;
    align-items: center;
    font-size: 0.95rem;
}

.icon {
    width: 28px;
    margin-right: 0.7rem;
}

.social-media {
    padding: 2rem 0 0 0;
}

    .social-media p {
        color: #333;
    }

.social-icons {
    display: flex;
    margin-top: 0.5rem;
}

    .social-icons a {
        width: 35px;
        height: 35px;
        border-radius: 5px;
        background: linear-gradient(45deg, #1abc9c, #149279);
        color: #fff;
        text-align: center;
        line-height: 35px;
        margin-right: 0.5rem;
        transition: 0.3s;
    }

        .social-icons a:hover {
            transform: scale(1.05);
        }

.contact-info:before {
    content: "";
    position: absolute;
    width: 110px;
    height: 100px;
    border: 22px solid #1abc9c;
    border-radius: 50%;
    bottom: -77px;
    right: 50px;
    opacity: 0.3;
}

.big-circle {
    position: absolute;
    width: 500px;
    height: 500px;
    border-radius: 50%;
    background: linear-gradient(to bottom, #1cd4af, #159b80);
    bottom: 50%;
    right: 50%;
    transform: translate(-40%, 38%);
}

    .big-circle:after {
        content: "";
        position: absolute;
        width: 360px;
        height: 360px;
        background-color: #fafafa;
        border-radius: 50%;
        top: calc(50% - 180px);
        left: calc(50% - 180px);
    }

.square {
    position: absolute;
    height: 400px;
    top: 50%;
    left: 50%;
    transform: translate(181%, 11%);
    opacity: 0.2;
}


/* Profile */
.wrapper {
    position: relative;
    margin-top: 20%;
    left: 50%;
    transform: translate(-50%,-50%);
    width: 100%;
    display: flex;
    box-shadow: 0 1px 20px 0 rgba(69,90,100,.08);
}

    .wrapper .left {
        width: 35%;
        background: linear-gradient(to right,#01a9ac,#01dbdf);
        padding: 30px 25px;
        border-top-left-radius: 5px;
        border-bottom-left-radius: 5px;
        text-align: center;
        color: #fff;
    }

        .wrapper .left img {
            border-radius: 5px;
            margin-bottom: 10px;
        }

        .wrapper .left h4 {
            margin-bottom: 10px;
        }

        .wrapper .left p {
            font-size: 12px;
        }

    .wrapper .right {
        width: 65%;
        background: #fff;
        padding: 30px 25px;
        border-top-right-radius: 5px;
        border-bottom-right-radius: 5px;
    }

        .wrapper .right .info,
        .wrapper .right .projects {
            margin-bottom: 25px;
        }

            .wrapper .right .info h3,
            .wrapper .right .projects h3 {
                margin-bottom: 15px;
                padding-bottom: 5px;
                border-bottom: 1px solid #e0e0e0;
                color: #353c4e;
                text-transform: uppercase;
                letter-spacing: 5px;
            }

        .wrapper .right .info_data,
        .wrapper .right .projects_data {
            display: flex;
            justify-content: space-between;
        }

            .wrapper .right .info_data .data,
            .wrapper .right .projects_data .data {
                width: 45%;
            }

                .wrapper .right .info_data .data h4,
                .wrapper .right .projects_data .data h4 {
                    color: #353c4e;
                    margin-bottom: 5px;
                }

                .wrapper .right .info_data .data p,
                .wrapper .right .projects_data .data p {
                    font-size: 13px;
                    margin-bottom: 10px;
                    color: #919aa3;
                }

    .wrapper .social_media ul {
        display: flex;
    }

        .wrapper .social_media ul li {
            width: 45px;
            height: 45px;
            background: linear-gradient(to right,#01a9ac,#01dbdf);
            margin-right: 10px;
            border-radius: 5px;
            text-align: center;
            line-height: 45px;
        }

            .wrapper .social_media ul li a {
                color: #fff;
                display: block;
                font-size: 18px;
            }
