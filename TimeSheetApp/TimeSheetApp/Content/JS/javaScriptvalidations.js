
    $("#commentForm").validate();

    $(document).ready(function () {
        $("#day1").keyup(function (e) {
            // alert(String.fromCharCode(e.which));
            $("#footer_day1").text($(this).val());

        });

        $("#day2").keyup(function (e) {
            $("#footer_day2").text($(this).val());


        });
        $("#day3").keyup(function (e) {
            $("#footer_day3").text($(this).val());


        });

        $("#day4").keyup(function (e) {
            $("#footer_day4").text($(this).val());


        });

        $("#day5").keyup(function (e) {
            $("#footer_day5").text($(this).val());


        });
        $("#day6").keyup(function (e) {
            $("#footer_day6").text($(this).val());

        });
        $("#day7").keyup(function (e) {
            $("#footer_day7").text($(this).val());

        });




        $(".fa-times").click(function () {
            // $(this).closest('td').remove();
            $(this).siblings().find('input').val('');


        });

        Number.prototype.padDigit = function () {
            return (this < 10) ? '0' + this : this;
        }
        //$(".submit").click(function (event) {
        //    event.preventDefault();
        //    // $(this).closest('td').remove();
        //    alert("Clicked");
        ////var data = $(this).parents('tr:eq(0)');
        //$(this).prevUntil("#selectAll").find('.days').each(function () {
        //    console.log(i);
        //    console.log($(this).val());
        //    var alldays = $(this).val();

        //$('#calendar tr').each(function () {

        //    $(this).find("td").eq(2).html();
        //    var day1 = $(this).find("td").eq(0).html();

        //    var day2 = $(this).find("td").eq(1).html();
        //    var day3 = $(this).find("td").eq(2).html();

        //    var day4 = $(this).find("td").eq(3).html();
        //    var day5 = $(this).find("td").eq(4).html();
        //    var day6 =$(this).find("td").eq(5).html();
        //    var day7 = $(this).find("td").eq(6).html();
        //    var alldays = Number(day1) + Number(day2) + Number(day3) + Number(day4) + Number(day5) + Number(day6) + Number(day7);
        //    alert(alldays);
        //    $("#workingHours").text(alldays);



        //$('.days').each(function () {
        //    alert($(this).html());
        //    alert($(this.text()));
        //});



        //});




        //var mins = 0;
        //var hrs = 0;
        //$(".submit").on('click', function (event) {
        //    event.preventDefault();
        //    var t1 = "00:00";
        //    $('input').each(function () {
        //        t1 = t1.split(':');
        //        var t2 = $(this).val().split(':');
        //        console.log(t1[1]);
        //        console.log(t1[2]);
        //        //mins = parseInt(t1[1]) + parseInt(t2[1]);
        //        //minhrs = Math.floor(parseInt(mins / 60));
        //        //hrs = parseInt(t1[0]) + parseInt(t2[0]) + minhrs;
        //        //mins = mins % 60;
        //        //t1 = hrs.padDigit() + ':' + mins.padDigit()
        //        console.log(t1)
        //    });
        //});


       

        $(".submit").on('click', function (event) {
            event.preventDefault();
            var sum = 0;


                   
            var first = true;

            $('table#tabledemo input[name=days]').each(function () {
                console.log($(this).val());
                   
                var hrs = "";
                var hours = "";
                var mins = "";
                if($(this).val()== "")
                {
                                
                                
                    if (first)

                    {

                        alert(" please  enter atleast one time value");
                        first = false;
                    }

                    $(this).val("00:00")
                                
                }
                          
                               
                               
                hrs = $(this).val().split(":")[0];
                mins = $(this).val().split(":")[1];
                hours = mins / 60;
                console.log(hours);
                               
                            
                sum += parseInt(hrs) + hours;

                           

                // sum += parseInt($(this).val())
            });

            $('#workingHours').text(sum);
            
        });
    });
       