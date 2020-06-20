import { Component, OnInit } from '@angular/core';
import { UnitsService } from 'src/app/Services/units.service';
import { FormBuilder } from '@angular/forms';
import { StoresService } from 'src/app/Services/stores.service';
import { ProductsService } from 'src/app/Services/products.service';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.css'],
})
export class InvoiceComponent implements OnInit {
  units: any = [];
  stores: any = [];
  products: any = [];
  selectedUnit: Number = 1;
  selectedStore: Number = 1;
  selectedProduct: Number = 1;
  date;
  invoiceNumber;
  price;
  quantity;
  total;
  discount;
  net;
  tableData: any = [];
  product;
  constructor(
    private unitService: UnitsService,
    private storeService: StoresService,
    private productService: ProductsService
  ) {}

  ngOnInit(): void {
    this.getUnits();
    this.getStores();
    this.getProducts();
  }

  getStores() {
    this.storeService.getStores().subscribe(
      (res) => {
        console.log(res);
        this.stores = res;
      },
      (err) => {
        console.log(err);
      }
    );
  }
  getUnits() {
    this.unitService.getUnits().subscribe(
      (res) => {
        console.log(res);
        this.units = res;
      },
      (err) => {
        console.log(err);
      }
    );
  }

  getProducts() {
    this.productService.getProducts().subscribe(
      (res) => {
        console.log(res);
        this.products = res;
      },
      (err) => {
        console.log(err);
      }
    );
  }
  changeUnit(data) {
    console.log(data);
    this.selectedUnit = data;
  }
  changeStore(data) {
    this.selectedStore = data;
  }
  changeProduct(data) {
    this.selectedProduct = data;
  }
  addToTable() {
    let invocieObj = {
      product: this.selectedProduct,
      unit: this.selectedUnit,
      price: this.price,
      quantity: this.quantity,
      total: this.total,
      discount: this.discount,
      net: this.net,
    };
    this.tableData.push(invocieObj);
    this.clearAll();

    console.log(this.tableData);
  }

  clearAll() {
     this.net = '';
    this.quantity = '';
    this.total = '';
    this.discount = '';
    this.price = '';
  }
}
