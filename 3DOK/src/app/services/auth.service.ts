import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

const baseUrl: string = "localhost:44336/";

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  private token: string;
  public $token: Observable<string> = new Observable<string>()

  constructor() {
    
  }

  // public setToken(token: string){
  //   this.token = token;
  //   this.$token.subscribe()
  //   this.$token.
  // }
}