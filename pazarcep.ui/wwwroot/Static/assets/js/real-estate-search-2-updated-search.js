/* Inputs advanced search

/************************************************************* */

$(document).ready(function(){
	$(".search-container #advanced-div").hide();
	
});

$(".search-container .text-input").focusin(function(){
	$(this).siblings("span").animate({"top": "-8px", "left": "22px", "font-size": "8px", "color": "#000"},200);
	$(this).siblings("span").css({"color": "rgb(173, 124, 46)"});
});


 $('.search-container .item-row-thumb').mouseenter(function() {
  $(this).siblings('.item-column-thumb-icon').animate(
    { deg: -90 },
    {
      duration: 100,
      step: function(now) {
        $(this).css({ transform: 'rotate(' + now + 'deg)' });
      }
    }
  ).css({"color": "#fff", "background-color": "#F6C500"});
});

  $('.search-container .item-row-thumb').mouseleave(function() {
  $('.search-container .item-column-thumb-icon').animate(
    { deg: 0 },
    {
      duration: 100,
      step: function(now) {
        $(this).css({ transform: 'rotate(' + now + 'deg)' });
      }
    }
  ).css({"color": "#F6C500", "background-color": "#fff"});
});

$(".search-container .text-input").focusout(function(){
if ($(this).val().length === 0) {
$(this).siblings("span").show();
	$(this).siblings("span").animate({"top": "4px", "left": "45px", "font-size": "12px"},200);
	$(this).siblings("span").css({"color": "rgb(190, 190, 190)"});
}
else{
	$(this).siblings("span").hide();
}
});


$(".search-container #advanced-btn").click(function(){
	$(".search-container #advanced-div").slideToggle("fast");
	$(this).text(function(i, text){
		return text === "Hide" ? "Advanced" : "Hide";
	})
});

/* Inputs alert us 

/************************************************************* */

$(document).ready(function(){
  $(".alertcontainer .search-sidebar").hide();
  
});

$(".alertcontainer .linkbell").click(function(){
  $(".alertcontainer .search-sidebar").slideToggle("fast");

});


$(".alertcontainer .text-input").focusin(function(){
  $(this).siblings("span").animate({"top": "-8px", "left": "22px", "font-size": "8px", "color": "#000"},200);
  $(this).siblings("span").css({"color": "rgb(173, 124, 46)"});
});

$(".alertcontainer textarea").focusin(function(){
  $(this).siblings("span").animate({"top": "-8px", "left": "22px", "font-size": "8px", "color": "#000"},200);
  $(this).siblings("span").css({"color": "rgb(173, 124, 46)"});
});

$(".alertcontainer textarea").focusout(function(){
if ($(this).val().length === 0) {
$(this).siblings("span").show();
  $(this).siblings("span").animate({"top": "8px", "left": "45px", "font-size": "10px"},200);
  $(this).siblings("span").css({"color": "rgb(190, 190, 190)"});
}
else{
  $(this).siblings("span").hide();
}
});



 $('.alertcontainer .item-row-thumb').mouseenter(function() {
  $(this).siblings('.item-column-thumb-icon').animate(
    { deg: -90 },
    {
      duration: 100,
      step: function(now) {
        $(this).css({ transform: 'rotate(' + now + 'deg)' });
      }
    }
  ).css({"color": "#fff", "background-color": "#F6C500"});
});

  $('.alertcontainer .item-row-thumb').mouseleave(function() {
  $('.alertcontainer .item-column-thumb-icon').animate(
    { deg: 0 },
    {
      duration: 100,
      step: function(now) {
        $(this).css({ transform: 'rotate(' + now + 'deg)' });
      }
    }
  ).css({"color": "#F6C500", "background-color": "#fff"});
});

$(".alertcontainer .text-input").focusout(function(){
if ($(this).val().length === 0) {
$(this).siblings("span").show();
  $(this).siblings("span").animate({"top": "8px", "left": "45px", "font-size": "10px"},200);
  $(this).siblings("span").css({"color": "rgb(190, 190, 190)"});
}
else{
  $(this).siblings("span").hide();
}
});




