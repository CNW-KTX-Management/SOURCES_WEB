$(document).ready(function () {
    loadData();
});

function loadData() {
    $.ajax({
        url: "/SinhVien/ListSinhVien",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.MSSV + '</td>';
                html += '<td>' + item.Name + '</td>';
                html += '<td>' + item.NgaySinh + '</td>';
                html += '<td>' + item.Phone + '</td>';
                html += '<td>' + item.Passport + '</td>';
                html += '<td>' + item.GioiTinh + '</td>';
                html += '<td><a href="#" data-toggle="modal" data-target="#myModal" onClick = "return DetailSinhVien(' + item.Id + ')">Edit</a> | <a href="#" onClick = "return deleteSinhVien(' + item.Id + ')">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function AddSinhVien() {
    var sv = {
        Id: $('#id').val(),
        MSSV: $('#MSSV').val(),
        Name: $('#Name').val(),
        NgaySinh: $('#NgaySinh').val(),
        Phone: $('#Phone').val(),
        Passport: $('#Passport').val(),
        GioiTinh: $('#GioiTinh').val(),
    };

    $.ajax({
        url: "/SinhVien/AddSinhVien",
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

function EditSinhVien() {
    var sv = {
        Id: $('#id').val(),
        MSSV: $('#MSSV').val(),
        Name: $('#Name').val(),
        NgaySinh: $('#NgaySinh').val(),
        Phone: $('#Phone').val(),
        Passport: $('#Passport').val(),
        GioiTinh: $('#GioiTinh').val(),
    };
    $.ajax({
        url: "/SinhVien/EditSinhVien",
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
function hideUpdate() {
    $('#btnAdd').show();
    $('#btnUpdate').hide();
}
function deleteSinhVien(id) {
    $.ajax({
        url: "/SinhVien/DeleteSinhVien/" + id,
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
function DetailNhanVien(id) {
    $.ajax({
        url: "/SinhVien/DetailSinhVien/" + id,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $('#Id').val(result.Id);
            $('#Name').val(result.Name);
            $('#NgaySinh').val(result.NgaySinh);
            $('#Phone').val(result.Phone);
            $('#Passport').val(result.Passport);
            $('#GioiTinh').val(result.GioiTinh);
            $('#btnAdd').hide();
            $('#btnUpdate').show();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
