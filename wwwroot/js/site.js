// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// document.getElementById shorthand function
var byId = function( id ) { return document.getElementById( id ); };
// document.querySelector shorthand function
var bySelector = function( selector ) { return document.querySelector( selector ); };



window.onscroll = function() {scrollFunction()};

function scrollFunction() {
  if (document.body.scrollTop > 700 || document.documentElement.scrollTop > 700) {
    byId("navbar-toasty").classList.add("viewable");
  } else {
    byId("navbar-toasty").classList.remove("viewable");
  }
}