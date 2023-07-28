import { Component, OnInit } from '@angular/core';
import { PropertiesService } from 'src/app/core/services/properties.service';
import { Property } from 'src/app/core/types/property.type';

@Component({
  selector: 'app-properties-list',
  templateUrl: './properties-list.component.html',
  styleUrls: ['./properties-list.component.css'],
})
export class PropertiesListComponent implements OnInit {
  properties: Property[] = [];

  constructor(private propertiesService: PropertiesService) {}

  ngOnInit(): void {
    this.propertiesService.all().subscribe({
      next: (properties) => {
        this.properties = properties;
      }
    });
  }
}
