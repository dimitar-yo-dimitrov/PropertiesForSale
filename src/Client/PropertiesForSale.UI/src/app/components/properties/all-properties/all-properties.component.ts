import { Component, OnInit } from '@angular/core';
import { PropertiesService } from 'src/app/core/services/properties.service';
import { IProperty } from 'src/app/core/types/property.type';

@Component({
  selector: 'app-all-properties',
  templateUrl: './all-properties.component.html',
  styleUrls: ['./all-properties.component.css'],
})
export class PropertiesListComponent implements OnInit {
  properties: IProperty[] = [];

  constructor(private propertiesService: PropertiesService) {}

  ngOnInit(): void {
    this.propertiesService.getAllProperties().subscribe({
      next: (properties) => {
        this.properties = properties;
      }
    });
  }
}
