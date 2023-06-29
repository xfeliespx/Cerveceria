jQuery.each(jQuery('.nav').find('li'), function () {
    jQuery(this).toggleClass('active',
            jQuery(this).find('a').attr('href') == window.location.pathname);
    jQuery('.active').closest('li.dropdown').addClass('active');
    jQuery('.active').closest('ul').css('display', 'block');
});
