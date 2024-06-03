import { EnvironmentInjector, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CreateUserCommand } from '../../Dto/usersdto/Createusercommand';
import { environment } from '@env';

let url = environment.baseUrl;

@Injectable({
    providedIn: 'root'
})
export class registrationservice {
    private apiUrl = url ; // Replace with your actual API endpoint

  constructor(private http: HttpClient) {}

  submitRegistration(formData: CreateUserCommand): Observable<string> {
    return this.http.post<string>(this.apiUrl +'/users/AddUser', formData);
  }
  
}
