import { Component, OnInit } from '@angular/core';
import { TestService } from './Services/test.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'InvoiceUI';
  constructor() {}
  ngOnInit(): void {}
}
