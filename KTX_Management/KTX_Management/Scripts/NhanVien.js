$(document).ready(function () {
    loadData();
});

function loadData() {
    $.ajax({
        url: "/NhanVien/ListNhanVien",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.Name + '</td>';
                html += '<td>' + item.ChucVu + '</td>';
                html += '<td>' + item.Phone + '</td>';
                html += '<td>' + item.DiaChi + '</td>';
                html += '<td>' + item.GioiTinh + '</td>';
                html += '<td>' + item.Status + '</td>';
                html += '<td>' + item.User + '</td>';
                html += '<td>' + item.Password + '</td>';
                html += '<td><a href="#" data-toggle="modal" data-target="#myModal" onclick = "return DetailNhanVien(' + item.Id + ')">Edit</a> | <a href="#" onclick = "return deleteNhanVien(' + item.Id + ')">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function AddNhanVien() {
    var sv = {
        MSSV: $('#id').val(),
        Name: $('#Name').val(),
        ChucVu: $('#ChucVu').val(),
        Phone: $('#Phone').val(),
        DiaChi: $('#DiaChi').val(),
        GioiTinh: $('#Status').val(),
        User: $('#User').val(),
        Password: $('#Password').val(),
    };

    $.ajax({
        url: "/NhanVien/AddNhanVien",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: JSON.stringify(sv),
        success: function (result) {
            if (result == 1) {
                loadData();
                $('#btnClose').trigger('click');
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function EditNhanVien() {
    var sv = {
        Id: $('#id').val(),
        Name: $('#Name').val(),
        ChucVu: $('#ChucVu').val(),
        Phone: $('#Phone').val(),
        DiaChi: $('#DiaChi').val(),
        GioiTinh: $('#Status').val(),
        User: $('#User').val(),
        Password: $('#Password').val(),
    };

    $.ajax({
        url: "/NhanVien/EditNhanVien",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: JSON.stringify(sv),
        success: function (result) {
            if (result == 1) {
                loadData();
                $('#btnClose').trigger('click');
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function DetailNhanVien(id) {
    $.ajax({
        url: "/NhanVien/DetailNhanVien/" + id,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $('#id').val(result.Id);
            $('#Name').val(result.Name);
            $('#ChucVu').val(result.ChucVu);
            $('#Phone').val(result.Phone);
            $('#DiaChi').val(result.DiaChi);
            $('#Status').val(result.Status);
            $('#User').val(result.User);
            $('#Password').val(result.Password);
            $('#btnAdd').hide();
            $('#btnUpdate').show();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function deleteNhanVien(id) {
    $.ajax({
        url: "/NhanVien/DeleteNhanVien/" + id,
        type: "DELETE",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (result == 1) {
                loadData();
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function hideUpdate() {
    $('#btnAdd').show();
    $('#btnUpdate').hide();
}
