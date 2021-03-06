﻿var Form = {
    OfficeId: null,

    loadOfficeDropdown: function () {
        var officeDATAURL = window.location.origin + "/Home/GetOffices";
        $.getJSON(officeDATAURL, function (data) {
            var items = '<option>Select an Office</option>';
            $.each(data, function (i, offices) {
                items += "<option value='" + offices.Id + "'>" + offices.ClinicName + "</option>";
            });
            $('#ddlFormOffice').html(items);
            $('#ddlFormOffice').selectpicker('refresh');
        });
    },
    loadUserData: function () {
        var DATAURL = window.location.origin + "/Account/GetUserdata";
        $.ajax({
            type: "GET",
            url: DATAURL,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                if (response !== null) {
                    $('#txtSalutation').val(response.Salutation);
                    $('#txtInitials').val(response.Initials);
                    $('#txtFirstName').val(response.FirstName);
                    $('#txtLastName').val(response.LastName);
                    $('#txtPhone').val(response.Phone);
                    $('#txtFax').val(response.Fax);
                    $('#txtAddressLine1').val(response.AddressLine1);
                    $('#txtAddressLine2').val(response.AddressLine2);
                    $('#txtAddressLine3').val(response.AddressLine3);
                    $('#txtCity').val(response.City);
                    $('#txtProvince').val(response.Province);
                    $('#txtCountry').val(response.Country);
                    $('#txtPostalCode').val(response.PostalCode);
                } else {
                    //alert("Something went wrong");
                }
            },
            failure: function (response) {
                //alert(response.responseText);
            },
            error: function (response) {
                //alert(response.responseText);
            }
        });
    },

    loadMenuItem: function (id) {
        if (Form.OfficeId != null && Form.OfficeId > -1) {
            if (id == 'formDesigner') {

                $("#nodataDiv").hide();
                FormControls.defaultLoad(); //private form.js file
                $("#tab-formDesigner").show();
                $("#formDesigner").css('display', '');
                $("#tab-formDesigner > a").click();

            }
            else if (id == 'formDefinedTag') {
                $("#nodataDiv").hide();
                PrivateTag.defaultLoad();
                $("#tab-formDefinedTag").show();
                $("#formDefinedTag").css('display', '');
                $("#tab-formDefinedTag > a").click();
            }
            else if (id == 'forms') {
                $("#nodataDiv").hide();
                FormAnswers.defaultLoad();
                $("#tab-forms").show();
                $("#forms").css('display', '');
                $("#tab-forms > a").click();
            }
            //else if (id == 'publicForms') {
            //    PublicFormControls.initializeFormBuilder();
            //    $("#tab-publicforms").show();
            //    $("#tab-publicforms > a").click();
            //}
            else if (id == 'formReports') {
                $("#nodataDiv").hide();
                FormReport.defaultLoad();
                $("#tab-formReports").show();
                $("#formReports").css('display', '');
                $("#tab-formReports > a").click();
            }
        }
        else {
            alert('please select an office first');
        }
        //   else if (id == 'definePublicTag') {
        //    $("#tab-definepublicTag").show();
        //    $("#tab-definepublicTag > a").click();
        //}

        ////reload all items
        //if (Form.OfficeId != null && Form.OfficeId > -1) {
        //    if (FormAnswers.isLoaded) {
        //        FormAnswers.defaultLoad();
        //        $("#nodataDiv").hide();
        //    }
        //    if (PrivateTag.isLoaded) {
        //        PrivateTag.defaultLoad();
        //        $("#nodataDiv").hide();
        //    }

        //    if (FormControls.isLoaded) {
        //        FormControls.defaultLoad();
        //        $("#nodataDiv").hide();
        //    }

        //    if (FormReport.isLoaded) {
        //        FormReport.defaultLoad();
        //        $("#nodataDiv").hide();
        //    }
        //}
    },

    formOfficeDropDownChange: function () {

        var officeId = $("#ddlFormOffice").val();
        if (officeId == '-1') {
            //show layout
            $("#nodataDiv").show();
            $("#formDesigner").hide();
            $("#definedTag").hide();
            $("#forms").hide();
            $("#reports").hide();


        } else {
            //load data
            //hide layout
            $("#nodataDiv").hide();
            //$("#formDesigner").show();
            //$("#definedTag").show();
            //$("#forms").show();
            //$("#reports").show();

            Form.OfficeId = officeId;

            //
            $("#tab-formDesigner").show();
            $("#tab-formDesigner > a").click();


            //if (FormControls.isLoaded)
            FormControls.defaultLoad();

            if (FormAnswers.isMenuOpen)
                FormAnswers.defaultLoad();

            //if (PrivateTag.isLoaded)
            //    PrivateTag.defaultLoad();


            if (FormReport.isLoaded)
                FormReport.defaultLoad();


        }
    }
}

$(document).ready(function () {
    Form.loadOfficeDropdown();
    Form.loadUserData();
});