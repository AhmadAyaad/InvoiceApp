import { Injectable } from '@angular/core';
import { storesUrl } from 'src/app/api';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root',
})
export class StoresService {
  constructor(private http: HttpClient) {}

  getStores() {
    return this.http.get(storesUrl);
  }
}
