

$("#input-title").keypress(function (event) {
    let iTitle = $("#input-title");
    
    if (event.which === 13)
    {
        $(".blog-table .blog-title").each(function ()
        {
            if ( iTitle.val() === "" )
            {
                $(this).parent().show();
            }
            else if (iTitle.val() === $(this).text() && $(this).is(":visible"))
            {
                $(this).parent().show();
            }
            else if ( iTitle.val() !== $(this).text() )
            {
                $(this).parent().hide();
            }
        }); 
    }
});

$("#input-author").keypress(function (event)
{
    let iAuthor = $("#input-author");
    
    if (event.which === 13)
    {
        $(".blog-table .blog-author").each(function ()
        {
            if (iAuthor.val() === "")
            {
                $(this).parent().show();
            }
            else if (iAuthor.val() === $(this).text() && $(this).is(":visible"))
            {
                $(this).parent().show();
            }
            else if (iAuthor.val() !== $(this).text())
            {
                $(this).parent().hide();
            }
        });
    }
});

$("#input-category").keypress(function (event)
{
    let iCategory = $("#input-category");
    
    if (event.which === 13)
    {
        $(".blog-table .blog-category").each(function ()
        {
            if (iCategory.val() === "") {
                $(this).parent().show();
            }
            else if (iCategory.val() === $(this).text() && $(this).is(":visible")) {
                $(this).parent().show();
            }
            else if (iCategory.val() !== $(this).text()) {
                $(this).parent().hide();
            }
        });
    }
});

$("#input-aktifMi").keypress(function (event)
{
    let iActive = $("#input-category");
    
    if (event.which === 13)
    {
        $(".blog-table .blog-aktifMi").each(function ()
        {
            if (iActive.val() === "")
            {
                $(this).parent().show();
            }
            else if (iActive.val() === $(this).text() && $(this).is(":visible"))
            {
                $(this).parent().show();
            }
            else if (iActive.val() !== $(this).text())
            {
                $(this).parent().hide();
            }
        });
    }
});

$("#input-uniqueId").keypress(function (event) 
{
    let iUniqueId = $("#input-category");
    
    if (event.which === 13)
    {
        $(".blog-table .blog-uniqueId").each(function ()
        {
            if (iUniqueId.val() === "") {
                $(this).parent().show();
            }
            else if (iUniqueId.val() === $(this).text() && $(this).is(":visible")) {
                $(this).parent().show();
            }
            else if (iUniqueId.val() !== $(this).text()) {
                $(this).parent().hide();
            }
        });
    }
});


/*
$("[blog-title-input]").bind("keypress", function ()
{
    $(".blog-title").each(function ()
    {
        if ($("[blog-title-input]").text())
        {
            $(this).parent().show();
        }
        else
        {
            $(this).parent().hide();
        }
    });
});
*/