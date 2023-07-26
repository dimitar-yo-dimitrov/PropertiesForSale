import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';

import { ApiService } from './api.service';
import { Property } from '../types/property.type';

@Injectable({
  providedIn: 'root',
})
export class PropertiesService {
  private propertiesPath = 'properties/';

  constructor(private api: ApiService) {}

  all(): Observable<Array<Property>> {
    return this.api.get(this.propertiesPath);
  }

  search(query: string = ''): Observable<Array<Property>> {
    return this.api.get(this.propertiesPath + query);
  }

  details(id: number): Observable<Array<Property>> {
    return this.api.get(this.propertiesPath + id);
  }

  create() {}

  edit() {}

  delete() {}
}
