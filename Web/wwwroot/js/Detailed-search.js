(function() {
    var parent = document.querySelector(".price-slider");
    if(!parent) return;
    var
      rangeS = parent.querySelectorAll("input[type=range]"),
      numberS = parent.querySelectorAll("input[type=number]");
  
    rangeS.forEach(function(el) {
      el.oninput = function() {
        var slide1 = parseFloat(rangeS[0].value),
              slide2 = parseFloat(rangeS[1].value);
  
        if (slide1 > slide2) {
          [slide1, slide2] = [slide2, slide1];
        }
  
        numberS[0].value = slide1;
        numberS[1].value = slide2;
      }  
    });
  
    numberS.forEach(function(el) {
      el.oninput = function() {
          var number1 = parseFloat(numberS[0].value),
          number2 = parseFloat(numberS[1].value);
  
        if (number1 > number2) {
          var tmp = number1;
          numberS[0].value = number2;
          numberS[1].value = tmp;
        }
  
        rangeS[0].value = number1;
        rangeS[1].value = number2;
  
      }
    });
  })();
  $("#head-bar-click").click(function(){
    $(".side-menu-all").stop().slideDown(700);
 })
 $("#head-bar-clicka").click(function(){
  $(".side-menu-all").stop().slideDown(700);
})
 $("#click-times").click(function(){
    $(".side-menu-all").stop().slideUp(700);
 })
 $(".category-click").click(function(){
  $(".category-down").stop().slideToggle(700);
})
$(".brand-click").click(function(){
  $(".brand-down").stop().slideToggle(700);
})

$(".mmm").slick({
    arrows:false,
   infinite: true,
   slidesToShow: 5,
   autoplay: true,
    autoplaySpeed: 2000,
    dots:false,
    responsive: [
      {
        breakpoint: 1314,
        settings: {
          slidesToShow: 4,
          slidesToScroll: 1,
          infinite: true,
          dots: true
        }
      },
      {
        breakpoint: 1050,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1,
          infinite: true,
          dots: true
        }
      },
      {
        breakpoint: 780,
        settings: {
          slidesToShow: 4,
          slidesToScroll: 1
        }
      },
      {
        breakpoint: 670,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1
        }
      },
      {
        breakpoint: 400,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1
        }
      }

      // You can unslick at a given breakpoint now by adding:
      // settings: "unslick"
      // instead of a settings object
    ]
 })
