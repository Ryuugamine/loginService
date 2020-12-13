import { Component } from "@angular/core";
import { HttpService} from '../services/http.service';
import { User } from '../models/user.model';
import { Response } from '../models/response.model';


@Component({
    selector: 'app-card',
    template: `<div class="form-group">
                    <label>Login</label>
                    <input class="form-control" name="username" [(ngModel)]="user.login" />
                </div>
                <div class="form-group">
                    <label>Password</label>
                    <input class="form-control" name="password" [(ngModel)]="user.password" />
                </div>
                <div class="form-group">
                    <button class="btn btn-default" (click)="submit(user)">Sign in</button>
                </div>
                <div>Получено от сервера:</div>
                <div>{{response?.message}}</div>
                `,
    providers: [HttpService]
})
export class CardComponent {
    user: User = new User;
    response?: Response;
    

    constructor(private httpService: HttpService){}
    submit(user: User){
        this.httpService.signIn(user)
                .subscribe(
                    data => {this.response=data},
                    error => console.log(error)
                );
    }
}