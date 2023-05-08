import { Component, OnInit } from '@angular/core';
import { MatLegacyDialog as MatDialog } from '@angular/material/legacy-dialog';
import { CurrentUserDTO } from '../../DTOs/account/CurrentUserDTO';
import { LoginComponent } from '../../pages/login/login.component';
import { AuthService } from '../../services/auth-service/auth.service';

@Component({
  selector: 'site-header',
  templateUrl: './site-header.component.html',
  styleUrls: ['./site-header.component.scss']
})
export class SiteHeaderComponent implements OnInit {

  public user: CurrentUserDTO = { firstName: '', lastName: '', userId: 0 };

  constructor(private authService: AuthService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.authService.getCurrentUser().subscribe(user => {
      this.user = user;
    });
  }

  openDialog() {
    this.dialog.open(LoginComponent, {
      panelClass: 'custom-dialog-container',
      data: {
        message: 'Hello, world!'
      }
    });
  }

}
