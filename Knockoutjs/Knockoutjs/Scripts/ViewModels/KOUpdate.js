var parsedSelectedCourse = $.parseJSON(selPeople);
$(function () {
    ko.applyBindings(modelUpdate);
});
var modelUpdate = {

    id: ko.observable(parsedSelectedCourse.id),
    nombre: ko.observable(parsedSelectedCourse.nombre),
    apellido: ko.observable(parsedSelectedCourse.apellido),
    correo: ko.observable(parsedSelectedCourse.correo),
    cedula: ko.observable(parsedSelectedCourse.cedula),

    updatePersona: function () {
        try {
            $.ajax({
                url: '/Home/Update',
                type: 'POST',
                dataType: 'json',
                data: ko.toJSON(this),
                contentType: 'application/json',
                success: successCallback,
                error: errorCallback
            });
        } catch (e) {
            window.location.href = '/Home/Update/';
        }
    }
};
function successCallback(data) {
    window.location.href = '/Home/Update/';
}
function errorCallback(err) {
    window.location.href = '/Home/Update/';
}