(function () {
    $(function () {
        // 增加列表行
        $('#createSave').click(function (e) {
            e.preventDefault();
            abp.ui.setBusy(
                abp.ajax({
                    url: abp.appPath + 'Users/Create',
                    type: 'POST',
                    dataType: 'json',
                    contentType: 'application/x-www-form-urlencoded',
                    data: $('#createForm').formSerialize()
                }).done(function (data) {
                    $('#createForm')[0].reset();
                    $("#createModal").modal("hide");
                    abp.notify.success("保存成功！");

                }).fail(function (data) {
                    abp.notify.error("发生错误！");
                })
            );
        });

        // 删除列表行
        $(".deleteflag").live("click", function () {
            var url = $(this).attr("url");
            abp.message.confirm(
                "", "确定要删除吗？",
                function (isConfirm) {
                    if (isConfirm) {
                        abp.ajax({
                            url: url,
                            type: 'get',
                        }).done(function (data) {
                            abp.notify.success("删除成功！");
                        }).fail(function (data) {
                            abp.notify.error("删除失败！");
                        })
                    }
                }
                )
        });
    });
})();