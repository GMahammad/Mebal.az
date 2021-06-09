
const togglePassword1 = document.querySelector('#togyourpass');
const password1 = document.querySelector('#yourpass');

togyourpass.addEventListener('click', function (e) {
  // toggle the type attribute
  const type = yourpass.getAttribute('type') === 'password' ? 'text' : 'password';
  yourpass.setAttribute('type', type);
  // toggle the eye slash icon
  this.classList.toggle('fa-eye-slash');
});
$(".category-click").click(function(){
  $(".category-down").stop().slideToggle(700);
})
$(".brand-click").click(function(){
  $(".brand-down").stop().slideToggle(700);
})

$("#head-bar-click").click(function(){
    $(".side-menu-all").stop().slideDown(700);
  })
  $("#click-times").click(function(){
    $(".side-menu-all").stop().slideUp(700);
  })
  $("#head-bar-clicka").click(function(){
    $(".side-menu-all").stop().slideDown(700);
  })
function checkPasswordMatch() {
                    var password = $("#mypass").val();
                    var confirmPassword = $("#yourpass").val();
                  
                    if (password != confirmPassword)
                    {
                        $("#CheckPasswordMatch").html("Təsdiq şifrəniz doğru deyil");
                        $("#sif").css({
                            "color":"red"
                        })
                        $("#sir").css({
                            "color":"red"
                        })
                    }
                    else
                        {
                            $("#CheckPasswordMatch").html("");
                            $("#sif").css({
                            "color":"black"
                        })
                        $("#sir").css({
                            "color":"black"
                        })
                          $(this).css({
                               "border-color":"orange"
                               });
                        }

                }
                    $(document).ready(function () {
                   $("#yourpass").keyup(checkPasswordMatch);
                });

$('#mypass').keyup(function(){
    if($(this).val().trim().length < 6 || $(this).val().trim() ==""){
       $("#CeckPasswordMatch").html("Şifrə ən azı 6 simvoldan ibarət olmalıdır!");
        $(this).css({
         "border-color":"red"
       });
    }
    else{
       $("#CeckPasswordMatch").html("");
  $(this).css({
         "border-color":"orange"
       });
    }
});

$('#myname').on('blur', function(){
  var a = $(this).val().trim();
    if(a.length > 2 && a != ""){
    
       $(this).css({
        "border-color":"orange"
      });
      $("#namealert").css({
       "display":"none"
     });
    }
    else{
      $(this).css({
        "border-color":"red"
      });
    }
});

$('#mysurname').on('blur', function(){
  var a = $(this).val().trim();
    if(a.length > 2 && a!=""){
      $(this).css({
        "border-color":"orange"
      });
      $("#suralert").css({
       "display":"none"
     });
     
    }
    else{
     
      $(this).css({
        "border-color":"red"
      });

    }
});

$('#phone').on('blur', function(){
  var a = $(this).val().trim();
    if(a.length > 0 && a!=""){
      $(this).css({
        "border-color":"orange"
      });
      $("#phonealert").css({
        "display":"none"
      });
    }
    else{
       
       $(this).css({
        "border-color":"red"
      });

    }
});

$('#mail').on('blur' ,function(){
  var a = $(this).val().trim();

    if(a.length >= 6 && a!=""){
      $(this).css({
        "border-color":"orange"
      });
      $("#mailalert").css({
       "display":"none"
     });
       
     
    }
    else{
      
      $(this).css({
        "border-color":"red"
      });

    }
});



$(".reg-button").click(function(){
if($("#myname").val().length == 0 || $("#mysurname").val().length == 0 ||  $("#phone").val().length == 0 ||  $("#mail").val().length == 0 ){
  alert('Qeydiyyat üçün bütün boş xanalar doldurulmalıdır!!!');
  if(b.length==0 && b ==""){
    $("#myname").css({
      "border-color":"red"  
    });
    $("#namealert").css({
      "display":"block"
    })
    
  }
  if(b.length!=0 && b!=""){
    $("#myname").css({
      "border-color":"orange"  
    });
    $("#namealert").css({
      "display":"none"
    })
    
  }

  if(c.length!=0 && c!=""){
    $("#mysurname").css({
      "border-color":"orange"  
    });
    $("#surealert").css({
      "display":"none"
    })
    
  }
  if(d.length!=0 && d!=""){
    $("#phone").css({
      "border-color":"orange"  
    });
    $("#phonealert").css({
      "display":"none"
    })
    
  }
   if(e.length!=0 && e!=""){
    $("#mail").css({
      "border-color":"orange"  
    });
    $("#mailalert").css({
      "display":"none"
    })
    
  }
  
  if(c.length==0 && c ==""){
    $("#mysurname").css({
      "border-color":"red"  
    });
    $("#suralert").css({
      "display":"block"
    })
  }
  if(d.length==0 && d ==""){
    $("#phone").css({
      "border-color":"red"  
    });
    $("#phonealert").css({
      "display":"block"
    })
  } if(e.length==0 && e ==""){
    $("#mail").css({
      "border-color":"red"  
    });
    $("#mailalert").css({
      "display":"block"
    })
  } 
  
  
  
  if($("#mypass").val().length==0){
    $("#mypass").css({
      "border-color":"red"  
    });
    if($("#yourpass").val().length==0){
      $("#yourpass").css({
        "border-color":"red"  
      });
    }

  }
 
}
});
            