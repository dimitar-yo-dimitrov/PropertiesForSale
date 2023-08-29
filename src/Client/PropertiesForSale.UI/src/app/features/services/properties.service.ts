import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpParams } from '@angular/common/http';

import { ApiService } from './api.service';
import { IProperty } from 'src/app/features/types/create-property-request.type';

@Injectable({
  providedIn: 'root',
})
export class PropertiesService {
  private propertiesPath = '/properties';

  constructor(private api: ApiService) {}

  getAllProperties(): Observable<IProperty[]> {
    return this.api.get(this.propertiesPath);
  }

  searchProperties(query: string): Observable<IProperty[]> {
    const params = new HttpParams().set('query', query); // Create HttpParams instance
    return this.api.get(this.propertiesPath, params);
  }

  getPropertyDetails(id: string): Observable<IProperty> {
    return this.api.get(`${this.propertiesPath}/${id}`);
  }

  createProperty(data: any): Observable<any> {
    return this.api.post(this.propertiesPath, data);
  }

  updateProperty(id: string, data: any): Observable<any> {
    return this.api.put(`${this.propertiesPath}/${id}`, data);
  }

  deleteProperty(id: string): Observable<any> {
    return this.api.delete(`${this.propertiesPath}/${id}`);
  }
}
