<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataProviderLogin.aspx.cs" Inherits="DataProviderLogin" %>

<!DOCTYPE html>
<html lang="zxx">
<head>
	<title>Multicloud</title>
	<!-- for-mobile-apps -->
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="keywords" content="Improve Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
	<script type="application/x-javascript">
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!-- //for-mobile-apps -->
	<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
	<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
	<link href="css/font-awesome.css" rel="stylesheet">

	<!-- css files -->
	<link href="//fonts.googleapis.com/css?family=Josefin+Sans:100,100i,300,300i,400,400i,600,600i,700,700i&amp;subset=latin-ext" rel="stylesheet">
	<link href="//fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
	<!-- //css files -->
</head>

<body>
	<!-- banner -->
	<div class="banner-main">
		<div class="banner-2">
			
			<!--header-->
			<div class="header">
				<div class="container">
					<nav class="navbar navbar-default">
						<div class="navbar-header">
							<button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
							<span class="sr-only">Toggle navigation</span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
						</button>
							<h1><a href="Home.aspx">Multicloud</a></h1>
						</div>
						<!--navbar-header-->
						<div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
							<ul class="nav navbar-nav navbar-right">
								<li><a href="Home.aspx"  class="">Home</a></li>
								<li><a href="#" class="dropdown-toggle " data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Data Owner<span class="caret"></span></a>
									<ul class="dropdown-menu ">
										<li><a href="DataOwnerRegister.aspx" >Register</a></li>
										<li><a href="DataOwnerLogin.aspx">Login</a></li>
									</ul>
								</li>
                                <li><a href="#" class="dropdown-toggle " data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Data User<span class="caret"></span></a>
									<ul class="dropdown-menu">
										<li><a href="DataUserRegister.aspx">Register</a></li>
										<li><a href="DataUserLogin.aspx">Login</a></li>
									</ul>
								</li>
                                <li><a href="DataProviderLogin.aspx" class="active">Data Provider</a></li>
                                <li><a href="CloudAdminLogin.aspx"  >Cloud Admin</a></li>
							</ul>
						</div>
					</nav>
				</div>
				<div class="cd-main-header">
					
					<!-- cd-header-buttons -->
				</div>
				<div id="cd-search" class="cd-search">
					
				</div>
			</div>
			<!--//header-->
	</div>
	</div>
	<!-- //banner -->	
<!-- contact -->
<div class="contact">
		<div class="container" align="center">
			<h3 class="w3l-titles">Data Provider Login</h3>
			
			<div class="col-md-9 col-sm-9 contact-right">
				<form action="#" method="post" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="User Name" Height="50" Width="315" Font-Size="20" ForeColor="Black" Font-Italic="True" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Name" required="" style="text-align: center" ForeColor="#333333" Height="50" Width="370"></asp:TextBox><br /><br />
                    <asp:Label ID="Label6" runat="server" Text="Password" Height="50" Width="300" Font-Size="20" ForeColor="Black" Font-Italic="True" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" required="" style="text-align: center" ForeColor="#333333" TextMode="Password" Height="50" Width="370"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
					
				</form>
			</div>
		</div>
	</div>
	

<!-- //contact -->
<!-- footer -->
<div class="footer">
		<div class="container">
			
			
			<div class="clearfix"> </div> 
		</div>
	</div>
	<!-- footer -->
	<div class="copyright">
		<div class="container">
			<p>© Multicloud. All Rights Reserved</p>
			
		</div>
	</div>
	<!-- //footer -->
<!-- bootstrap-pop-up -->
					<div class="modal video-modal fade" id="myModal1" tabindex="-1" role="dialog" aria-labelledby="myModal">
						<div class="modal-dialog" role="document">
							<div class="modal-content">
								<div class="modal-header">
										Improve
									<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>	
								</div>
								<section>
									<div class="modal-body">
										<img src="images/g3.jpg" alt=" " class="img-responsive" />
										<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.</p>
									</div>
								</section>
							</div>
						</div>
					</div>
					<!-- //bootstrap-pop-up -->
	<!-- js-scripts -->
	<!-- js -->
	<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<!-- Necessary-JavaScript-File-For-Bootstrap -->
	<!-- //js -->
	<!-- smooth scrolling -->
	<script type="text/javascript" src="js/move-top.js"></script>
	<script type="text/javascript" src="js/easing.js"></script>
	<!-- here stars scrolling icon -->
	<script type="text/javascript">
		$(document).ready(function() {
			/*
				var defaults = {
				containerID: 'toTop', // fading element id
				containerHoverID: 'toTopHover', // fading element hover id
				scrollSpeed: 1200,
				easingType: 'linear' 
				};
			*/
								
			$().UItoTop({ easingType: 'easeOutQuart' });
								
			});
	</script>
	<!-- //here ends scrolling icon -->
<!-- //smooth scrolling -->
<!-- scrolling script -->
<script type="text/javascript">
	jQuery(document).ready(function($) {
		$(".scroll").click(function(event){		
			event.preventDefault();
			$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
		});
	});
</script> 
<!-- //scrolling script -->
	<!--search jQuery-->
	<script src="js/main.js"></script>
	<!--//search jQuery-->
	<!-- smooth scrolling -->
	<script src="js/SmoothScroll.min.js"></script>
	<!-- //smooth scrolling -->
	<!-- js-scripts -->
</body>
</html>