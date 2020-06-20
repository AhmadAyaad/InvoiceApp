import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { productsUrl } from 'src/app/api';

@Injectable({
  providedIn: 'root',
})
export class ProductsService {
  constructor(private http: HttpClient) {}

  getProducts() {
    return this.http.get(productsUrl);
  }
}
