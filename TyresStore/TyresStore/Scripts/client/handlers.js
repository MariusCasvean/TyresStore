window.onload = function () {
    mainModel = new MainModel();
}


function displayTyres(tyresHtml) {
    $(".table-vehicle").addClass("w40");
    $(".right-icon").addClass("visible");
    $(".optionalColumns").hide();


    $(".tyres-table .table-content").html("");
    var htmlContent = tyresHtml;

    if (tyresHtml.length > 0)
        $(".tyres-table .table-content").append(htmlContent);
    else
        $(".tyres-table .table-content").append("<span class='no-data-message'>No tyres available for this vehicle.</span>");

    //mainModel.showLoadingTyres = false;
}

function updateCartCount() {
    $(".cart-button").html("(" + basketModel.basketItems.length + ")");
};


//// implement the animation tables function
//$.('.select-vehicle-button').on('click', function () {
//    if ($(this).parent().find("vehicle-table").hasClass("animated")) {
//        $('.vehicle-content').animate({
//            width: "50%",
//            duration: 100 //ms
//        }, {
//                complete: function () {
//                    $(this).parents().find(".tyres-table").fadeIn("slow");
//                    $(this).addClass("animated");
//                    $('close-button').fadeIn("slow");
//                }
//            });
//    }
//    else {
//        $(this).parents().find(".tyres-table").hide();
//        $(this).parents().find(".tyres-table").fadeIn("slow");
//    }
//});

//$('.close-button, .right-arrow').on('click', function () {
//    $(".tyres-table").hide();
//    $(".close-button").hide();

//    $('.vehicle-content').animate({
//        width: "100%",
//        duration: 100
//    }, {
//            complete: function () {
//                //missing code here
//            }
//        })
//})