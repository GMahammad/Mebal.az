"use strict";

$(".fff").slick({
  dots: true,
  autoplay: true,
  autoplaySpeed: 3000
});
$(".eee").slick({
  infinite: true,
  slidesToShow: 4,
  autoplay: true,
  autoplaySpeed: 2000,
  responsive: [{
    breakpoint: 1024,
    settings: {
      slidesToShow: 3,
      slidesToScroll: 2,
      infinite: true,
      dots: true
    }
  }, {
    breakpoint: 790,
    settings: {
      slidesToShow: 2,
      slidesToScroll: 2,
      infinite: true,
      dots: true
    }
  }, {
    breakpoint: 480,
    settings: {
      slidesToShow: 1,
      slidesToScroll: 1
    }
  } // You can unslick at a given breakpoint now by adding:
  // settings: "unslick"
  // instead of a settings object
  ]
});
$(".mmm").slick({
  arrows: false,
  infinite: true,
  slidesToShow: 5,
  autoplay: true,
  autoplaySpeed: 2000,
  dots: false,
  responsive: [{
    breakpoint: 1314,
    settings: {
      slidesToShow: 4,
      slidesToScroll: 1,
      infinite: true,
      dots: true
    }
  }, {
    breakpoint: 1050,
    settings: {
      slidesToShow: 3,
      slidesToScroll: 1,
      infinite: true,
      dots: true
    }
  }, {
    breakpoint: 780,
    settings: {
      slidesToShow: 2,
      slidesToScroll: 1
    }
  } // You can unslick at a given breakpoint now by adding:
  // settings: "unslick"
  // instead of a settings object
  ]
});
$("#head-bar-click").click(function () {
  $(".side-menu-all").stop().slideDown(700);
});
$("#click-times").click(function () {
  $(".side-menu-all").stop().slideUp(700);
});
$(".category-click").click(function () {
  $(".category-down").stop().slideToggle(700);
});
$(".brand-click").click(function () {
  $(".brand-down").stop().slideToggle(700);
});