$(function() {

    ////to set top active navbar selection
    $("#home a:contains('Home')").parent().addClass('active');
    $("#lessons a:contains('Lessons')").parent().addClass('active');
    $("#progress a:contains('Progress')").parent().addClass('active');
    $("#achievements a:contains('Achievements')").parent().addClass('active');

    //to set botton active navbar selection
    $("#account a:contains('Account')").parent().addClass('active');
    $("#about a:contains('About')").parent().addClass('active');
    $("#help a:contains('Help')").parent().addClass('active');
    $("#contact a:contains('Contact')").parent().addClass('active');
    
    

    var str = location.href.toLowerCase();
    $("#nav li a").each(function () {
        if (str.indexOf($(this).attr("href").toLowerCase()) > -1) {
            $("li.current-menu-item").removeClass("current-menu-item");
            $(this).parent().addClass("current-menu-item");
        }
    });
    $("li.current-menu-item").parents().each(function () {
        if ($(this).is("li")) {
            $(this).addClass("current-menu-item");
        }
    });

    //to expand menu when hovering over dropdown item
    $('ul.nav li.dropdown').hover(function () {
        $('dropdown-menu', this).fadeIn();
    }, function () {
        $('.dropdown-menu', this).fadeOut('fast');
    });

    $(document).ready(function () {
        $('[data-toggle="popover"]').popover();
    });
});

document.body.style.backgroundColor = "#47476b";