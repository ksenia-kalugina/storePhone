import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Phone } from './phone/phone';
import { User } from './account/user';

@Injectable()
export class DataService {

    private url = "/api/phones";

    constructor(private http: HttpClient) {
    }

    getPhones() {
        return this.http.get(this.url + '/allphones');
    }

    getPhone(id: number) {
        return this.http.get(this.url + '/' + id);
    }

    getFavoritePhones() {
        return this.http.get(this.url + '/favorite');
    }
    getSmartphonePhones() {
        return this.http.get(this.url + '/smartphone');
    }

    getUsualphonePhones() {
        return this.http.get(this.url + '/usualphone');
    }


    registerUser(user: User) {
        console.log(user.Email);
        return this.http.post('/api/account/register', user);        
    }

    loginUser(user: User) {
        console.log(user.Email);
        return this.http.post('/api/account/login', user);
    }

    IsAuthorize() {
        return this.http.get('/api/account/IsAuthorize');
    }

    logoutUser() {    
        console.log("exit");
        return this.http.get('/api/account/logout');
    }

    getStoreCartList() {
        console.log("exit2");
        return this.http.get('/api/storecart/getStoreCartList');
    }

    addItemInStoreCart(phoneId: number) {
        
        return this.http.post('/api/storecart/addItemInStoreCart', phoneId);
    }

    deleteItemInStoreCart(phoneId: number) {

        return this.http.post('/api/storecart/deleteItemInStoreCart', phoneId);
    }

    getString() {
        return this.http.get('/api/account/register');
    }

    //loginUser(user: User) {
    //    return this.http.put(this.url +'/api/account/login', user);
    //}
}
