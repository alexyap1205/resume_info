﻿$(function () {
    var experienceHub = $.connection.experienceHub;

    $(document).ready(function () {
    });

    $.connection.hub.start().done(function () {
        $("a").click(function () {
            $.blockUI({
                message: '<h3>Waiting for data...</h3>'
            });
            experienceHub.server.getDetail(this.id);
        });
    });

    experienceHub.client.updateDetail = function (id, detail) {
        $("#experienceDetail").show();
        var companyName = $("span[data-itemid='companyName']");
        companyName[0].textContent = detail.CompanyName;
        var title = $("span[data-itemid='title']");
        title[0].textContent = detail.Title;
        var duration = $("span[data-itemid='duration']");
        duration[0].textContent = detail.Duration;
        var summary = $("span[data-itemid='summary']");
        summary[0].textContent = detail.Summary;
        $.unblockUI();
    }


});