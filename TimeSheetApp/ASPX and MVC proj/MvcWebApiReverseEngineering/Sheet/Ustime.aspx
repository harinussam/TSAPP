<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ustime.aspx.cs" Inherits="Sheet.Ustime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <link href="font-awesome-4.7.0/css/font-awesome.css" rel="stylesheet" />
    <link href="font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="container">
                <div class="header">
                    <nav class="navbar navbar-inverse">
                        <div class="container-fluid">
                            <div class="navbar-header">
                            </div>
                            <ul class="nav navbar-nav">
                                <li><a href="#"><i class="fa fa-home fa-3" aria-hidden="true"></i></a></li>
                                <li><a href="#">Timesheets</a></li>
                                <li><a href="#">Projects</a></li>
                                <li><a href="#">Reports</a></li>

                            </ul>
                            <ul class="nav navbar-nav navbar-right">
                                <ul class="nav navbar-nav">
                                    <li><a href="#">Help</a></li>
                                    <li><a href="#"><i class="fa fa-calendar fa-3" aria-hidden="true"></i></a></li>
                                    <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Ravi <span class="caret"></span></a>
                                        <ul class="dropdown-menu">
                                            <li><a href="#">View account</a></li>
                                            <li><a href="#">Others</a></li>
                                            <li><a href="#">Log out</a></li>
                                        </ul>
                                </ul>
                        </div>
                    </nav>
                </div>
                <div class="banner">
                    <ul class="nav navbar-nav">
                        <li><a href="#">Time</a></li>
                        <li><a href="#">Expenses</a></li>


                    </ul>
                </div>
                <div class="content">
                    <div class="content-left">
                        <h2>27 Feb-05 Mar 2017</h2>
                    </div>
                    <div class="content-right">
                        <div class="btn-toolbar" role="toolbar" style="margin: 0;">
                            <div class="btn-group">
                                <button type="button" class="btn btn-default"><i class="fa fa-angle-left fa-2" aria-hidden="true"></i></button>
                                <button type="button" class="btn btn-default">This week</button>
                                <button type="button" class="btn btn-default"><i class="fa fa-angle-right fa-2" aria-hidden="true"></i></button>

                            </div>
                            <div class="btn-group">
                                <button type="button" class="btn btn-default"><i class="fa fa-calendar-plus-o fa-1" aria-hidden="true"></i></button>
                            </div>
                            <div class="btn-group">
                                <button type="button" class="btn btn-default">Day</button>
                                <button type="button" class="btn btn-default">Week</button>


                            </div>

                        </div>
                    </div>
                </div>
                <div class="content1">
                    <div class="content1-left"></div>
                    <div class="content1-right">
                        <table width="500" border="0">
                            <tr>
                                <th>M</th>
                                <th>T</th>
                                <th>W</th>
                                <th>Th</th>
                                <th>F</th>
                                <th>S</th>
                                <th>Su</th>
                            </tr>
                            <tr>
                                <td>27 Feb</td>
                                <td>28 Feb</td>
                                <td>01 Mar</td>
                                <td>02 Mar</td>
                                <td>03 Mar</td>
                                <td>04 Mar</td>
                                <td>05 Mar</td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="footer">
                    <div class="footer-left">
                        [CFOPD-14-C-036B] DC 0CFO IT Support Services MITS Project
            (eKuber ventures Inc)
            <p>.Net Developer</p>
                    </div>
                    <div class="footer-right">
                        <table width="600" border="0" id="tabledemo">
                            <tr id="selectAll">
                                <td>
                                    <input id="day1" size="3" name="days" minlength="2" class="day" type="text" required=""/>

                                    <td>
                                        <input id="day2" type="text" name="days" class="day" size="3" required=""/>
                                    <td>
                                        <input id="day3" type="text" name="days" class="day" size="3" required=""/></td>
                                    <td>
                                        <input id="day4" type="text" name="days" class="day" size="3" /></td>
                                    <td>
                                        <input id="day5" type="text" name="days" class="day" size="3" /></td>
                                    <td>
                                        <input id="day6" type="text" name="days" class="day" size="3" /></td>
                                    <td>
                                        <input id="day7" type="text" name="days" class="day" size="3" /></td>
                                    <td id="workingHours"></td>
                                    <td>
                                        <button><i class="fa fa-times fa-3" aria-hidden="true"></i></button>
                                    </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="footer1">
                    <div class="footer1-left">
                        <div class="btn-group1">
                            <button type="button" class="btn btn-default"><i class="fa fa-plus fa-1" aria-hidden="true"></i>New Row</button>
                            <button type="button" class="btn btn-default">Save</button>


                        </div>
                    </div>
                    <div class="footer1-right">
                        <table width="600" border="0" id="calendar">
                            <tbody>
                                <tr>

                                    <td width="70" id="footer_day1"></td>
                                    <td width="60" id="footer_day2"></td>
                                    <td width="60" id="footer_day3"></td>
                                    <td width="60" id="footer_day4"></td>
                                    <td width="60" id="footer_day5"></td>
                                    <td width="60" id="footer_day6"></td>
                                    <td width="60" id="footer_day7"></td>
                                    <td width="60" id="workingHours"></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="footer2">
                    <div class="btn-group2">
                        <input class="submit" type="submit" value="Submit">
                    </div>
                </div>
            </div>


        </div>
    </form>
    <script>
        $("#commentForm").validate();
    </script>
    <script>
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
       



    </script>
</body>
</html>
