

$("#input-title").keypress(function (event) {
    if (event.which == 13)
    {
        $(".blog-table .blog-title").each(function ()
        {
            if ( $("#input-title").val() == "" )
            {
                $(this).parent().show();
            }
            else if ($("#input-title").val() == $(this).text() && $(this).is(":visible"))
            {
                $(this).parent().show();
            }
            else if ( $("#input-title").val() != $(this).text() )
            {
                $(this).parent().hide();
            }
        }); 
    }
});

$("#input-author").keypress(function (event)
{
    if (event.which == 13)
    {
        $(".blog-table .blog-author").each(function ()
        {
            if ($("#input-author").val() == "")
            {
                $(this).parent().show();
            }
            else if ($("#input-author").val() == $(this).text() && $(this).is(":visible"))
            {
                $(this).parent().show();
            }
            else if ($("#input-author").val() != $(this).text())
            {
                $(this).parent().hide();
            }
        });
    }
});

$("#input-category").keypress(function (event)
{
    if (event.which == 13)
    {
        $(".blog-table .blog-category").each(function ()
        {
            if ($("#input-category").val() == "") {
                $(this).parent().show();
            }
            else if ($("#input-category").val() == $(this).text() && $(this).is(":visible")) {
                $(this).parent().show();
            }
            else if ($("#input-category").val() != $(this).text()) {
                $(this).parent().hide();
            }
        });
    }
});

$("#input-aktifMi").keypress(function (event)
{
    if (event.which == 13)
    {
        $(".blog-table .blog-aktifMi").each(function ()
        {
            if ($("#input-aktifMi").val() == "")
            {
                $(this).parent().show();
            }
            else if ($("#input-aktifMi").val() == $(this).text() && $(this).is(":visible"))
            {
                $(this).parent().show();
            }
            else if ($("#input-aktifMi").val() != $(this).text())
            {
                $(this).parent().hide();
            }
        });
    }
});

$("#input-uniqueId").keypress(function (event) {
    if (event.which == 13)
    {
        $(".blog-table .blog-uniqueId").each(function ()
        {
            if ($("#input-uniqueId").val() == "") {
                $(this).parent().show();
            }
            else if ($("#input-uniqueId").val() == $(this).text() && $(this).is(":visible")) {
                $(this).parent().show();
            }
            else if ($("#input-uniqueId").val() != $(this).text()) {
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