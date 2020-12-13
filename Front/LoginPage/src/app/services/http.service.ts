import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {User} from '../models/user.model';
import { Observable } from 'rxjs';

@Injectable()
export class HttpService{
   
    constructor(private http: HttpClient){ }
    
    signIn(user: User) : Observable<Response>{
        return this.http.post<Response>('http://localhost:80/Service.svc/login', user); 
    }
}