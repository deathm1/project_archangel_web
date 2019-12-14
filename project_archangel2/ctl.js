$(document).ready(function(){
  $(".topnav").hide(0).fadeIn().slideDown("slow")
  $("#mpg").hide(0).fadeIn().slideDown("slow")
  $("#maincont").hide(0).fadeIn()
  $("#col1").hide(0).fadeIn(1000)
  $("#col2").hide(0).fadeIn(2000)
  $("#user_nav").css({"display":"none"})
  $("#user_data").css({"display":"none"})
  $("#sod").css({"display":"none"})
  checkIfLoggedIn();
}); 




var status = 0;
document.addEventListener("DOMContentLoaded", function() {
  checkIfLoggedIn();
});

function checkIfLoggedIn()
{

  if (auth2.isSignedIn.get()) {
    var profile = auth2.currentUser.get().getBasicProfile();
    var element = document.getElementById("val");
    element.innerHTML = "User Details";
  }
  else 
  {
    //User already logged in
    var element = document.getElementById("val");
    element.innerHTML = "User Details";
  }
}







function myFunction() {
    var x = document.getElementById("myTopnav");
    if (x.className === "topnav") {
      x.className += " responsive";
    } else {
      x.className = "topnav";
    }
  }


  function openWin(){
    window.open("home.html");
  }


  function onSignIn(googleUser) {
    var profile = googleUser.getBasicProfile();
    $("#user_data").css("none","block");
    $("#ppic").attr('src',profile.getImageUrl());
    $("#email").text(profile.getEmail());

    var profile1 = googleUser.getBasicProfile().getId();
    if(profile1!=null){
        $("#gsigninbtn").hide();
        $("#user_data").css({"display":"block"})
        $("#sod").css({"display":"block"})
        status = 1;
        var element = document.getElementById("val");
        element.innerHTML = "User Details";
    }
}



  function signOut() {
    var auth2 = gapi.auth2.getAuthInstance();
    auth2.signOut().then(function () {
      console.log('User signed out.');
      $("#user_data").css({"display":"none"})
      $("#sod").css({"display":"none"})
      $("#gsigninbtn").show();
      status = 0;
      var element = document.getElementById("val");
      element.innerHTML = "Sign In";
    });
  }