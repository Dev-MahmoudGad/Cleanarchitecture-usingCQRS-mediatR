import { EnvironmentInjector, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { governoratDto } from '../../../Dto/loookup/governoratDto/governoratDto';
import { environment } from '@env';


let url = environment.baseUrl;

@Injectable({
    providedIn: 'root'
})
export class governoratservices {
    private apiUrl = url ; // Replace with your actual API endpoint

  constructor(private http: HttpClient) {}

  getallgovernorates(): Observable<governoratDto[]> {
    return this.http.get<governoratDto[]>(this.apiUrl + '/Governorate/getallgovernorates');
}
  
}
