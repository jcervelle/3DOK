import { Injectable } from '@angular/core';
import { User } from '../models/user';
import { HttpService } from './http.service';
import { AuthService } from './auth.service';

enum UtilisateurRoutes{
  get = "get",
  getAll = "getAll",
  post = "post",
  put = "put",
  delete = "delete",
  authenticate = "authenticate"
}

@Injectable({
  providedIn: 'root'
})
export class UtilisateurService {

  constructor(
    private httpService: HttpService,
    private authService: AuthService,
    ) {
    
  }

  public login(User: User): boolean{
    this.httpService.Post(UtilisateurRoutes.authenticate).then(HttpRequest => {
      this.authService.setToken(HttpRequest.data.token);
    }).catch(err => {
      alert(err);
      this.authService.setToken("");
    })
    return this.authService.Token !== "";
  }
  
  public register(User: User): boolean{
    this.httpService.Post(UtilisateurRoutes.post).then(HttpRequest => {
      this.login(User);
    }).catch(err => {
      alert(err);
      this.authService.setToken("");
    })
    return this.authService.Token !== "";
  }

  public logout(){
    this.authService.setToken("");
  }
}