import { EnvironmentInjector, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { cityDto } from '../../../Dto/loookup/cityDto/cityDto';
import { environment } from '@env';


let url = environment.baseUrl;

@Injectable({
    providedIn: 'root'
})
export class cityservice {
    private apiUrl = url ; // Replace with your actual API endpoint

  constructor(private http: HttpClient) {}

  getallcitiesbygovernorateid(governorateid: string): Observable<cityDto[]> {
      return this.http.get<cityDto[]>(this.apiUrl + '/city/getallcitiesbygovernorateid?governorateid=' + governorateid);
  }

  getallcities(): Observable<cityDto[]> {
    return this.http.get<cityDto[]>(this.apiUrl + '/city/getallcities');
}

  
}
