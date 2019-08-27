import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { RouterModule } from '@angular/router';
import { Phone } from '../phone';
import { Router } from '@angular/router';

@Component({
    templateUrl: '../phone-list.component.html',
    providers: [DataService]
})
export class PhoneListComponent implements OnInit {
    nameCategory = "Все телефоны";
    phones: Phone[];
    constructor(private dataService: DataService, private router: Router) { }

    ngOnInit() {
        this.dataService.IsAuthorize().subscribe((data: boolean) => {
            if (data == false) {
                this.router.navigateByUrl("/login")
            }
        });
        this.dataService.getPhones().subscribe((data: Phone[]) => this.phones = data);
    }

    submit(phoneid: number) {
        this.dataService.addItemInStoreCart(phoneid).subscribe(data => this.router.navigateByUrl("/storeCart"));
    }
}
