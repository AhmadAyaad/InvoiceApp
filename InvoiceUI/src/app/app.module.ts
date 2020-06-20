import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { AppComponent } from './app.component';
import { from } from 'rxjs';
import { InvoiceComponent } from './Components/invoice/invoice.component';

@NgModule({
  declarations: [
    AppComponent,
    InvoiceComponent
  ],
  imports: [
    BrowserModule ,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
