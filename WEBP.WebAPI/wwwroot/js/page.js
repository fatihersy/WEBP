
$(document).ready(() => {
    
    const searchBox = $('#search');
    
    searchBox.on('keypress', function(e)
    {
        const code = (e.keyCode ? e.keyCode : e.which);
        let searchValue = searchBox.val();
        if(code === 13) {
            //$("#submit-search").trigger('click')

            document.querySelectorAll(".post").forEach((p) => {
                    let postTitle = p.getAttribute("title").toUpperCase();
                    
                    if( postTitle.indexOf( searchValue ) > -1 )
                    {
                        $(p).show();
                    }
                    else {
                        $(p).hide();
                    }
            });
        }
    })

    $("#submit-search").on('click', function(e){
        e.preventDefault();
        
        
    })
})  // <= READY FUNCTION

const navBtn = $('.sli-nav-btn');
const slide = $('.slide');

$( navBtn[0] ).click(() => {
    
    $('.slider-navigation').find('.active-sli-nav-img').first().toggleClass('active-sli-nav-img');
    $('.slides').find('.active-slide').first().toggleClass('active-slide');

    $(navBtn[0]).children(".sli-nav-img").addClass('active-sli-nav-img');
    $( slide[0]).addClass('active-slide');
});

$( navBtn[1] ).click(() => {
    
    $('.slider-navigation').find('.active-sli-nav-img').first().toggleClass('active-sli-nav-img');
    $('.slides').find('.active-slide').first().toggleClass('active-slide');

    $(navBtn[1]).children(".sli-nav-img").addClass('active-sli-nav-img');
    $( slide[1]).addClass('active-slide');
});

$( navBtn[2] ).click(() => {
    
    $('.slider-navigation').find('.active-sli-nav-img').first().toggleClass('active-sli-nav-img');
    $('.slides').find('.active-slide').first().toggleClass('active-slide');

    $(navBtn[2]).children(".sli-nav-img").addClass('active-sli-nav-img');
    $( slide[2]).addClass('active-slide');
});


/*
$( $( classes.DSIDEPANELITEM )[ sidepanelButtonNums.INCELEME ]) .click(function ()
{
    if ( !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.INCELEME]).hasClass(classes.SIDEPANELACTIVEITEM) )
    {
        if (
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.HABER]).hasClass(classes.SIDEPANELACTIVEITEM) &&
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.ESPOR]).hasClass(classes.SIDEPANELACTIVEITEM)
        ) {
                    $( categories.HABER + ', ' + categories.ESPOR ).hide();
        }
        else
        {
            $( categories.INCELEME ).show();
        }
    }
    else
    {
        if (
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.HABER]).hasClass(classes.SIDEPANELACTIVEITEM) &&
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.ESPOR]).hasClass(classes.SIDEPANELACTIVEITEM)
        ) {
                    $(categories.HABER + ', ' + categories.ESPOR + ', ' + categories.INCELEME ).show();
        }
        else
        {
            $( categories.INCELEME ).hide();
        }
    }
    $(this).toggleClass(classes.SIDEPANELACTIVEITEM);
});


$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.HABER]).click(function ()
{
    if (!$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.HABER]).hasClass(classes.SIDEPANELACTIVEITEM))
    {
        if (
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.INCELEME]).hasClass(classes.SIDEPANELACTIVEITEM) &&
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.ESPOR]).hasClass(classes.SIDEPANELACTIVEITEM)
        ) {
            $(categories.INCELEME + ', ' + categories.ESPOR).hide();
        }
        else
        {
            $( categories.HABER ).show();
        }
    }
    else
    {
        if (
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.INCELEME]).hasClass(classes.SIDEPANELACTIVEITEM) &&
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.ESPOR]).hasClass(classes.SIDEPANELACTIVEITEM)
        ) {
            $(categories.HABER + ', ' + categories.ESPOR + ', ' + categories.INCELEME).show();
        }
        else
        {
            $( categories.HABER ).hide();
        }
    }
    $(this).toggleClass(classes.SIDEPANELACTIVEITEM);
});


$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.ESPOR]).click(function ()
{
    if (!$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.ESPOR]).hasClass(classes.SIDEPANELACTIVEITEM))
    {
        if (
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.HABER]).hasClass(classes.SIDEPANELACTIVEITEM) &&
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.INCELEME]).hasClass(classes.SIDEPANELACTIVEITEM)
        ) {
            $(categories.HABER + ', ' + categories.INCELEME).hide();
        }
        else {
            $( categories.ESPOR ).show();
        }
    }
    else
    {
        if (
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.HABER]).hasClass(classes.SIDEPANELACTIVEITEM) &&
            !$($(classes.DSIDEPANELITEM)[sidepanelButtonNums.INCELEME]).hasClass(classes.SIDEPANELACTIVEITEM)
        ) {
            $(categories.HABER + ', ' + categories.ESPOR + ', ' + categories.INCELEME).show();
        }
        else {
            $( categories.ESPOR ).hide();
        }
    }
    $(this).toggleClass(classes.SIDEPANELACTIVEITEM);
});
*/
/*
const sidepanelButtonNums = {
    INCELEME: 0,
    HABER: 1,
    ESPOR: 2
}

const categories = {
    INCELEME: '[inceleme]',
    HABER: '[haber]',
    ESPOR: '[espor]'
}

const classes = {
    DSIDEPANELITEM: ".sidepanel-item",
    SIDEPANELITEM:  "sidepanel-item",
    DPOST:  ".post",
    POST:   "post",
    DPOSTCATEGORY: ".post-category",
    POSTCATEGORY: "post-category",
    DSIDEPANELACTIVEITEM: ".sidepanel-item-active",
    SIDEPANELACTIVEITEM: "sidepanel-item-active"
}
*/
/*
function toggleSidepanelWidth() {

    if ($('#toggle-sidepanel-width').hasClass('fa-compress-alt'))
    {
        $('#sidepanel').css("width", "75px");
        $('#content').css("width", "calc(100% - 75px)");
        $('.sidepanel-item-text').css("display", "none");
        $('#sidepanel-toggle-item').prop("title", "Expand the Sidebar");

        $('#toggle-sidepanel-width').toggleClass('fa-compress-alt');
        $('#toggle-sidepanel-width').toggleClass('fa-expand-alt');
    }
    else if ($('#toggle-sidepanel-width').hasClass('fa-expand-alt'))
    {
        $('#sidepanel').css("width", "250px");
        $('#content').css("width", "calc(100% - 250px)");
        $('.sidepanel-item-text').css("display", "flex");
        $('#sidepanel-toggle-item').prop("title", "Collapse the Sidebar");

        $('#toggle-sidepanel-width').toggleClass('fa-expand-alt');
        $('#toggle-sidepanel-width').toggleClass('fa-compress-alt');
    }
}

*/


