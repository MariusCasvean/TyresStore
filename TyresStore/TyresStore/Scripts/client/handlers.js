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