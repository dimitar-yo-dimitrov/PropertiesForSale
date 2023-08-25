import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './core/core.module';
import { ComponentModule } from './core/components/component.module';
import { AllPropertyModule } from './features/properties/property.module';
import { FormsModule } from '@angular/forms';

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
    FormsModule
  ],
})
export class AppModule {}
