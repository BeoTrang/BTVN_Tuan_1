$(document).ready(function () {
    function send_api() {
        var data = {
            n: $('#TB1').val()
        };

        if (data.n=="" || isNaN(data.n)) {
            $('#KetQua').html('Nhập lại');
            $('#TB1').focus();
            return;
        }

        $('#KetQua').html('Đang tính toán...');
        
        $.post("api.aspx",data,
            function (kq, status) {
                $('#KetQua').html(kq);
            }
        );
    }
    $("#Button1").click(function () {
        send_api();
    });
});