/// <reference path="/Scripts/jquery-1.8.0.intellisense.js" />
try {
	$(document).ready(function () {
		$("a[href*='http://']:not([href*='" + location.hostname + "'])").attr("rel", "external");
		$("a.newWindow").attr("target", "_blank");
		$("a[rel*='external']").click(function () {
			if (_gaq) {
				_gaq.push(['_trackEvent', 'Outgoing', 'Click', $(this).attr('href')]);
			}
		});
	});
} catch (ex) { }