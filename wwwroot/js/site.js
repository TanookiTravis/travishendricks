// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// document.getElementById shorthand function
var $ = function( id ) { return document.getElementById( id ); };



window.onscroll = function() {scrollFunction()};

function scrollFunction() {
  if (document.body.scrollTop > 400 || document.documentElement.scrollTop > 400) {
    $("navbar-sticky").classList.add("viewable");
  } else {
    $("navbar-sticky").classList.remove("viewable");
  }
}