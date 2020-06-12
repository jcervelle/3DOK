import { Injectable } from '@angular/core';
import { HTTP } from '@ionic-native/http/ngx';

const baseUrl: string = "localhost:??/";

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  

  constructor(private http: HTTP) {
    
  }

  public Get(route: string){

  }
}