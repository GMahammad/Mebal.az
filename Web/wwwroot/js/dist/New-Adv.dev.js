 $("#head-bar-click").click(function(){
  $(".side-menu-all").stop().slideDown(700);
})
$("#aye").click(function(){
  $(".side-menu-all").stop().slideDown(500);
})
$(".agreement").click(function () {
  $(".info-new-adv").slideDown(700), $(".product-info").slideDown(700);
  $(".pro-img").slideDown(700);
  $(".product-info").slideDown(700);
  $(".agreement").slideUp();
  $(".pro-contact").slideDown(700);
});

$("#click-times").click(function () {
  $(".side-menu-all").stop().slideUp(700);
});