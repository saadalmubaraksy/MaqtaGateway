import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(public authService:AuthService,private router:Router,){}

  title = 'Maqta Gateway';
  currYear = new Date().getFullYear();

  logout = () => {
    localStorage.removeItem("jwt");
    this.router.navigate(["login"]);
  }
}
