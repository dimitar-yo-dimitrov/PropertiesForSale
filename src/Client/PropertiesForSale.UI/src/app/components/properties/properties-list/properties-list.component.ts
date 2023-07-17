import { Component, OnInit } from '@angular/core';
import { Property } from 'src/app/core/models/property.model';

@Component({
  selector: 'app-properties-list',
  templateUrl: './properties-list.component.html',
  styleUrls: ['./properties-list.component.css'],
})
export class PropertiesListComponent implements OnInit {
  properties: Property[] = [
    {
      id: '57c28e6b-fb9c-4f37-9f35-fa51d335bfc6',
      title: 'Excellent apartment meters from the beach',
      price: 80000,
      description:
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
      squareMeters: 88,
      imageUrl:
        'https://login1.estateplus.net/account/danapro15_1033/big/SPGTY-20210512003752.jpg',
    },
    {
      id: '72ac184c-9787-45ff-8417-a6510b737214',
      title: 'House for you and your family',
      price: 130000,
      description:
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
      squareMeters: 130,
      imageUrl:
        'https://login1.estateplus.net/account/danapro15_1033/big/SPGTY-20210512003752.jpg',
    },
  ];

  // constructor() {}

  ngOnInit(): void {
    
  }
}
