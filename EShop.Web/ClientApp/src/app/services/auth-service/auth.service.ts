import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginUserDTO } from '../../DTOs/account/LoginUserDTO';
import { RegisterUserDTO } from '../../DTOs/account/RegisterUserDTO';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(
    private http: HttpClient
  ) { }

  registerUser(registerData: RegisterUserDTO): Observable<any> {
    return this.http.post<any>("api/account/register", registerData);
  }

  loginUser(loginData: LoginUserDTO): Observable<any> {
    return this.http.post<any>("api/account/login", loginData);
  }
}
