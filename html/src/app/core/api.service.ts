import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class ApiService {
    private url:string = 'https://localhost:44326/';

    constructor(private http: HttpClient) { }

    private getHeaders():any {

    }

    Get(url:string) {
        return this
            .http
            .get(`${this.url}/${url}`);
    }
}