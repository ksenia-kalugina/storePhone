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
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../../data.service';
import { Router } from '@angular/router';
var PhoneDetailComponent = /** @class */ (function () {
    function PhoneDetailComponent(dataService, activeRoute, router) {
        this.dataService = dataService;
        this.router = router;
        this.loaded = false;
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }
    PhoneDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.dataService.IsAuthorize().subscribe(function (data) {
            if (data == false) {
                _this.router.navigateByUrl("/login");
            }
        });
        if (this.id)
            this.dataService.getPhone(this.id)
                .subscribe(function (data) { _this.phone = data; _this.loaded = true; });
    };
    PhoneDetailComponent.prototype.submit = function () {
        var _this = this;
        this.dataService.addItemInStoreCart(this.phone.id).subscribe(function (data) { return _this.router.navigateByUrl("/storeCart"); });
    };
    PhoneDetailComponent = __decorate([
        Component({
            templateUrl: './phone-detail.component.html',
            providers: [DataService]
        }),
        __metadata("design:paramtypes", [DataService, ActivatedRoute, Router])
    ], PhoneDetailComponent);
    return PhoneDetailComponent;
}());
export { PhoneDetailComponent };
//# sourceMappingURL=phone-detail.component.js.map