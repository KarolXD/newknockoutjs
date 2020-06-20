function AppViewModel() {

    var self = this;

    this.firstName = ko.observable('Bob');
    this.lastName = ko.observable('Smith');

    this.fullName = ko.computed(function () {
        return this.firstName() + " " + this.lastName();
    }, this);

    //-----Segundo ejemplo

    this.firstName2 = ko.observable('-');
    this.lastName2 = ko.observable('-');

    this.fullName2 = ko.computed(function () {
        return this.firstName2() + " " + this.lastName2();
    }, this);

}

ko.applyBindings(AppViewModel);