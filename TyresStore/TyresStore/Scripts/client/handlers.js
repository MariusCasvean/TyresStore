window.onload = function () {
    mainModel = new MainModel();
}


function displayTyres(tyresHtml) {
    $("vehicle-table").addClass("w40");
    $(".right-icon").addClass("visible");

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