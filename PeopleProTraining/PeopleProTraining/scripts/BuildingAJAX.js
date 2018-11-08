function CreateBuildingWithAjax(url) {
    console.log("Creating with Ajax...")
    var aft = $('input[name="__RequestVerificationToken"]').val();
    $.ajax({
        url: url,
        data: {
            __RequestVerificationToken: aft,
            BuildingName: $('#BuildingName').val(),
        },
        type: "post",
        datatype: "json",
        success: function () {
            window.location.href = "../Building"
        },
        error: function () {
            console.log("Something went wrong...")
        }
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