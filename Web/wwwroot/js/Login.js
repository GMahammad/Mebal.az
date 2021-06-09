$("#head-bar-click").click(function(){
    $(".side-menu-all").stop().slideDown(700);
  })
  $("#click-times").click(function(){
    $(".side-menu-all").stop().slideUp(700);
  })
  $("#head-bar-clicka").click(function(){
    $(".side-menu-all").stop().slideDown(700);
  })
  $(".category-click").click(function(){
    $(".category-down").stop().slideToggle(700);
  })
  $(".brand-click").click(function(){
    $(".brand-down").stop().slideToggle(700);
  })
  
  $("#logi").click(function(){
    $(".log-reg").css({
      "height":"0",
      "transition":"1s"

    });
    $("#logi").slideUp(100);
    $("#regis").slideUp(100);
    $(".all-login").css({
      "height":"400px",
      "transition":"3s"
    });
    $(".lo").slideDown(2000);
  $("#little").slideUp(100);

  })

  const togglePassword = document.querySelector('#togyourpass');
  const password = document.querySelector('#mine');

togyourpass.addEventListener('click', function (e) {
  // toggle the type attribute
  const type = mine.getAttribute('type') === 'password' ? 'text' : 'password';
  mine.setAttribute('type', type);
  // toggle the eye slash icon
  this.classList.toggle('fa-eye-slash');
});
