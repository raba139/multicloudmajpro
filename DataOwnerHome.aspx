<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataOwnerHome.aspx.cs" Inherits="DataOwnerHome" %>

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
	<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />
	<!-- css files -->
	<link href="//fonts.googleapis.com/css?family=Josefin+Sans:100,100i,300,300i,400,400i,600,600i,700,700i&amp;subset=latin-ext" rel="stylesheet">
	<link href="//fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
	<!-- //css files -->
</head>

<body>
	<!-- banner -->
	<div class="banner-main">
		<div class="banner">
			<div class="agile_dot_info one">
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
							<h1><a href="Home.aspx">MultiCloud</a></h1>
						</div>
						<!--navbar-header-->
						<div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
							<ul class="nav navbar-nav navbar-right">
								<li><a href="DataOwnerHome.aspx"  class="active">Home</a></li>
                                <li><a href="DataOwnerFileUpload.aspx"  >File Upload</a></li>
								<li><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">File Details<span class="caret"></span></a>
									<ul class="dropdown-menu">
										<li><a href="DataOwnerPublicFiles.aspx">Public Files</a></li>
										<li><a href="DataOwnerPrivateFiles.aspx">Private Files</a></li>
									</ul>
								</li>
                                <li><a href="DataOwnerDataUser.aspx">Data User </a></li>
                                <li><a href="DataOwnerFileRequest.aspx">File Request </a></li>
                                <li><a href="Home.aspx">Logout</a></li>
							</ul>
						</div>
					</nav>
				</div>
				<div class="cd-main-header">
					
					<!-- cd-header-buttons -->
				</div>
				<div id="cd-search" class="cd-search">
					<form action="#" method="post">
						<input name="Search" type="search" placeholder="Click enter after typing...">
					</form>
				</div>
			</div>
			<!--//header-->
			<div class="w3_banner_info">
				
		</div>
		</div>
	</div>
	</div>
	<!-- //banner -->
								
	<!-- team -->
	<!-- About us -->
	
	<!-- //About us -->

	<!-- stats -->
	
	<!-- //stats -->
		<!-- services -->
	
	<!-- //services -->
	<!-- testimonial -->

<!-- //testimonial -->

	<!-- Services -->
		
			<!-- //Services -->
<!-- footer -->
<div class="footer">
		<div class="container">
			
			
			
			<div class="clearfix"> </div> 
		</div>
	</div>
	<!-- footer -->
	<div class="copyright">
		<div class="container">
			<p>© Multicloud. All Rights Reserved </p>
			
		</div>
	</div>
	<!-- //footer -->
<!-- bootstrap-pop-up -->
					
					<!-- //bootstrap-pop-up -->
	<!-- js-scripts -->
	<!-- js -->
	<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<!-- Necessary-JavaScript-File-For-Bootstrap -->
	<!-- //js -->
	<!--Start-slider-script-->
	<script defer src="js/jquery.flexslider.js"></script>
		<script type="text/javascript">
		
		$(window).load(function(){
		  $('.flexslider').flexslider({
			animation: "slide",
			start: function(slider){
			  $('body').removeClass('loading');
			}
		  });
		});
	  </script>
<!--End-slider-script-->
<script src="js/responsiveslides.min.js"></script>
						
			<script>
								// You can also use "$(window).load(function() {"
								$(function () {
								  // Slideshow 4
								  $("#slider3").responsiveSlides({
									auto: true,
									pager:false,
									nav:true,
									speed: 500,
									namespace: "callbacks",
									before: function () {
									  $('.events').append("<li>before event fired.</li>");
									},
									after: function () {
									  $('.events').append("<li>after event fired.</li>");
									}
								  });
							
								});
							 </script>

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
	<!-- stats -->
	<script src="js/waypoints.min.js"></script>
	<script src="js/counterup.min.js"></script>
	<script>
		jQuery(document).ready(function ($) {
			$('.counter').counterUp({
				delay: 100,
				time: 1000
			});
		});
	</script>
	<!-- stats -->
	<!-- smooth scrolling -->
	<script src="js/SmoothScroll.min.js"></script>
	<!-- //smooth scrolling -->
	<!-- js-scripts -->
</body>

</html>
