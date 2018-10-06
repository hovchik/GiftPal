// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {

    $.ajaxSetup({ cache: false });
    $('#wrapper').delegate('a.modalform', 'click', function (e) {

        if ($(this).is("[disabled]")) {
            return false;
        }
        $('#dialogContent').load(this.href, function () {
            $('#dialogDiv').modal({
                keyboard: true,
                backdrop: 'static'
            }, 'show').on('shown.bs.modal', function () {
                bindFormCustom();

                });

            bindForm(this);
        });
        return false;
    });
});

function bindForm(dialog) {
    var form = $('form', dialog);
    if (!form.length) {
        return;
    }

    //$.validator.unobtrusive.parse(form);
    $(form).submit(function () {
        if ($(this).valid()) {

            $(this).find('.btn').attr('disabled', 'disabled');
            $(this).find("a").removeAttr('href');

            performAjaxPost($(this));
        }
        return false;
    });
}

function performAjaxPost(form) {
    $.ajax({
        url: form.attr('action'),
        type: form.attr('method'),
        data: $(form).serialize(),
        success: function (result) {
            handleResponse(result);
        }
    });
}

function handleResponse(result) {
    if (typeof (handleResponseSpecial) !== "undefined") {
        handleResponseSpecial(result);
    }
    else {
        if (result.success) {

            $('#dialogDiv').modal('hide');
            if (result.redirectUrl !== null) {
                location.href = result.redirectUrl;
            } else {
                location.reload();
            }
        }
        else {
            $('#dialogContent').html(result);
            bindForm($('#dialogContent'));
        }
    }
}
function bindFormCustom() {
    $("#loginBtn").click(function () {
            $("#FNameDiv").addClass("hidden");
            $("#LNameDiv").addClass("hidden");
            $("#loginBtn").removeClass("inactive-tab");
            $("#regBtn").addClass("inactive-tab");
            $("#IsLogin").val("True");
    });
    $("#regBtn").click(function () {
            $("#FNameDiv").removeClass("hidden");
            $("#LNameDiv").removeClass("hidden");
            $("#regBtn").removeClass("inactive-tab");
            $("#loginBtn").addClass("inactive-tab");
            $("#IsLogin").val("False");
    });
}

$(window).scroll(function () {
    scrollMenu();
});
$(function () {
    scrollMenu();
})
function scrollMenu() {
    scroll_start = $(this).scrollTop();
    if (scroll_start > 300) {
        $('#mainNav').removeClass('bg-transparent').addClass('bg-white');
    } else {
        $('#mainNav').removeClass('bg-white').addClass('bg-transparent');
    }
}