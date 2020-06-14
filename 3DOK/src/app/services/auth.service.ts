import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

const baseUrl: string = "localhost:44336/";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private token: string;
  public $token: Subject<string> = new Subject<string>();

  constructor() {
    
  }

  public setToken(token: string){
    this.token = token;
    this.$token.next(token);
  }
  public get Token(): string{
    return this.token;
  }

  
}