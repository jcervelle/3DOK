import { Injectable } from '@angular/core';
import { HTTP, HTTPResponse } from '@ionic-native/http/ngx';
import { Observable } from 'rxjs';

const baseUrl: string = "localhost:44336/";

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  

  constructor(private http: HTTP) {
    
  }

  public Get(route: string, parameters: object = {}): Promise<HTTPResponse>{
    return this.http.get(route, parameters, {})
  }
  public Post(route: string, parameters: object = {}): Promise<HTTPResponse>{
    return this.http.post(route, parameters, {})
  }
  public Put(route: string, parameters: object = {}): Promise<HTTPResponse>{
    return this.http.put(route, parameters, {})
  }
  public Delete(route: string, parameters: object = {}): Promise<HTTPResponse>{
    return this.http.delete(route, parameters, {})
  }
}