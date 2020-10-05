$(document).ready(function () {
    $('#DeliveryDate').datepicker({
        language: "es",
        format: "dd/mm/yyyy",
        autoclose: true,
        todayHighlight: true
    });
});

function SearchProduct() {
    let formData = new FormData();
    let idProduct = document.getElementById('searchProduct').value;
    formData.append("idProduct", idProduct);
    $.ajax({
        type: "post",
        url: "/Orders/searchProduct",
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        enctype: "multipart/form-data",
        success: function (data) {
            console.log(data[0]);
            if (data == "NoData") {
                console.log("No se encontraron datos");
            } else {
                document.getElementById('Clave').value = data[0];
                document.getElementById('Description').value = data[1];
            }
        },
        error: function (err, ajaxOptions, thrownError) {
                console.log("Error:" + err.status + ", " + thrownError);
        }
    });
}

var arrayProduct = [];

function addProduct() {
    let Clave = document.getElementById('Clave').value;
    let Description = document.getElementById('Description').value;
    let Quantity = document.getElementById('Quantity').value;

    arrayProduct.push([Clave, Description, Quantity]);
    console.log(arrayProduct);

    var divProduct = document.createElement("div");
    divProduct.setAttribute("class", "row tableProducts");
    divProduct.innerHTML = `<div class="col-md-2">${Clave}</div><div class="col-md-3">${Description}</div ><div class="col-md-5">${Description}</div><div class="col-md-2">${Quantity}</div>`;
    document.getElementById('tablePoducts').appendChild(divProduct);
}

function SaveOrder() {
    let formData = new FormData();
    let Customer = document.getElementById('Customer').value;
    let RFC = document.getElementById('RFC').value;
    let DeliveryDate = document.getElementById('DeliveryDate').value;
    let Comments = document.getElementById('Comments').value;
    formData.append("arrayProduct", arrayProduct);
    formData.append("Customer", Customer);
    formData.append("RFC", RFC);
    formData.append("DeliveryDate", DeliveryDate);
    formData.append("Comments", Comments);
    $.ajax({
        type: "post",
        url: "/Orders/saveOrder",
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        enctype: "multipart/form-data",
        success: function (data) {
            console.log(data[0]);
            if (data == "NoData") {
                console.log("No se encontraron datos");
            } else {
                document.getElementById('Clave').value = data[0];
                document.getElementById('Description').value = data[1];
            }
        },
        error: function (err, ajaxOptions, thrownError) {
            console.log("Error:" + err.status + ", " + thrownError);
        }
    });
}