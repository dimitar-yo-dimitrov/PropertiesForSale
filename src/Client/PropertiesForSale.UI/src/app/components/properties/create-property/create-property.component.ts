import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { PropertiesService } from 'src/app/core/services/properties.service';

import { Subscription } from 'rxjs';

@Component({
  selector: 'app-create',
  templateUrl: './create-property.component.html',
  styleUrls: ['./create-property.component.css'],
})
export class CreateComponent implements OnInit {
  propertyForm!: FormGroup;
  propertySubscription!: Subscription;

  constructor(
    private router: Router,
    private formBuilder: FormBuilder,
    private propertiesService: PropertiesService
  ) {}

  ngOnInit(): void {
    this.propertyForm = this.formBuilder.group({
      title: ['', Validators.required],
      price: [0, Validators.required],
      address: ['', Validators.required],
      description: ['', Validators.required],
      imageUrl: ['', Validators.required],
      squareMeters: [0, Validators.required],
    });
  }

  createProperty(): void {
    const propertyData = this.propertyForm.value;

    this.propertySubscription = this.propertiesService
      .createProperty(propertyData)
      .subscribe({
        next: (id) => {
          this.router.navigate(['/property/' + id]);
        },
        error: (error) => {
          console.error('Error creating property:', error);
        },
      });
  }

  ngOnDestroy(): void {
    if (this.propertySubscription) {
      this.propertySubscription.unsubscribe();
    }
  }
}
