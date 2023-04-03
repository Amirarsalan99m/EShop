import { AfterViewInit, Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, AfterViewInit {

  constructor() { }

  ngOnInit(): void {
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

}
