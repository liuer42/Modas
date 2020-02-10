$(function() {
    initButtons();

    $('.flag').on('click', function () {
        // TODO: AJAX to update database
        if ($(this).data('checked')) {
            $(this).data('checked', false);
            $(this).removeClass('fas').addClass('far');
        } else {
            $(this).data('checked', true);
            $(this).removeClass('far').addClass('fas');
        }
    });

    // event listeners for first/next/prev/last buttons
    $('#next, #prev, #first, #last').on('click', function () {
        location.href = "page" + $(this).data('page');
    })

    function initButtons() {
        // disable prev/first buttons when on first page
        $('#first, #prev').prop('disabled', $('#start').html() == "1");
        // disable next/last buttons when on last page
        $('#last, #next').prop('disabled', $('#end').html() == $('#total').html());
    }

});