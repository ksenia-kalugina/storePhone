import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../data.service';
import { Phone } from '../phone/phone';
import { RouterModule } from '@angular/router';
import { Router } from '@angular/router';
import { StoreCartItem } from './storeCartItem';

@Component({
    templateUrl: './store-cart.component.html',
    providers: [DataService]
})
export class StoreCartComponent implements OnInit {
    isEmptyStoreCart: string;
    list: StoreCartItem[];
    constructor(private dataService: DataService, private router: Router) { }

    ngOnInit() {
        this.dataService.IsAuthorize().subscribe((data: boolean) => {
            if (data == false) {
                this.router.navigateByUrl("/login")
            }
        });

        this.dataService.getStoreCartList().subscribe((data: StoreCartItem[]) => this.list = data);
        if (this.list == null) {
            this.isEmptyStoreCart = "Пусто";
        }
    }

    submit(phoneid: number) {
        this.dataService.deleteItemInStoreCart(phoneid).subscribe(data => window.location.reload());
    }
}



