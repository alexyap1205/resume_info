$(function () {
    $(document).ready(function () {
        $.ajax({
            type: 'GET',
            url: 'api/skills/Overview',
            dataType: "json",
            async: true,
            success: function (data) {
                $("#Summary").text(data.ProfileSummary);

                $.each(data.GeneralSkills, function () {
                    $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#generalSkills'));
                });

                $.each(data.TechnicalSkills, function () {
                    $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#technicalSkills'));
                });

                $.each(data.OtherSkills, function () {
                    $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#otherSkills'));
                });
            }

        });
        //$.getJSON('api/skills/Overview')
        //    .done(function(data) {
        //        $("#Summary").text(data.ProfileSummary);

        //        $.each(data.GeneralSkills, function() {
        //            $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#generalSkills'));
        //        });

        //        $.each(data.TechnicalSkills, function () {
        //            $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#technicalSkills'));
        //        });

        //        $.each(data.OtherSkills, function () {
        //            $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#otherSkills'));
        //        });
        //    });
    });


});