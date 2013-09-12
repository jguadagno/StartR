
$(function () {


    var qualification = $.connection.qualification
    // Add client-side hub methods that the server will call
    $.extend(qualification.client, {
        
        // myCilent is of type Domain.ClientQualification
        updateQualification: function (myClient) {
            var html = '<h2>Client Quality Information</h2>';
            html += 'Quality Rating: ' + myClient.QualityRating;
            html += ' | Best Time To Call: ' + myClient.BestCallTime;
            html += ' | Predictive Credit Score: ' + myClient.PredictiveCreditScore;
            html += ' | Today\'s Mood: ' + myClient.TodaysMood;
            $("#qualification").show().html(html);
        }
    });

    // Start the connection
    $.connection.hub.start()
        .pipe(init)
        .done(function (state) {
        });
});