import { Component,OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../../data.service';
import { User } from '../user';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'my-app',
  providers: [DataService],
    template: `
                <h2>Вход</h2>
                <form #myForm="ngForm" novalidate>
                    <div class="form-group">
                        <label>Логин</label>
                        <input class="form-control" name="name" [(ngModel)]="name" required />
                    </div>
                    <div class="form-group">
                        <label>Пороль</label>
                        <input class="form-control" name="email" ngModel 
                            required email />
                    </div>                    
                    <div class="form-group">
                        <button class="btn nav-link btn-warning d-inline-block" (click)="submit(myForm)">Вход</button>
                        <button class="nav-link btn btn-warning d-inline-block ml-2" routerLink="/register">Регистрация</button>
                    </div>
                    
                </form>`

})
export class LoginUserComponent implements OnInit {

  
  ngOnInit() {
      
  }

  submit(form: NgForm) {
    console.log(form.value.name);
    this.login(form.value.name, form.value.email);
  }

    constructor(private dataService: DataService, private router: Router) { }

  login(email: string, password: string) {

    let user: User = {
      "Email": email,
      "Password": password
    }
    //this.dataService.getString();
      this.dataService.loginUser(user).subscribe(data => this.router.navigateByUrl("/favorite"));
  }


}