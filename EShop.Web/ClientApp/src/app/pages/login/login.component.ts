import { AfterViewInit, Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Console, log } from 'console';
import { LoginUserDTO } from '../../DTOs/account/LoginUserDTO';
import { RegisterUserDTO } from '../../DTOs/account/RegisterUserDTO';
import { AuthService } from '../../services/auth-service/auth.service';
import Swal from 'sweetalert2';
import { MatDialog } from '@angular/material/dialog';
import { CurrentUserDTO } from '../../DTOs/account/CurrentUserDTO';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit, AfterViewInit {

  public registerForm!: FormGroup;
  public loginForm!: FormGroup;

  constructor(
    private modalService: MatDialog,
    private authService: AuthService) { }

  ngOnInit(): void {
    this.registerForm = new FormGroup({
      email: new FormControl(null, [Validators.required, Validators.email]),
      firstName: new FormControl(null, [Validators.required]),
      lastName: new FormControl(null, [Validators.required]),
      password: new FormControl(null, [Validators.required]),
      passwordConfirm: new FormControl(null, [Validators.required]),
      address: new FormControl(null, [Validators.required])
    })

    this.loginForm = new FormGroup({
      email: new FormControl(null, [Validators.required, Validators.email]),
      password: new FormControl(null, [Validators.required])
    })
  }

  ngAfterViewInit() {
    if (document.querySelector('.mat-dialog-container')) {

      const signUpButton = document.getElementById('signUp');
      const signInButton = document.getElementById('signIn');
      const container = document.getElementById('container');

      signUpButton!!.addEventListener('click', () => {
        container!!.classList.add("right-panel-active");
      });

      signInButton!!.addEventListener('click', () => {
        container!!.classList.remove("right-panel-active");
      });
    }
  }

  submitRegister() {
    if (this.registerForm.valid) {
      const registerData = new RegisterUserDTO(
        this.registerForm.controls.email.value,
        this.registerForm.controls.firstName.value,
        this.registerForm.controls.lastName.value,
        this.registerForm.controls.password.value,
        this.registerForm.controls.passwordConfirm.value,
        this.registerForm.controls.address.value
      );

      console.log(registerData);

      this.authService.registerUser(registerData).subscribe(res => {
        if (res.status == 'success') {
          const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true,
            didOpen: (toast) => {
              toast.addEventListener('mouseenter', Swal.stopTimer)
              toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
          })
          Toast.fire({
            icon: 'success',
            title: 'اکانت شما با موفقیت ساخته شد'
          })
          this.closeModal();
        }
        else if (res.status == 'emailExists') {
          const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true,
            didOpen: (toast) => {
              toast.addEventListener('mouseenter', Swal.stopTimer)
              toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
          })
          Toast.fire({
            icon: 'error',
            title: 'ایمیل وارد شده قبلا استفاده شده'
          })
        }
      })
    }
  }

  submitLogin() {
    if (this.loginForm.valid) {
      const loginData = new LoginUserDTO(
        this.loginForm.controls.email.value,
        this.loginForm.controls.password.value
      );

      this.authService.loginUser(loginData).subscribe(res => {
        if (res.status == 'success') {
          const currentUser = new CurrentUserDTO(
            res.userId,
            res.userFirstName,
            res.userLastName
          );
          this.authService.setCurrentUser(currentUser);
          const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true,
            didOpen: (toast) => {
              toast.addEventListener('mouseenter', Swal.stopTimer)
              toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
          })
          Toast.fire({
            icon: 'success',
            title: 'با موفقیت وارد شدید'
          })
          this.closeModal();
        }
        else if (res.status == 'incorrectUsernameOrPassword') {
          const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true,
            didOpen: (toast) => {
              toast.addEventListener('mouseenter', Swal.stopTimer)
              toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
          })
          Toast.fire({
            icon: 'error',
            title: 'نام کاربری یا رمز عبور اشتباه است'
          })
        }
        else if (res.status == 'notActivated') {
          const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true,
            didOpen: (toast) => {
              toast.addEventListener('mouseenter', Swal.stopTimer)
              toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
          })
          Toast.fire({
            icon: 'warning',
            title: 'این نام کاربری فعال نیست'
          })
        }
        else if (res.status == 'somethingWentWrong') {
          const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true,
            didOpen: (toast) => {
              toast.addEventListener('mouseenter', Swal.stopTimer)
              toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
          })
          Toast.fire({
            icon: 'warning',
            title: 'مشکلی پیش آمده'
          })
        }
      });
    }
  }
  closeModal() {// Make sure to check if the property is defined before using it
    this.modalService.closeAll();
  }
}
