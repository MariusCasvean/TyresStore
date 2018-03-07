function BasketModel() {
    var _self = this;
    this.basketItems = [];

    this.addItem = function (tyreId, description) {
        $.ajax({
            url: "Home/AddTyreToBasket",
            type: "post",
            data: { tyreId: tyreId, description: description },
            success: function (response) {
                if (!response.exists) {
                    _self.basketItems.push(tyreId);
                    updateCartCount();
                } else alert("Tyre already added");
            }
        });
    }

    this.getItems = function() {
        $.ajax({
            url: "Home/GetBasketItems",
            type: "get",
            success: function (response) {
                if (response)
                    _self.basketItems = response;

                updateCartCount();
            }
        });
    }

    this.getBasketHtml = function () {
        $.ajax({
            url: "Home/GetBasketHtml",
            type: "get",
            success: function (response) {
                if (response) {
                    $.colorbox({
                        html: response,
                        open: true,
                        iframe: false,
                        width: "50%",
                        height: "50%",
                        onComplete: function () {
                            $('html').css('overflow', 'hidden');
                        },
                        onClosed: function () {
                            $('html').css('overflow', 'auto');
                        }
                    });
                }
            }
        })
    }


    this.deleteItem = function (itemId) {
        $.ajax({
            url: "Home/RemoveItemFromBasket",
            type: "get",
            data: { itemId: itemId },
            success: function (response) {
                if (response) {
                    $('#cboxContent').find('.table').html(response);
                }
                else
                    $.colorbox.close();

                _self.basketItems.pop();
                updateCartCount();
            }
        });
    }


}