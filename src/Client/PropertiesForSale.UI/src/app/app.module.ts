import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';

import { AppRoutingModule } from './app-routing.module';
import { ComponentModule } from './core/components/component.module';
import { AllPropertyModule } from './features/properties/property.module';

import { CoreModule } from './core/core.module';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [AppComponent],
  providers: [],
  bootstrap: [AppComponent],
  imports: [
    BrowserModule,
    CoreModule,
    AllPropertyModule,
    AppRoutingModule,
    ComponentModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
})
export class AppModule {}
