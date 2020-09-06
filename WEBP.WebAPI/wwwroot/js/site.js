
const sidebarButtons = {
    INCELEME: 0,
    HABER: 1,
    ESPOR: 2
}

// READY FUNCTIONS




$(function () {
    $('[data-toggle]').tooltip();
});


$( $('.sidepanel-item')[sidebarButtons.INCELEME] ) .click(function ()
{
    $("table tr td .category").each(function ()
    {
        if ($(this).text() == "denemeİ1") {
            console.log($(this).parent().hide());
        }
    });
});


$( $('.sidepanel-item')[sidebarButtons.HABER] ).click(function ()
{
    $("table tr td .category").each(function ()
    {
        if ($(this).text() == "denemeİ1") {
            console.log($(this).parent().hide());
        }
    });
});


$( $('.sidepanel-item')[sidebarButtons.HABER] ).click(function ()
{
    $("table tr td .category").each(function ()
    {
        if ($(this).text() == "denemeİ1") {
            console.log($(this).parent().hide());
        }
    });
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


