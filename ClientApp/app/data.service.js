var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
var DataService = /** @class */ (function () {
    function DataService(http) {
        this.http = http;
        this.url = "/api/phones";
    }
    DataService.prototype.getPhones = function () {
        return this.http.get(this.url + '/allphones');
    };
    DataService.prototype.getPhone = function (id) {
        return this.http.get(this.url + '/' + id);
    };
    DataService.prototype.getFavoritePhones = function () {
        return this.http.get(this.url + '/favorite');
    };
    DataService.prototype.getSmartphonePhones = function () {
        return this.http.get(this.url + '/smartphone');
    };
    DataService.prototype.getUsualphonePhones = function () {
        return this.http.get(this.url + '/usualphone');
    };
    DataService.prototype.registerUser = function (user) {
        console.log(user.Email);
        return this.http.post('/api/account/register', user);
    };
    DataService.prototype.loginUser = function (user) {
        console.log(user.Email);
        return this.http.post('/api/account/login', user);
    };
    DataService.prototype.IsAuthorize = function () {
        return this.http.get('/api/account/IsAuthorize');
    };
    DataService.prototype.logoutUser = function () {
        console.log("exit");
        return this.http.get('/api/account/logout');
    };
    DataService.prototype.getStoreCartList = function () {
        console.log("exit2");
        return this.http.get('/api/storecart/getStoreCartList');
    };
    DataService.prototype.addItemInStoreCart = function (phoneId) {
        return this.http.post('/api/storecart/addItemInStoreCart', phoneId);
    };
    DataService.prototype.deleteItemInStoreCart = function (phoneId) {
        return this.http.post('/api/storecart/deleteItemInStoreCart', phoneId);
    };
    DataService.prototype.getString = function () {
        return this.http.get('/api/account/register');
    };
    DataService = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataService);
    return DataService;
}());
export { DataService };
//# sourceMappingURL=data.service.js.map