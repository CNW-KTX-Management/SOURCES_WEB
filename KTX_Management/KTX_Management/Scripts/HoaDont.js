
$(document).ready(function () {
    loadData();
});
function loadData() {
    $.ajax({
        url: "/Home/ListHoaDon",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.TenRoom + '</td>';
                html += '<td>' + item.TenNhanVien + '</td>';
                html += '<td>' + item.GiaDien + '</td>';
                html += '<td>' + item.GiaNuoc + '</td>';
                html += '<td>' + item.SoDienCu + '</td>';
                html += '<td>' + item.SoDienMoi + '</td>';
                html += '<td>' + item.SoNuocCu + '</td>';
                html += '<td>' + item.SoNuocMoi + '</td>';
                html += '<td>' + item.NgayLap + '</td>';
                html += '<td>' + item.ThanhTien + '</td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
