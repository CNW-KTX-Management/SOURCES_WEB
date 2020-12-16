$(document).ready(function () {
    loadData();
});

function loadData() {
    var passpordRequest = {
        user: phuc,
        password: 123
    }
    $.ajax({
        url: "Login",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: JSON.stringify(passpordRequest),
        success: function (result) {
            $('#user').val(result.user);
            $('#password').val(result.password);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}