function CreateBuildingWithAjax(url) {
    console.log("Creating with Ajax...")
    var bldg = $('#BuildingName').val();
    $.post(url + "/" + bldg, function () { });
    $.get(url)
    return null;
}

function EditBuildingWithAjax(url) {
    console.log("Saving with Ajax...")
    //var bldg_new = $('#BuildingName').val();
    //$.post(url + "/" + bldg_new, function () { });
    return null;
}

function Reload() {
    window.location.reload();
}