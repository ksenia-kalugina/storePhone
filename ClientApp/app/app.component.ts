import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from './data.service';
import { User } from '../app/account/user';
import { Phone } from '../app/phone/phone';
import { NgForm } from '@angular/forms';

@Component({
    selector: 'app',
    providers: [DataService],
    templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

    
    ngOnInit() {
        
    }

    submit() {
        this.logOut();
    }

    constructor(private dataService: DataService) { }

    logOut() {
        console.log("exit");
        this.dataService.logoutUser().toPromise();
    }

}