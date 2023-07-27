import { Component, OnInit } from '@angular/core';
import { Property } from 'src/app/core/types/property.type';

@Component({
  selector: 'app-properties-list',
  templateUrl: './properties-list.component.html',
  styleUrls: ['./properties-list.component.css'],
})
export class PropertiesListComponent implements OnInit {
  properties: Property[] = [];

  constructor() {}

  ngOnInit(): void {}
}
