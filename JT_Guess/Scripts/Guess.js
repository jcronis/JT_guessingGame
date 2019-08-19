$(document).ready(function () {
    loadDoc = function () {
        var myData = { guess: $('#guessInput').val() };
        var myUrl = "/guess/guess";
            $.post(myUrl, myData)
                .done(function (data) {
                    $('#message').html("<p>" + data + "</p>");
                })
                .fail(function () {
                    console.log("Your Post failed dummy!")
                });
    }
});