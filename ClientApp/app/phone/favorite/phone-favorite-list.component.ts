import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { RouterModule } from '@angular/router';
import { Phone } from '../phone';
import { Router } from '@angular/router';
import { User } from '../../account/user';

@Component({
    templateUrl: '../phone-list.component.html',
    providers: [DataService]
})
export class PhoneFavoriteListComponent implements OnInit {
    nameCategory = "Популярные телефоны";
    phones: Phone[];
    constructor(private dataService: DataService, private router: Router) { }

    ngOnInit() {
        this.dataService.IsAuthorize().subscribe((data: boolean) => {
            if (data == false) {
                this.router.navigateByUrl("/login")
            }});
       
        this.dataService.getFavoritePhones().subscribe((data: Phone[]) => this.phones = data);
    }

    submit(phoneid: number) {
        this.dataService.addItemInStoreCart(phoneid).subscribe(data => this.router.navigateByUrl("/storeCart"));
    }

    

    
}
