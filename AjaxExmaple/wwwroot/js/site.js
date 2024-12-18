// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

/*const { event } = require("jquery");*/

// Write your JavaScript code.
$(".customeRadio").change(function () {
    console.log("el radioboton fucnmiona");
    doCustomerUpdate();
})

function doCustomerUpdate()
{
    $.ajax({
        type: "POST",
        url: 'Customer/ShowOnePerson',
        data: $("form").serialize(),
        success: function (data) {
            console.log(data);
            $("#customerInformationArea").html(data);
        }
    })
};

$(function () {
    console.log("Page is ready");
    $("#selectCustomer").click(function () {
        event.preventDefault();
        console.log("select butonw as cliekd")

       
    })
});
