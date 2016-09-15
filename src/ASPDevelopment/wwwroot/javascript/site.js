// site.js

(function ()
{
    /*var element = $("#username");
    element.text("William Zhou");

    var main = $("#main");
    main.on("mouseenter",
        function() {
            main.style["backgroundColor"] = "#888";
        });

    main.on("mouseleave",
        function() {
            main.style["backgroundColor"] = "";
        });

    var menuItems = $("ul.menu li a");
    menuItems.on("click",
        function () {
            var clickedPage = $(this);
            alert(clickedPage.text);
        });*/

    var $sidebarAndWrapper = $("#sidebar, #wrapper"); // wrapped set
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function() {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar"))
        {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else
        {
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right");
        }
    });
})();

