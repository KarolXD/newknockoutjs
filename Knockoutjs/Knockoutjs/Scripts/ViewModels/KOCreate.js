
$(function () {
    ko.applyBindings(modelCreate);
});

var modelCreate = {

    nombre :ko.observable(),
    apellido: ko.observable(),
    correo: ko.observable(),
    cedula:ko.observable(),
  

    SaveStudent: function () {
 
        $.ajax({
            url: '/Home/Create',
            type: 'post',
            dataType: 'json',
            data: ko.toJSON(this),
            contentType: 'application/json',
            success: function (result) {
                console.log(this.nombre);
            },
            error: function (err) {
                if (err.responseText == "Creation Failed") { window.location.href = '/Home/Index/'; }
                else {
                    alert("Status:" + err.responseText);
                    window.location.href = '/Home/Registrar/';
                }
            },
            complete: function () {
                window.location.href = '/Home/Registrar/';
            }
        });
    }
};
