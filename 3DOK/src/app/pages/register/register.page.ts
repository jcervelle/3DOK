import { Component } from '@angular/core';
import { User } from 'src/app/models/user';
import { UtilisateurService } from 'src/app/services/utilisateur.service';

@Component({
  selector: 'app-register',
  templateUrl: 'register.page.html',
  styleUrls: ['register.page.scss']
})
export class RegisterPage {

  public user: User = new User();

  constructor(
  ) {}


  public submit(): void{
    
  }
}
