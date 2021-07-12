pharmacy.namespace("Globals");
pharmacy.Globals = (function () {
    "use strict";
    var counter = 0;
    var webapiurlbase = "https://localhost:44372/";

    function IsJsonString(str) {

        var type = "application/json;charset=utf-8";

        if (str) {
            try {
                JSON.parse(str);
            } catch (e) {
                type = "application/x-www-form-urlencoded; charset=UTF-8";
            }
        }


        return type;
    }

    return {

        MakeAjaxCall: function (httpmethod, URL, data, successCallback, failureCallback, aynch, showProgress) {

            if (typeof aynch == 'undefined')
                aynch = true;

            if (typeof showProgress == 'undefined')
                showProgress = true;

            if (showProgress) {
                counter++;
                if (counter > 0) {
                    $('#divProgressOverlay').show();
                    $('#divProgressStatus').show();
                    //ShowSpinner();
                }
            }

            var urltocall = webapiurlbase + URL;

            var defObj = $.ajax({
                type: httpmethod, //"POST"
                url: urltocall,
                data: data,
                async: aynch,
                contentType: IsJsonString(data),
                //beforeSend: function (request) {
                //    request.setRequestHeader("Authorization", 'Bearer ' + $('#__JWTCMS').val());
                //},
                success: function (resp) {

                    try {
                        var result = resp; // JSON.parse(resp);
                        if (successCallback)
                            successCallback(result);
                    } catch (err) {
                    }
                },
                error: function (err, type, httpStatus) {
                    if (err.status == 406) {
                        window.location.href = 'Login';
                        return;
                    }
                    if (failureCallback)
                        failureCallback(err, type, httpStatus);
                    else {
                        //alert(err.status + " - " + err.responseText + " - " + httpStatus);
                    }

                },
                complete: function () {
                    if (showProgress) {
                        counter--;
                        if (counter <= 0) {
                            $('#divProgressOverlay').hide();
                            $('#divProgressStatus').hide();
                           // HideSpinner();
                        }
                    }
                }
            });

            return defObj;
        }
        , loadDataTable: function (loc) {

            var pos = 0;

            if (loc && loc > 0) pos = loc;

            var $datatables = $('#demo-datatables-1');
            $datatables.DataTable({
                dom: "<'row'<'col-sm-6'i><'col-sm-6'f>>" + "<'table-responsive'tr>" + "<'row'<'col-sm-6'l><'col-sm-6'p>>",
                language: {
                    paginate: {
                        previous: '&laquo;',
                        next: '&raquo;'
                    },
                    search: "_INPUT_",
                    searchPlaceholder: "Search…"
                },
                order: [[pos, "desc"]]
            });
        }
        

    };
}());


