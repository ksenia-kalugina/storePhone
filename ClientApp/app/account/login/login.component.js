var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../../data.service';
var LoginUserComponent = /** @class */ (function () {
    function LoginUserComponent(dataService, router) {
        this.dataService = dataService;
        this.router = router;
    }
    LoginUserComponent.prototype.ngOnInit = function () {
    };
    LoginUserComponent.prototype.submit = function (form) {
        console.log(form.value.name);
        this.login(form.value.name, form.value.email);
    };
    LoginUserComponent.prototype.login = function (email, password) {
        var _this = this;
        var user = {
            "Email": email,
            "Password": password
        };
        //this.dataService.getString();
        this.dataService.loginUser(user).subscribe(function (data) { return _this.router.navigateByUrl("/favorite"); });
    };
    LoginUserComponent = __decorate([
        Component({
            selector: 'my-app',
            providers: [DataService],
            template: "\n                <h2>\u0412\u0445\u043E\u0434</h2>\n                <form #myForm=\"ngForm\" novalidate>\n                    <div class=\"form-group\">\n                        <label>\u041B\u043E\u0433\u0438\u043D</label>\n                        <input class=\"form-control\" name=\"name\" [(ngModel)]=\"name\" required />\n                    </div>\n                    <div class=\"form-group\">\n                        <label>\u041F\u043E\u0440\u043E\u043B\u044C</label>\n                        <input class=\"form-control\" name=\"email\" ngModel \n                            required email />\n                    </div>                    \n                    <div class=\"form-group\">\n                        <button class=\"btn nav-link btn-warning d-inline-block\" (click)=\"submit(myForm)\">\u0412\u0445\u043E\u0434</button>\n                        <button class=\"nav-link btn btn-warning d-inline-block ml-2\" routerLink=\"/register\">\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u044F</button>\n                    </div>\n                    \n                </form>"
        }),
        __metadata("design:paramtypes", [DataService, Router])
    ], LoginUserComponent);
    return LoginUserComponent;
}());
export { LoginUserComponent };
//# sourceMappingURL=login.component.js.map