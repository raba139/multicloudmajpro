<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataUserFileDownload.aspx.cs" Inherits="DataUserFileDownload" %>

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
								<li><a href="DataUserHome.aspx">Home</a></li>
                                <li><a href="DataUserPublicFiles.aspx">Public Files</a></li>
								<li><a href="DataUserPrivateFiles.aspx" >Private Files</a></li>
                                <li><a href="DataUserFileKey.aspx">File Key</a></li>
                                <li><a href="DataUserFileDownload.aspx" class="active">File Download</a></li>
                                <li><a href="Home.aspx">Logout</a></li>
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
			<h3 class="w3l-titles">File Download</h3>
			
			<div class="col-md-9 col-sm-9 contact-right">
				<form id="form1" runat="server">
                    <table>
                        <tr>
                            <td>
                                 <asp:Label ID="Label1" runat="server" Text="User Name" Height="50" Width="150" Font-Size="15" ForeColor="Black" Font-Italic="True" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Name" required="" style="text-align: center" ForeColor="#333333" Height="50" Width="300" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                 <asp:Label ID="Label2" runat="server" Text="File ID" Height="50" Width="150" Font-Size="15" ForeColor="Black" Font-Italic="True" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="ID" required="" style="text-align: center" ForeColor="#333333" Height="50" Width="300"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                 <asp:Label ID="Label3" runat="server" Text="File Key 1" Height="50" Width="150" Font-Size="15" ForeColor="Black" Font-Italic="True" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="Key 1" required="" style="text-align: center" ForeColor="#333333" Height="50" Width="300"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                 <asp:Label ID="Label4" runat="server" Text="File Key 2" Height="50" Width="150" Font-Size="15" ForeColor="Black" Font-Italic="True" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="Key 2" required="" style="text-align: center" ForeColor="#333333" Height="50" Width="300"></asp:TextBox>
                            </td>
                        </tr>
                       
                    </table>
                   
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
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

