$(function() {
    "use strict";

    //****************************
    /* Top navbar Theme Change function Start */
    //****************************
    function handlenavbarbg() {
        if ( $('#main-wrapper').attr('data-navbarbg') == 'skin6' ) {
            // do this
            $(".topbar .navbar").addClass('navbar-light');
            $(".topbar .navbar").removeClass('navbar-dark');
        } else {
            // do that    
        }    
    };

    handlenavbarbg();
});