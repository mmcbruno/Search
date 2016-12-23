$(document).ready(function () {
    $("#searchString").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Search/Autocomplete",
                type: "POST",
                dataType: "json",
                data: { prefix: request.term },
                success: function(data) {
                    response($.map(data,
                        function(item) {
                            return { label: item.Title, value: item.Title };
                        }));

                }
            });
        } 
    });

 

    //$(".flowers-pic").click(function (e) {
    //    var currentImg = $(e.target);
    //    var flower = currentImg.attr("alt");
    //    $("#modal-title").html(flower);
    //    $("#modal-pic").attr("alt", flower).attr("src", currentImg.attr("src"));
    //    $("#flowerModal").modal("show");
    //});
 
    

    $(".flowers-pic").click(function(e) {
        $("#img01").attr("src", this.src);
        $("#caption").html(this.alt);
        $("#flower").show();


    });
    $("span.close").click(function() {
        $("#flower").hide();
    });
    
    
   

})