import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'atm',
    templateUrl: './atm.component.html'
})
export class AtmComponent {

    public requireAmount = 2;
    public amountAvailable: number;

    public incrementCounter() {
        this.requireAmount++;

    }


    public denominations: Denomination[];
    public denominationsWithDrawn: Denomination[];

    constructor(http: Http) {
        http.get('/api/Atm/GetDenominationValueAsync').subscribe(result => {
            this.denominations = result.json() as Denomination[];

        });
        http.get('/api/Atm/ProcessWithdrawalAsync', this.requireAmount).subscribe(result => {
            this.denominationsWithDrawn = result.json() as Denomination[];

        });
    }

    public withdrawMoney(http: Http) {
        http.get('/api/Atm/ProcessWithdrawalAsync', this.requireAmount).subscribe(result => {
            this.denominationsWithDrawn = result.json() as Denomination[];

        });
    }


}

interface Denomination {
    denominationValue: number;
    quantity: number;
    value: number;
}