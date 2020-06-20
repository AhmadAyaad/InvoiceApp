import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { unitsUrl } from 'src/app/api';
@Injectable({
  providedIn: 'root'
})
export class UnitsService {

  constructor(private http: HttpClient) { }

  getUnits()
  {
    return this.http.get(unitsUrl);
  }
  
}
