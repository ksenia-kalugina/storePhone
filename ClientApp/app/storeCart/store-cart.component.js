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
import { DataService } from '../data.service';
import { Router } from '@angular/router';
var StoreCartComponent = /** @class */ (function () {
    function StoreCartComponent(dataService, router) {
        this.dataService = dataService;
        this.router = router;
    }
    StoreCartComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.dataService.IsAuthorize().subscribe(function (data) {
            if (data == false) {
                _this.router.navigateByUrl("/login");
            }
        });
        this.dataService.getStoreCartList().subscribe(function (data) { return _this.list = data; });
        if (this.list == null) {
            this.isEmptyStoreCart = "Пусто";
        }
    };
    StoreCartComponent.prototype.submit = function (phoneid) {
        this.dataService.deleteItemInStoreCart(phoneid).subscribe(function (data) { return window.location.reload(); });
    };
    StoreCartComponent = __decorate([
        Component({
            templateUrl: './store-cart.component.html',
            providers: [DataService]
        }),
        __metadata("design:paramtypes", [DataService, Router])
    ], StoreCartComponent);
    return StoreCartComponent;
}());
export { StoreCartComponent };
//# sourceMappingURL=store-cart.component.js.map