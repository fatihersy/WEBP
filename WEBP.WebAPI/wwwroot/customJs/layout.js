function toggleSidepanelWidth() {

    var sidepanel = document.getElementById("sidepanel");
    var content = document.getElementById("content");

    if ($('#toggle-sidepanel-width').hasClass('fa-compress-alt'))
    {
        sidepanel.style.width = "75px";
        content.style.width = "calc(100% - 75px)";
        $('.sidepanel-item-text').css("display", "none");

        $('#toggle-sidepanel-width').toggleClass('fa-compress-alt');
        $('#toggle-sidepanel-width').toggleClass('fa-expand-alt');
    }
    else if ($('#toggle-sidepanel-width').hasClass('fa-expand-alt'))
    {
        sidepanel.style.width = "250px";
        content.style.width = "calc(100% - 250px)";
        $('.sidepanel-item-text').css("display", "flex");

        $('#toggle-sidepanel-width').toggleClass('fa-expand-alt');
        $('#toggle-sidepanel-width').toggleClass('fa-compress-alt');
    }


}