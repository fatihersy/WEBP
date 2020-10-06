
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

// READY FUNCTIONS

$(function () {
    $('[data-toggle]').tooltip();
});

function goToBlog(id) {
    window.location.href = "/blog?id=" + id;
};

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


