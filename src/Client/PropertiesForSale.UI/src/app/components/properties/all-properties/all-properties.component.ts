import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { PropertiesService } from 'src/app/core/services/properties.service';
import { IProperty } from 'src/app/core/types/property.type';

@Component({
  selector: 'app-all-properties',
  templateUrl: './all-properties.component.html',
  styleUrls: ['./all-properties.component.css'],
})
export class AllPropertiesComponent implements OnInit {
  properties: IProperty[] = [];
  propertySubscription!: Subscription;

  constructor(private propertiesService: PropertiesService) {}

  ngOnInit(): void {
    this.propertySubscription = this.propertiesService
      .getAllProperties()
      .subscribe({
        next: (properties) => {
          this.properties = properties;
        },
        error: (error) => {
          console.error('Error fetching properties:', error);
        },
      });
  }
  
  ngOnDestroy(): void {
    if (this.propertySubscription) {
      this.propertySubscription.unsubscribe();
    }
  }
}
