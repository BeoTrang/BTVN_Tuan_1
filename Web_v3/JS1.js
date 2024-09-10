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
                var json = JSON.parse(kq);
                if (json.ok) {
                    var uoc = json.msg;
                    var html = uoc;
                    $('#KetQua').html(html);
                }
                else {
                    $('#KetQua').html(hmtl);
                }
            }
        );
    }
    $("#Button1").click(function () {
        send_api();
    });
});