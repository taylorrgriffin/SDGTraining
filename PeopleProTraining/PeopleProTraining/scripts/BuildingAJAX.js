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
    var bldgObj =
    {
        BuildingId: $('#BuildingId').val(),
        BuildingName: $('#BuildingName').val()
    }
    console.log(bldgObj);
    $.ajax({
        url: url,
        data: bldgObj,
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