// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function formValidate() {
    var x = document.forms["myform"]["myinput"].value;
    if (x == "") {

        alert("fields are empty");
        

        return false;
    } else {
       
    }
}

function toggleClass(el) {
    var idvalue = document.getElementById('javaSidebar').children;
    for (var i = 0; i < idvalue.length; i++) {

        idvalue[i].className = "nav-link active";
    }

    el.className = "nav-link";


}
