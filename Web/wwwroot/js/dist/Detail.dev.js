"use strict";

$('.main-det-photo').slick({
  slidesToShow: 1,
  slidesToScroll: 1,
  arrows: false,
  fade: true,
  asNavFor: '.bottom-det-photo'
});
$('.bottom-det-photo').slick({
  slidesToShow: 3,
  slidesToScroll: 1,
  asNavFor: '.main-det-photo',
  dots: true,
  centerMode: true,
  focusOnSelect: true,
  arrows: true,
  responsive: [{
    breakpoint: 1024,
    settings: {
      centerMode: false,
      slidesToShow: 3,
      slidesToScroll: 1,
      infinite: true,
      arrows: true
    }
  }, {
    breakpoint: 790,
    settings: {
      centerMode: true,
      arrows: true,
      slidesToShow: 4,
      slidesToScroll: 1,
      infinite: true
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
$(document).ready(function () {
  $('.minus').click(function () {
    var $input = $(this).parent().find('input');
    var count = parseInt($input.val()) - 1;
    count = count < 1 ? 1 : count;
    $input.val(count);
    $input.change();
    return false;
  });
  $('.plus').click(function () {
    var $input = $(this).parent().find('input');
    $input.val(parseInt($input.val()) + 1);
    $input.change();
    return false;
  });
});
$(".mel").click(function () {
  $(".bottom-info").stop().slideDown(500), $(".bottom-desc").stop().slideUp(500);
});
$(".xus").click(function () {
  $(".bottom-desc").stop().slideDown(500), $(".bottom-info").stop().slideUp(500);
});
$(".recommended-adv").slick({
  arrows: false,
  infinite: true,
  slidesToShow: 3,
  centerMode: true,
  centerPadding: '60px',
  autoplay: true,
  autoplaySpeed: 2000,
  dots: false,
  responsive: [{
    breakpoint: 1024,
    settings: {
      slidesToShow: 3,
      slidesToScroll: 1,
      infinite: true,
      centerMode: false
    }
  }, {
    breakpoint: 790,
    settings: {
      centerMode: false,
      slidesToShow: 2,
      slidesToScroll: 1,
      infinite: true
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