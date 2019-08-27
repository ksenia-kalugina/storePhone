var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { PhoneListComponent } from './phone/allphones/phone-list.component';
import { PhoneFavoriteListComponent } from './phone/favorite/phone-favorite-list.component';
import { PhoneDetailComponent } from './phone/detail/phone-detail.component';
import { PhoneSmartphoneListComponent } from './phone/smartphone/phone-smartphone-list.component';
import { PhoneUsualphoneListComponent } from './phone/usualphone/phone-usualphone-list.component';
import { RegisterUserComponent } from './account/register/register.component';
import { LoginUserComponent } from './account/login/login.component';
import { StoreCartComponent } from './storeCart/store-cart.component';
// ����������� ���������
var appRoutes = [
    { path: '', component: PhoneFavoriteListComponent },
    { path: 'phone/:id', component: PhoneDetailComponent },
    { path: 'allphones', component: PhoneListComponent },
    { path: 'favorite', component: PhoneFavoriteListComponent },
    { path: 'smartphone', component: PhoneSmartphoneListComponent },
    { path: 'usualphone', component: PhoneUsualphoneListComponent },
    { path: 'register', component: RegisterUserComponent },
    { path: 'login', component: LoginUserComponent },
    { path: 'storeCart', component: StoreCartComponent },
    { path: 'allphones/phone/:id', redirectTo: 'phone/:id' },
    { path: 'favorite/phone/:id', redirectTo: 'phone/:id' },
    { path: 'smartphone/phone/:id', redirectTo: 'phone/:id' },
    { path: 'usualphone/phone/:id', redirectTo: 'phone/:id' },
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        NgModule({
            imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
            declarations: [AppComponent, PhoneListComponent, PhoneDetailComponent,
                PhoneFavoriteListComponent, PhoneSmartphoneListComponent,
                PhoneUsualphoneListComponent, RegisterUserComponent, LoginUserComponent,
                StoreCartComponent
            ],
            bootstrap: [AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
export { AppModule };
//# sourceMappingURL=app.module.js.map