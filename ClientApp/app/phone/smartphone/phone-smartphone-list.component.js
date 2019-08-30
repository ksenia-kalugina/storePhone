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
import { DataService } from '../../data.service';
import { Router } from '@angular/router';
var PhoneSmartphoneListComponent = /** @class */ (function () {
    function PhoneSmartphoneListComponent(dataService, router) {
        this.dataService = dataService;
        this.router = router;
        this.nameCategory = "Смартфоны";
    }
    PhoneSmartphoneListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.dataService.IsAuthorize().subscribe(function (data) {
            if (data == false) {
                _this.router.navigateByUrl("/login");
            }
        });
        this.dataService.getSmartphonePhones().subscribe(function (data) { return _this.phones = data; });
    };
    PhoneSmartphoneListComponent.prototype.submit = function (phoneid) {
        var _this = this;
        this.dataService.addItemInStoreCart(phoneid).subscribe(function (data) { return _this.router.navigateByUrl("/storeCart"); });
    };
    PhoneSmartphoneListComponent = __decorate([
        Component({
            templateUrl: '../phone-list.component.html',
            providers: [DataService]
        }),
        __metadata("design:paramtypes", [DataService, Router])
    ], PhoneSmartphoneListComponent);
    return PhoneSmartphoneListComponent;
}());
export { PhoneSmartphoneListComponent };
//# sourceMappingURL=phone-smartphone-list.component.js.map