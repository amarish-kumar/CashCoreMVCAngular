import { Component } from '@angular/core';
import { Http, Response, Headers, RequestOptions, URLSearchParams } from '@angular/http';

@Component({
    selector: 'atm',
    templateUrl: './atm.component.html'
})
export class AtmComponent {

    public requireAmount = 2;
    public amountAvailable: number;
    public startWithDenominationValue: number = null

    private http: Http;

    public incrementCounter() {
        this.requireAmount++;

    }

    public withdrawMoney() {
        this.requireAmount += 3;

        let params: URLSearchParams = new URLSearchParams();
        params.set('requireAmount', this.requireAmount.toString());

        this.http.get('/api/Atm/ProcessWithdrawalAsync', { search : params }).subscribe(result => {
            this.denominationsWithDrawn = result.json() as Denomination[];

        });

        this.http.get('/api/Atm/GetDenominationValueAsync').subscribe(result => {
            this.denominations = result.json() as Denomination[];

        });
    }


    public denominations: Denomination[];
    public denominationsWithDrawn: Denomination[];

    constructor(http: Http) {
        this.http = http;

        http.get('/api/Atm/GetDenominationValueAsync').subscribe(result => {
            this.denominations = result.json() as Denomination[];

        });
        //http.get('/api/Atm/ProcessWithdrawalAsync', this.requireAmount).subscribe(result => {
        //    this.denominationsWithDrawn = result.json() as Denomination[];

        //});
    }

    public callWithdrawMoney(http: Http) {
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