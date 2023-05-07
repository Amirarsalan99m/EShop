import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { CurrentUserDTO } from '../../DTOs/account/CurrentUserDTO';
import { ILoginUserAccount } from '../../DTOs/account/ILoginUserAccount';
import { LoginUserDTO } from '../../DTOs/account/LoginUserDTO';
import { RegisterUserDTO } from '../../DTOs/account/RegisterUserDTO';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private currentUser: BehaviorSubject<CurrentUserDTO> = new BehaviorSubject<CurrentUserDTO>({ firstName: '', lastName: '', userId: 0 });

  constructor(
    private http: HttpClient
  ) { }

  setCurrentUser(user: CurrentUserDTO): void {
    this.currentUser.next(user);
  }

  getCurrentUser(): Observable<CurrentUserDTO> {
    return this.currentUser;
  }

  registerUser(registerData: RegisterUserDTO): Observable<any> {
    return this.http.post<any>("api/account/register", registerData);
  }

  loginUser(loginData: LoginUserDTO): Observable<ILoginUserAccount> {
    return this.http.post<ILoginUserAccount>("api/account/login", loginData);
  }
}
