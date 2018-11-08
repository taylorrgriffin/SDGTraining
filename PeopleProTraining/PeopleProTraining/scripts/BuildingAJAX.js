AddAntiForgeryToken = function(data) {
    data.__RequestVerificationToken = $('#__AjaxAntiForgeryForm input[name=__RequestVerificationToken]').val();
    return data;
};

function CreateBuildingWithAjax(url) {
    console.log("Creating with Ajax...")
    var bldg = $('#BuildingName').val();
    $.post(url + "/" + bldg, function ()
    {
        window.location.href = "../Building"
    });
    return null;
}

function EditBuildingWithAjax(url) {
    console.log("Saving with Ajax...")
    var aft = $('input[name="__RequestVerificationToken"]').val();
    $.ajax({
        url: url,
        data:
        {
            __RequestVerificationToken: aft,
            BuildingId: $('#BuildingId').val(),
            BuildingName: $('#BuildingName').val()
        } ,
        type: "post",
        datatype: "json",
        success: function () {
            window.location.href = '../'
        },
        error: function () {
            console.log("Something went wrong...")
        }
    });
    return null;
}