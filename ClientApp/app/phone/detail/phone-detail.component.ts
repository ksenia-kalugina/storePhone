import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../../data.service';
import { Phone } from '../phone';
import { RouterModule } from '@angular/router';
import { Router } from '@angular/router';

@Component({
    templateUrl: './phone-detail.component.html',
    providers: [DataService]
})
export class PhoneDetailComponent implements OnInit {

    id: number;
    phone: Phone;
    loaded: boolean = false;

    constructor(private dataService: DataService, activeRoute: ActivatedRoute, private router: Router) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        this.dataService.IsAuthorize().subscribe((data: boolean) => {
            if (data == false) {
                this.router.navigateByUrl("/login")
            }
        });
        if (this.id)
            this.dataService.getPhone(this.id)
                .subscribe((data: Phone) => { this.phone = data; this.loaded = true; });
    }

    submit() {
        this.dataService.addItemInStoreCart(this.phone.id).subscribe(data => this.router.navigateByUrl("/storeCart"));
    }
}