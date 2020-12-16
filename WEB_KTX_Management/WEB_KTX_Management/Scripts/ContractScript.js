$(document).ready(function () {
    loadData();
});

function loadData() {
    $.ajax({
        url: "/Contract/GetListContract",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Stt + '</td>';
                html += '<td>' + item.NgayLamDon + '</td>';
                html += '<td>' + item.TenSinhVien + '</td>';
                html += '<td>' + item.TenTinhTrang + '</td>';
                html += '<td>' + item.NgayBatDau + '</td>';
                html += '<td>' + item.NgayKetThuc + '</td>';
                html += '<td><button type="button" class="btn btn-warning" data-toggle="modal" data-target="#myModal" onClick = "return detailContract(' + item.IdHopDong + ')">Chỉnh sửa hợp đồng</button></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}


function detailContract(Id) {
    $.ajax({
        url: "/Contract/DetailContract/" + Id,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $('#NgayBatDau').val(result.NgayBatDau);
            $('#NgayKetThuc').val(result.NgayKetThuc);
            $('#TinhTrang').val(result.TenTinhTrang);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}