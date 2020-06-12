import { Component } from '@angular/core';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-login',
  templateUrl: 'login.page.html',
  styleUrls: ['login.page.scss']
})
export class LoginPage {

  public user: User = new User();

  constructor() {}


  public submit(): void{
    console.log(this.user)
  }
}
