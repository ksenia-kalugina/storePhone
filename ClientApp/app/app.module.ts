import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { PhoneListComponent } from './phone/allphones/phone-list.component';
import { PhoneFavoriteListComponent } from './phone/favorite/phone-favorite-list.component';
import { PhoneDetailComponent } from './phone/detail/phone-detail.component';
import { PhoneSmartphoneListComponent } from './phone/smartphone/phone-smartphone-list.component';
import { PhoneUsualphoneListComponent } from './phone/usualphone/phone-usualphone-list.component';
import { RegisterUserComponent } from './account/register/register.component';
import { LoginUserComponent } from './account/login/login.component';
import { StoreCartComponent } from './storeCart/store-cart.component';

// определение маршрутов
const appRoutes: Routes = [
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
    //{ path: '**', redirectTo: '/' }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, PhoneListComponent, PhoneDetailComponent,
        PhoneFavoriteListComponent, PhoneSmartphoneListComponent,
        PhoneUsualphoneListComponent, RegisterUserComponent, LoginUserComponent,
        StoreCartComponent
        ],
    bootstrap: [AppComponent]
})
export class AppModule { }
