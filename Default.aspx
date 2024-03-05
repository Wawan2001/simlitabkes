<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="simlitekkes.Default" %>

<!DOCTYPE html>

<html lang="id" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="Aplikasi Simlitabkes - Aplikasi Sistem Manajemen Penelitian dan Pengabdian Kepada Masyarakat Politeknik Kesehatan">
    <meta name="keywords" content="Simlitabkes, Penelitian, Pengabdian Kepada Masyarakat, Politeknik Kesehatan, Kementerian Kesehatan">
    <meta name="author" content="TIM TI - Pusdik SDM Kesehatan Kementerian Kesehatan">
    <title>SIMLITABKES</title>
    <!-- App favicon -->
    <link rel="shortcut icon" href="assets/dist/img/favicon.png">

    <!-- Bootstrap core CSS -->
    <link href="assets/plugins/blogmag/css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <!--Custom CSS-->
    <link href="assets/plugins/blogmag/css/style.css" rel="stylesheet" type="text/css">
    <!--Plugin CSS-->
    <link href="assets/plugins/blogmag/css/plugin.css" rel="stylesheet" type="text/css">
    <!--Font Awesome-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <style>
        * {
            margin: 0;
            padding: 0;
            border: 0;
        }

        @keyframes slide {
            from {
                left: 100%;
            }

            to {
                left: -100%;
            }
        }

        @-webkit-keyframes slide {
            from {
                left: 100%;
            }

            to {
                left: -100%;
            }
        }

        #marquee {
            color: #984f3e;
            background: #f0f0f0;
            width: 100%;
            height: 40px;
            line-height: 40px;
            overflow: hidden;
            position: relative;
        }

        #text {
            position: absolute;
            top: 0;
            left: 0px;
            width: 100%;
            height: 40px;
            white-space: nowrap;
            font-size: 16px;
            animation-name: slide;
            animation-duration: 5s;
            animation-timing-function: linear;
            animation-iteration-count: infinite;
            -webkit-animation-name: slide;
            -webkit-animation-duration: 25s;
            -webkit-animation-timing-function: linear;
            -webkit-animation-iteration-count: infinite;
        }
    </style>
</head>
<body id="beauty" class="no-tag">
    <form id="form1" runat="server">
        <!-- Header -->
        <header>
            <div class="upper-head clearfix">
                <div class="container">
                    <div class="header-date">
                        <p><i class="icon-clock"></i><span id="clock"></span></p>
                        <script>
                            const options = {
                                year: '2-digit', month: '2-digit', day: '2-digit',
                                hour: '2-digit', minute: '2-digit', second: '2-digit',
                                timeZone: 'Asia/Jakarta',
                                timeZoneName: 'short'
                            }
                            const formatter = new Intl.DateTimeFormat('sv-SE', options);

                            function currentTime() {
                                var date = new Date();
                                document.getElementById("clock").innerText = formatter.format(date);
                                var t = setTimeout(function () { currentTime() }, 1000); /* setting timer */
                            }

                            function updateTime(k) {
                                if (k < 10) {
                                    return "0" + k;
                                }
                                else {
                                    return k;
                                }
                            }

                            currentTime();
                        </script>
                    </div>
                    <ul class="header-social-links pull-right">
                        <li><a href="https://web.facebook.com/Badan-Pengembangan-dan-Pemberdayaan-SDM-Kesehatan-142227749722209/?_rdc=1&_rdr" target="_blank"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                        <li><a href="https://www.instagram.com/p/B7-eFbHgTNA/" target="_blank"><i class="fa fa-instagram" aria-hidden="true"></i></a></li>
                    </ul>
                </div>
            </div>
        </header>
        <!-- Header Ends -->

        <!-- Navigation Bar -->
        <div class="navigation">
            <div class="container">
                <div class="navigation-content">
                    <div class="header_menu">
                        <!-- start Navbar (Header) -->
                        <nav class="navbar navbar-default navbar-sticky-function navbar-arrow">
                            <div class="logo pull-left" style="width: 215px;">
                                <a href="Default.aspx">
                                    <img alt="Image" src="assets/dist/img/logo-simlitabkes-fp.png" width="215"></a>
                            </div>
                            <div id="navbar" class="navbar-nav-wrapper pull-right">
                                <ul class="nav navbar-nav" id="responsive-menu">
                                    <li>
                                        <a href="https://www.kemkes.go.id/" target="_blank">Kemkes RI</a>
                                    </li>
                                    <li>
                                        <a href="http://bppsdmk.kemkes.go.id/pusdiksdmk/" target="_blank">Pusdik SDM Kesehatan</a>
                                    </li>
                                    <li>|</li>
                                    <li><a href="Login.aspx">Login</a></li>
                                </ul>
                            </div>
                            <!--/.nav-collapse -->
                            <div id="slicknav-mobile"></div>
                        </nav>
                    </div>
                    <div id="searchbar" class="searchbar">
                        <div class="form-group">
                            <input type="text" class="form-control" id="search" placeholder="Search Now">
                            <a href="#"><span class="search_btn"><i class="fa fa-search" aria-hidden="true"></i></span></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Navigation Bar Ends -->

        <!-- Banner -->
        <section id="home_banner_paradise">
            <div class="container">
                <!-- Paradise Slider -->
                <div id="in_th_030" class="carousel slide in_th_brdr_img_030 thumb_scroll_x swipe_x ps_easeOutQuint" data-ride="carousel" data-pause="hover" data-interval="4000" data-duration="2000">

                    <!-- Indicators -->
                    <ol class="carousel-indicators">
                        <!-- 1st Indicator -->
                        <li data-target="#in_th_030" data-slide-to="0" class="active" style="border: 1px solid #d4e615;">
                            <!-- 1st Indicator Image -->
                            <img src="assets/plugins/blogmag/img/sliders/1.png" alt="in_th_030_01_sm" />
                        </li>
                        <!-- 2nd Indicator -->
                        <li data-target="#in_th_030" data-slide-to="1" style="border: 1px solid #d4e615;">
                            <!-- 2nd Indicator Image -->
                            <img src="assets/plugins/blogmag/img/sliders/2.png" alt="in_th_030_02_sm" />
                        </li>
                        <!-- 3rd Indicator -->
                        <li data-target="#in_th_030" data-slide-to="2" style="border: 1px solid #d4e615;">
                            <!-- 3rd Indicator Image -->
                            <img src="assets/plugins/blogmag/img/sliders/3.png" alt="in_th_030_03_sm" />
                        </li>
                    </ol>
                    <!-- /Indicators -->

                    <!-- Wrapper For Slides -->
                    <div class="carousel-inner" role="listbox">

                        <!-- First Slide -->
                        <div class="item active">
                            <!-- Slide Background -->
                            <img src="assets/plugins/blogmag/img/sliders/1.png" alt="in_th_030_01" />
                            <!-- Slide Text Layer -->
                            <div class="in_th_030_slide" data-animation="animated slideInDown">
                                <div class="home_banner_text" style="color:#fff;">
                                    <h2 style="color:#fff;">Edu Health Fair 2020</h2>
                                    <div class="author-detail" style="font-size:20px;">
                                        <i class="icon-clock"></i> 5-6 November 2020
                                    </div>
                                </div>
                            </div>
                            <!-- /in_th_030_slide -->
                            <div class="slider-overlay"></div>
                        </div>
                        <!-- End of Slide -->

                        <!-- Second Slide -->
                        <div class="item">
                            <!-- Slide Background -->
                            <img src="assets/plugins/blogmag/img/sliders/2.png" alt="in_th_030_02" />
                            <!-- Slide Text Layer -->
                            <div class="in_th_030_slide in_th_030_slide_center" data-animation="animated slideInRight">
                                <div class="home_banner_text">
                                    <%--<h2><a href="detail.html">INGREDIENTS TO LOOK FOR IN A FACIAL MASK FOR DRY SKIN</a></h2>
                                    <div class="author-detail">
                                        <p><a href="#"><i class="icon-profile-male"></i>Micheal Jackson</a></p>
                                        <p><i class="icon-clock"></i>1 July</p>
                                        <p><a href="#"><i class="icon-chat"></i>5 comments</a></p>
                                    </div>--%>
                                </div>
                            </div>
                            <!-- /in_th_030_slide -->
                            <div class="slider-overlay"></div>
                        </div>
                        <!-- End of Slide -->

                        <!-- Third Slide -->
                        <div class="item">
                            <!-- Slide Background -->
                            <img src="assets/plugins/blogmag/img/sliders/3.png" alt="in_th_030_03" />
                            <!-- Slide Text Layer -->
                            <div class="in_th_030_slide in_th_030_slide_right" data-animation="animated slideInLeft">
                                <div class="home_banner_text" style="color:#fff;">
                                    <h2 style="color:#fff;">VAKSINASI COVID-19 TAHAP 2</h2>
                                    <div class="author-detail" style="font-size:20px;">
                                        <i class="icon-clock"></i> Mei 2021
                                    </div>
                                </div>
                            </div>
                            <!-- /in_th_030_slide -->
                            <div class="slider-overlay"></div>
                        </div>
                        <!-- End of Slide -->

                    </div>
                    <!-- End of Wrapper For Slides -->
                </div>
            </div>
        </section>
        <!-- Banner Ends -->

        <!-- Tech Categories -->
        <section class="categories-tech" data-ref="container-1" style="padding-top: 5px;">
            <div class="container">
                <div class="row">
                    <div class="col-sm-12" style="float: left; color: #000000; margin: 5px 0px 5px 0px;">
                        <div id="marquee">
                            <div id="text">
                                <asp:Label ID="lblRunningText" runat="server" Text="runningtext"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-8 col-xs-12">
                        <div class="beauty-posts">
                            <div class="cosmetic-posts">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="section-title">
                                            <h2>
                                                <asp:Label ID="Judul" runat="server" Text=""></asp:Label></h2>
                                        </div>
                                        <div class="form-group">
                                            <div class="row">
                                                <div class="col-md-9">
                                                    <asp:TextBox ID="txtCari" runat="server" CssClass="form-control" placeholder="Pencarian pengumuman berdasarkan topik"></asp:TextBox>
                                                </div>
                                                <div class="col-md-3">
                                                    <asp:LinkButton ID="lbCari" runat="server" CssClass="btn btn-block btn-primary" OnClick="lbCari_Click">
                                                        <i class="icon-search"></i>&nbsp;Cari Pengumuman
                                                    </asp:LinkButton>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                                        <asp:GridView runat="server" ID="gvPengumuman" AutoGenerateColumns="false" Width="100%"
                                            Border="0" BorderStyle="None" GridLines="None" OnRowDataBound="gvPengumuman_RowDataBound" DataKeyNames="id_pengumuman,tgl_surat" OnRowCommand="gvPengumuman_RowCommand">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <div>
                                                            <h5 style="color: #3e8607;"><span class="icon-calendar"></span>&nbsp;
                                                                <asp:Label ID="lblTglSurat" runat="server" Text='<%# ConvertDateTimeToDate(Eval("tgl_surat").ToString(), "dd MMMM yyyy", "id-ID") %>'></asp:Label>
                                                                &nbsp;&nbsp;&nbsp;Nomor:
                                                                <asp:Label ID="lblNoSurat" runat="server" Text='<%# Eval("no_surat") %>'></asp:Label>
                                                            </h5>
                                                        </div>
                                                        <div style="color: #266317;">
                                                            <asp:Label ID="lblJudulPengumuman" runat="server" Text='<%# Eval("judul") %>'></asp:Label>
                                                        </div>
                                                        <div>
                                                            <asp:Label ID="lbIsiPengumuman" runat="server" Text='<%# Eval("isi_pengumuman") %>' ForeColor="#337ab7"></asp:Label>
                                                        </div>
                                                        <div style="padding-top: 10px;">
                                                            <span style="font-weight: bold;">BERKAS</span>
                                                            <asp:GridView runat="server" ID="gvInternal" DataKeyNames="file_pengumuman" AutoGenerateColumns="false" ShowHeader="false"
                                                                BorderStyle="None" GridLines="None" OnRowCommand="gvInternal_RowCommand" OnRowDataBound="gvInternal_RowDataBound">
                                                                <Columns>
                                                                    <asp:TemplateField>
                                                                        <ItemTemplate>
                                                                            <asp:LinkButton ID="lbJudulFile" runat="server" CausesValidation="false" CommandName="Unduh" Text='<%# Eval("judul_file") %>'
                                                                                CommandArgument='<%# Eval("file_pengumuman") + "," + Eval("tgl_surat")%>'></asp:LinkButton>
                                                                            <asp:LinkButton ID="lbIkon" runat="server" CssClass="btn" ForeColor="Red" CommandName="Unduh"
                                                                                CommandArgument='<%# Eval("file_pengumuman") + "," + Eval("tgl_surat")%>'></asp:LinkButton>
                                                                            <asp:LinkButton runat="server" ID="lbFileHid" Text='<%# Eval("file_pengumuman") %>' Visible="false"></asp:LinkButton>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                                <EmptyDataTemplate>
                                                                    CommandName="Unduh" 
                                                                    <div style="min-height: 100px; margin: 0 auto;">
                                                                        <strong>DATA TIDAK DITEMUKAN</strong>
                                                                    </div>
                                                                </EmptyDataTemplate>
                                                            </asp:GridView>
                                                        </div>
                                                        <hr />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                    <div class="col-md-12">
                                        <asp:Menu ID="MenuPage" runat="server" Orientation="Horizontal" BackColor="#F7F6F3"
                                            DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="12px" ForeColor="#2C7F27"
                                            StaticSubMenuIndent="10px" OnMenuItemClick="menu_event">
                                            <Items>
                                            </Items>
                                            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                            <DynamicMenuStyle BackColor="#F7F6F3" />
                                            <DynamicSelectedStyle BackColor="#9D7B5D" />
                                            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                            <StaticSelectedStyle BackColor="#DD7B5D" Font-Bold="true" ForeColor="White" />
                                        </asp:Menu>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-xs-12">
                        <div class="tech-mixitup tech-box">
                            <div class="category-box">
                                <ul class="post-category">
                                    <%--<li class="filter" data-filter=".women"><i class="icon-layers"></i>&nbsp;Tautan</li>--%>
                                    <li class="filter" data-filter=".men" style="border-radius: 5px; background-color: #2a750b;"><i class="icon-layers"></i>&nbsp;&nbsp;Arsip</li>
                                    <%--<li class="filter" data-filter=".trend"><i class="icon-layers"></i>&nbsp;e-Book</li>--%>
                                </ul>
                            </div>
                            <div class="tech-box tech-categories men mix">
                                <asp:GridView runat="server" ID="gvMenuPengumumanTahun" AutoGenerateColumns="false" Width="100%"
                                    Border="0" BorderStyle="None" GridLines="None" OnRowDataBound="gvMenuPengumumanTahun_RowDataBound" DataKeyNames="tahun" OnRowCommand="gvMenuPengumumanTahun_RowCommand" ShowHeader="False">
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="post-title">
                                                    <h3>
                                                        <asp:Label ID="lblTahun" runat="server"><%# Eval("tahun") %></asp:Label></h3>
                                                </div>
                                                <div class="category-items">
                                                    <ul>
                                                        <asp:GridView runat="server" ID="gvMenuPengumumanBulan" DataKeyNames="tahun,bulan" AutoGenerateColumns="false" ShowHeader="false"
                                                            BorderStyle="None" GridLines="None" OnRowCommand="gvMenuPengumumanBulan_RowCommand" OnRowDataBound="gvMenuPengumumanBulan_RowDataBound">
                                                            <Columns>
                                                                <asp:TemplateField>
                                                                    <ItemTemplate>
                                                                        <li>
                                                                            <asp:LinkButton ID="lbBulan" runat="server" CausesValidation="false" CommandName="Bulan" Text='<%# Eval("txtbulan") %>' ForeColor="#808080"
                                                                                CommandArgument='<%# Eval("tahun") + "," + Eval("bulan")%>'></asp:LinkButton>
                                                                        </li>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>
                                                        </asp:GridView>
                                                    </ul>
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <div class="tech-outer trend mix">
                            <div class="tech-categories">
                                <div class="category-items">
                                    <ul>
                                        <li><a href="dokumen/ebook/Pedoman Penelitian Poltekkes 2023/index.html" target="_blank"><i class="icon-layers"></i>
                                            Pedoman Penelitian Poltekkes Tahun 2023</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            </div>
                            <div class="tech-outer trend mix">
                                <div class="tech-categories">
                                    <div class="category-items">
                                        <ul>
                                            <li><a href="dokumen/ebook/Pedoman Penelitian dan Pengabmas Poltekkes Tahun 2021/index.html" target="_blank"><i class="icon-layers"></i>
                                                Pedoman Penelitian dan Pengabmas Poltekkes Tahun 2021</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Tech Categories Ends -->

        <!-- Footer -->
        <footer>
            <div class="footer-content">
                <div class="footer-content">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-2 col-xs-12">
                                <div style="font-size: 20px; font-weight: bold; color: #fff;">
                                    Pengunjung:
                                    <asp:Label ID="lblUserCount" runat="server" Text="0"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2 col-xs-12">
                                <div class="container">
                                    <div class="copyright-content text-center">
                                        <span>Copyright © 2020 - Tim TI <a href="http://http://bppsdmk.kemkes.go.id/pusdiksdmk/">Pusdik SDM Kesehatan</a> Kementerian Kesehatan</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="footer-copyright">
                </div>
            </div>
            <div class="footer-overlay"></div>
        </footer>
        <!-- Footer Ends -->

        <!-- back to top start -->
        <div id="back-to-top">
            <a href="#"></a>
        </div>

        <!-- *Scripts* -->
        <script src="assets/plugins/jQuery/jquery-3.4.1.min.js"></script>
        <script src="assets/plugins/blogmag/js/bootstrap.min.js"></script>
        <script src="assets/plugins/blogmag/js/plugin.js"></script>
        <script src="assets/plugins/blogmag/js/main.js"></script>
        <script src="assets/plugins/blogmag/js/custom-mixitup.js"></script>
        <script>
            function redirect20() {
                window.location.replace("http://simlitabmas.ristekbrin.go.id/2/login.aspx?users_online=" + document.getElementById("lblJmlPengunjung").innerHTML);
            }
        </script>
    </form>
</body>
</html>
