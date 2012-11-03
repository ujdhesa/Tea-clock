<!DOCTYPE html>
<html lang="cs" manifest="tea-clock.appcache">
<head>
    <meta charset="utf-8">
    <title>Tea-clock</title>
    <meta name="description" content="">
    <meta name="author" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <!-- Le HTML5 shim, for IE6-8 support of HTML elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <!-- Le styles -->
    <link type="text/css" rel="stylesheet" href="css/bootstrap.min.css">
    <link type="text/css" rel="stylesheet" href="css/bootstrap-responsive.min.css">
    <link type="text/css" href="css/ui-lightness/jquery-ui-1.8.16.custom.css" rel="stylesheet" />
	<link type="text/css" href="css/override.css" rel="stylesheet"/>

    <!-- Le fav and touch icons -->
    <link rel="shortcut icon" href="img/favicon.ico">
    <link rel="apple-touch-icon" href="img/favicon.ico">
		
<!-- Place this render call where appropriate -->
	<script type="text/javascript">
	window.___gcfg = {lang: 'cs'};
	
  	(function() {
    		var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;
    		po.src = 'https://apis.google.com/js/plusone.js';
    		var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
	  })();
	</script>


  </head>

  <body>
    <div class="container">                    
        <div class="page-header"> <h1>Tea-clock <small>Ať se louhuje...</small></h1> </div>
		<div class="row">
			<div class="span10">
				<div class="alert alert-block alert-error" hidden="true">
					<a class="close" data-dismiss="alert">×</a>
					<h4 class="alert-heading">Je vyžadován Chrome!</h4>
				  	Tato aplikace potřebuje ke svému běhu <strong>desktopové notifikace</strong>, které aktuálně fungují pouze v <strong>Google Chrome.</strong>
				</div>
			</div>
		</div>
        <div class="row">
          <div class="span7">
			<div class="well">
	            <form id="form1" class="form-horizontal">
					<fieldset>
						<legend>Jak pijete svůj čaj?</legend>
							<div class="control-group">							
								<label class="control-label">Druh čaje:</label>								
	                			<div class="controls" id="radios">          
	                			</div>
	                		</div>
		              		<div class="control-group">
								<label class="control-label" for="slider">Úprava času:</label>
								<div class="controls">
									<div class="span4" id="slider"></div>
								</div>
							</div>						
	              	</fieldset>	              	
	              		              						
	              <div class="form-actions">
	                <button id="btn-run" data-loading-text="Louhuju" class="btn btn-danger btn-large" type="button">
						<i class="icon-time icon-white"></i>
						Louhuj
					</button>&nbsp;
	              </div>
	            </form>
	            
			</div>			
          </div>
          
		  <div class="span3" style="text-align:center">
			<div class="well">
				<div class="clearfix">
					<img src="img/icon_pruhledna.png"><br/><br/>
				</div>
				<div class="clearfix">
					<a href="#" class="btn btn-default btn-large" style="width:120px" id="teaName"></a><br/><br/>
				</div>
				<div class="clearfix">
					<a href="#" class="btn btn-default btn-large" style="width:120px" rel="popover" id="teaTime" data-content="Jak dlouho se bude čaj louhovat." data-original-title="Čas">1:00</a><br/><br/>
				</div>
				<div class="clearfix">
					<a href="#" class="btn btn-default btn-large" style="width:120px" rel="popover" id="teaTemp" data-content="Při této teplotě by se měl vybraný čaj louhovat." data-original-title="Teplota">60C</a>
				</div>
				
			</div>
		  </div>
		</div>
		<div class="row">
			<div class="span7">				
	            <p><g:plusone annotation="inline" href="https://chrome.google.com/webstore/detail/hmldmlgafdbnfhhicheojakimpmocggp"></g:plusone></p>
	          	
			</div>
		</div>	
        

      <footer>
<!--           <p>&copy; lukas.marek (at) gmail.com, 2011</p> -->
	  	<script type="text/javascript">

			  var _gaq = _gaq || [];
			  _gaq.push(['_setAccount', 'UA-339099-9']);
			  _gaq.push(['_trackPageview']);

			  (function() {
    			var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
			    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
			    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
			  })();

		</script>
      </footer>

<a href="https://github.com/krtek/Tea-clock">
	<img style="position: absolute; z-index: 5; top: 0; right: 0; border: 0;"
		 src="http://s3.amazonaws.com/github/ribbons/forkme_right_red_aa0000.png"
		 alt="Fork me on GitHub" />
</a>


    </div> <!-- /container -->

<!-- modal(s) -->
	<div class="modal hide fade" id="countdownModal" tabindex="-1" role="dialog" aria-labelledby="countdownLabel" aria-hidden="true">
  <div class="modal-header">
    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
    <h3 id="countdownLabel">&nbsp;</h3>
  </div>
  <div class="modal-body">
  	<p><div style="text-align: center;"><h1 id="countdownTime">5:00</h1></div></p>
    <p><div class="progress progress-striped active">
  	<div class="bar" style="width: 100%;" id="countdownBar"></div>
</div></p>
  </div>
  <div class="modal-footer">
    <button class="btn btn-primary btn-large" data-dismiss="modal" aria-hidden="true" id="btn-reset"><i class="icon-repeat icon-white"></i>
    	Reset</button>    
  </div>
  </div>

    <!-- scripts -->
	
	<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
	<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/jquery-ui.min.js"></script>
    
    <script type="text/javascript" src="js/timer2.js"></script>
    <script type="text/javascript" src="js/teas_cs.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/bootstrap-button.js"></script>
    <script type="text/javascript" src="js/bootstrap-tooltip.js"></script>
    <script type="text/javascript" src="js/bootstrap-popover.js"></script>

  </body>
</html>
