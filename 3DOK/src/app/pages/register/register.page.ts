import { Component } from '@angular/core';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-register',
  templateUrl: 'register.page.html',
  styleUrls: ['register.page.scss']
})
export class RegisterPage {

  public user: User = new User();

  constructor() {}


  public submit(): void{
    console.log(this.user)
  }
}
