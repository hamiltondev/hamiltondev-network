$(function(){
  var _preloadImage;

  _preloadImage = new Image();
  _preloadImage.src = "index/images/logo-error.gif";

  _preloadImage = new Image();
  _preloadImage.src = "index/images/logo-error-shake.gif";
});

function setQuoteString(string) {
  return $(".content-text .quote").text(string);
};

function setStatusString(string) {
  return $(".content-text .status").text(string);
};

var _showErrorMessage = false;

function showErrorMessage(title = "Something went terribly wrong during the initialization!", description = "Well, to be straight up honest with you... you shouldn't be seeing this message, that you are currently reading. Discord+ messed up big-time! Our bad!") {
  if(_showErrorMessage)
    return false;

  $(".content-error .title").text(title);
  $(".content-error .description").text(description);

  _showErrorMessage = true;

  return true;
};

var _showErrorMessageTimer = setInterval(_showErrorMessageInterval, 1399);

function _showErrorMessageInterval() {
  if(_showErrorMessage == false)
    return;

  $(".content-logo .logo img").attr("src", "index/images/logo-error.gif");
  $(".content-logo").css("padding-top", "0px");

  $(".content-logo .logo").addClass("logo-error");

  // fade the logo upwards
  setTimeout(function(){
    $(".content-logo .logo").css("height", "123px");

    $(".content-error").addClass("anim-fade-in");
  }, 2499);

  // fade the text content upwards & out
  setTimeout(function(){
    $(".content-text").addClass("anim-fade-out");

    setTimeout(function(){
      $(".content-logo .logo").css("height", "123px");

      $(".content-error").addClass("anim-fade-in");

      setTimeout(function(){
        $(".content-logo .logo img").attr("src", "index/images/logo-error-shake.gif");
      }, 5999);
    }, 299);
  }, 2199);

  clearInterval(_showErrorMessageTimer);
};