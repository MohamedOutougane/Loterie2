// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/* TIMER FUNCTIONNALITY */
function timerHandler() {

    var myDate = document.getElementById("dateNextSessions").value;
    var dateNextSessions = new Date(myDate.toLocaleString()).getTime();

    var x = setInterval(function () {
        var now = new Date((new Date).toLocaleString()).getTime();

        var difference = dateNextSessions - now;

        var minutes = Math.floor((difference % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((difference % (1000 * 60)) / 1000);

        document.getElementById("timerScreen").innerHTML = minutes + " : " + seconds;

        if (difference < 0) {
            clearInterval(x);
            document.getElementById("timerScreen").innerHTML = "EXPIRED";
        }
    }, 1000);
}

timerHandler();