$(window).on('resize load ', function () {
    $('body').css({
        "padding-top": $(".navbar").height() + "px"
    });
});

$(document).ready(function () {
    $('body').css({
        "padding-top": $(".navbar").height() + "px"
    });
});

function carouselNormalization(carouselId) {
    var items = $(carouselId + ' .item'),
        heights = [],
        tallest;
    // grab all the slides array, store height, find maximum and set to all items.
    if (items.length) {
        function normalizeHeights() {
            items.each(function () {
                heights.push($(this).height());
            });                                             

            tallest = Math.max.apply(null, heights);
            items.each(function () {
                $(this).css('min-height', tallest + 'px');
            });                                             
        };

        normalizeHeights();

        $(window).on('resize orientationchange', function () {
            tallest = 0, heights.length = 0;  // reset the variables

            items.each(function () {
                $(this).css('min-height', '0');  // reset each slide's height
            });

            normalizeHeights();  // run it again
        });
    }
}