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
    return this.api.get(this.propertiesPath)
  }

  search() {}

  details() {}

  create() {}

  edit() {}

  delete() {}
}
