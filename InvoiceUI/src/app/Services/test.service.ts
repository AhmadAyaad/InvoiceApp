import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class TestService {
  constructor(private http: HttpClient) {}

  getbla() {
    return this.http.get('http://localhost:59443/api/products');
  }
}
