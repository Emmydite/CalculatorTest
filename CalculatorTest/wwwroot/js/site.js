/// <reference path="../lib/jquery/dist/jquery.js" />

$(function () {
    var baseUrl = 'https://localhost:7212/';

    $(document).on('click', '[data-dismiss="modal"]', function () {
        $('#num1').val('');
        $('#num2').val('');

        $('#result').text('');
    });

    // add
    $('#btn_add').on('click', function (e) {
  
        e.preventDefault();

        var num1 = $('#num1').val();
        var num2 = $('#num2').val();

        if (!(num1 && num2)) {
            $('.validation').text("Please enter a number in both fields");
            return;
        }
        else {

            num1 = parseInt(num1);
            num2 = parseInt(num2);
        }

        var dataValues = {
            Start : num1,
            Amount : num2
        };

        $.ajax({
            url: baseUrl + 'api/calculator/addition',
            dataType: 'json',
            type: 'get',
            data: dataValues,
            contentType: 'application/json',
            success: function (r) {

                var result = "Result : " + r;

                $('#result').text(result);
            },
            error: function (e) {
                console.log(e);
                alert('An error occurred');
            }
        });

    });

    // subtract
    $('#btn_sub').on('click', function (e) {

        e.preventDefault();

        var num1 = $('#num1').val();
        var num2 = $('#num2').val();

        if (!(num1 && num2)) {
            $('.validation').text("Please enter a number in both fields");
            return;
        }
        else {

            num1 = parseInt(num1);
            num2 = parseInt(num2);
        }

        var dataValues = {
            start: num1,
            amount: num2
        };

        $.ajax({
            url: baseUrl + 'api/calculator/subtraction',
            dataType: 'json',
            type: 'get',
            data: dataValues,
            contentType: 'application/json',
            success: function (r) {

                var result = "Result : " + r;

                $('#result').text(result);
            },
            error: function (e) {
                console.log(e);
                alert('An error occurred');
            }
        });

    });


});
