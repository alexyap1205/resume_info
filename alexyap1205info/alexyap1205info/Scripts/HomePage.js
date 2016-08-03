$(function () {
    $(document).ready(function () {
        //$('.carousel')
        //    .carousel({
        //        interval: 5000 //changes the speed
        //    });
        $.blockUI({
            message: '<h3>Loading...</h3>'
        });

        $.ajax({
            type: 'GET',
            url: 'api/skills/Overview',
            dataType: "json",
            async: true,
            success: function(data) {
                $("#Summary").text(data.ProfileSummary);

                $.each(data.GeneralSkills,
                    function() {
                        $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#generalSkills'));
                    });

                $.each(data.TechnicalSkills,
                    function() {
                        $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#technicalSkills'));
                    });

                $.each(data.OtherSkills,
                    function() {
                        $('<li>', { text: this.Name, title: this.Summary }).appendTo($('#otherSkills'));
                    });
                $.unblockUI();
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                $.unblockUI();
                window.location.replace("http://www.alexyap1205.info/resume/#");
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