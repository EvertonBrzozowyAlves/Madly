// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
console.log("Arquivos js principal");

function ajaxGET(url, data=''){
    $.ajax({
        type: "GET",
        url: url,
        data: param = data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success:
            function(result){
                debugger;
                return result.d;
            },
        error: 
            function(result){
                debugger;
                let teste = result;
                let teste2 = result.d;
            }
    });
}

function ajaxPOST(url, data=''){
    $.ajax({
        type: "POST",
        async: false,
        url: url,
        data: param = data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success:
            function(result){
                debugger;
                return result.d;
            },
        error: 
            function(result){
                debugger;
                let teste = result;
                let teste2 = result.d;
            }
    });
}