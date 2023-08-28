import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';

import { ApiService } from './api.service';
import { IProperty } from 'src/app/features/types/create-property-request.type';

@Injectable({
  providedIn: 'root',
})
export class PropertiesService {
  private propertiesPath = '/properties';

  constructor(private api: ApiService) {}

  getAllProperties(): Observable<Array<IProperty>> {
    return this.api.get(this.propertiesPath);
  }

  searchProperty(query: string = ''): Observable<Array<IProperty>> {
    return this.api.get(this.propertiesPath + query);
  }

  detailsProperty(id: string): Observable<Array<IProperty>> {
    return this.api.get(this.propertiesPath + id);
  }

  createProperty(data: any) {
    return this.api.post(this.propertiesPath, data);
  }

  editProperty(id: string, data: any) {
    return this.api.put(this.propertiesPath + id, data);
  }

  deleteProperty(id: string) {
    return this.api.get(this.propertiesPath + id);
  }
}