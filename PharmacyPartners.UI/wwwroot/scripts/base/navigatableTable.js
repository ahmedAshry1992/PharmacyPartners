$(".billtable").click(function () {
   
        var active = 0;
        //$('#navigate td').each(function(idx){$(this).html(idx);});
        rePosition();
    


        $(document).keydown(function (e) {
            reCalculate(e);
            rePosition();

            // if key is an arrow key, don't type the user
            // input. if it is any other key (a, b, c, etc)
            // edit the text
            if (e.keyCode > 36 && e.keyCode < 41) {
                return false;
            }
        });

        $('#navigate td').click(function () {
            active = $(this).closest('table').find('td').index(this);
            rePosition();
        });


        function reCalculate(e) {
            var rows = $('#navigate tr').length;
            var columns = $('#navigate tr:eq(0) td').length;
            var temp;

            if (e.keyCode == 37) { //move left or wrap
                temp = active;
                while (temp > 0) {
                    temp = temp - 1;
                    // only advance if there is an input field in the td
                    if ($('#navigate tr td').eq(temp).find('input').length != 0) {
                        active = temp;
                        break;
                    }
                }
            }
            if (e.keyCode == 38) { // move up
                temp = active;
                while (temp - columns >= 0) {
                    temp = temp - columns;
                    // only advance if there is an input field in the td
                    if ($('#navigate tr td').eq(temp).find('input').length != 0) {
                        active = temp;
                        break;
                    }
                }
            }
            if (e.keyCode == 39) { // move right or wrap
                temp = active;
                while (temp < (columns * rows) - 1) {
                    temp = temp + 1;
                    // only advance if there is an input field in the td
                    if ($('#navigate tr td').eq(temp).find('input').length != 0) {
                        active = temp;
                        break;
                    }
                }
            }
            if (e.keyCode == 40) { // move down
                temp = active;
                while (temp + columns <= (rows * columns) - 1) {
                    temp = temp + columns;
                    // only advance if there is an input field in the td
                    if ($('#navigate tr td').eq(temp).find('input').length != 0) {
                        active = temp;
                        break;
                    }
                }
            }
        }

        function rePosition() {
            console.log(active);
            $('.active').removeClass('active');
            $('#navigate tr td').eq(active).addClass('active');

            var input = $('#navigate tr td').eq(active).find('input').select();
            scrollInView();
        }

        function scrollInView() {
            var target = $('#navigate tr td:eq(' + active + ')');
            if (target.length) {
                var top = target.offset().top;

                $('html,body').stop().animate({
                    scrollTop: top - 100
                }, 400);
                return false;
            }
        }
      
});