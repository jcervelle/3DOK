import { Injectable } from '@angular/core';
import { User } from '../models/user';
import { HttpService } from './http.service';
import { truncateSync } from 'fs';

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
    ) {
    
  }

  // public login(User: User): boolean{
  //   this.httpService.Post(UtilisateurRoutes.authenticate).then(token => {

  //   }).catch(err => {
  //     alert(err);
  //   })
  // }
}