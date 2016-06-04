$(function () {
    $(document).ready(function () {
        $.ajax({
            type: 'GET',
            url: '/Education/GetEducations',
            dataType: "json",
            async: true,
            success: function (result) {
                    var educations = result;

                    var out = "<ul class=\"list-group\">";
                    $.each(educations,
                        function () {

                            out += "<li class=\"list-group-item\">";

                            out = out + "<h4 class=\"list-group-item-heading\">" + this.Title + "</h4>";
                            out = out + "<p class=\"list-group-item-text\">" + this.Institution + " (" + this.YearCompleted + ")</p><br/><br/>";
                            out = out + "<p>" + this.Summary + "</p><br/>";

                            out += "</li>";

                        });
                    out += "</ul>";

                    $("#educationList").html(out);
            }

        });

        //$.get("/Education/GetEducations", function (result) {
        //    var educations = result;

        //    var out = "<ul class=\"list-group\">";
        //    $.each(educations,
        //        function () {

        //            out += "<li class=\"list-group-item\">";

        //            out = out + "<h4 class=\"list-group-item-heading\">" + this.Title + "</h4>";
        //            out = out + "<p class=\"list-group-item-text\">" + this.Institution + " (" + this.YearCompleted + ")</p><br/><br/>";
        //            out = out + "<p>" + this.Summary + "</p><br/>";

        //            out += "</li>";

        //        });
        //    out += "</ul>";

        //    $("#educationList").html(out);
        //});
    });

});