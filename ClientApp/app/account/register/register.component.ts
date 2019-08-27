import { Component,OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../../data.service';
import { User } from '../user';
import { Phone } from '../../phone/phone';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'my-app',
  providers: [DataService],
    template: `
                <h2>Регистрация</h2>
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
                        <button class="btn nav-link btn-warning" (click)="submit(myForm)">Добавить</button>
                    </div>
                </form>`

})
export class RegisterUserComponent implements OnInit {

  str: String[];
  ngOnInit() {
      //this.dataService.getString().subscribe((data: String[]) => this.str = data);
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
      this.dataService.registerUser(user).subscribe(data => this.router.navigateByUrl("/favorite"));
  }


}