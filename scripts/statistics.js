$(function(){
  $(".stat").each(function(){
    $(this).prop('Counter', 0).animate({
      Counter: $(this).text()
    }, {
      duration: 4000,
      easing: 'swing',
      
      step: function(now){
        $(this).text(Math.ceil(now)).digits();
      }
    });
  });
});

$.fn.digits = function(){ 
  return this.each(function(){ 
    $(this).text( $(this).text().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,") ); 
  });
};