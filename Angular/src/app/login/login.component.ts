import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { Router } from "@angular/router";
import { environment } from "src/environments/environment";
import { AuthenticatedResponse } from "../AuthenticatedResponse";
import { LoginModel } from "../LoginModel";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  invalidLogin: boolean;
  credentials: LoginModel = {username:'', password:''};
  constructor(private router: Router, private http: HttpClient) { }
  ngOnInit(): void {

  }
  login = ( form: NgForm) => {
    if (form.valid) {
      this.http.post<AuthenticatedResponse>(`${environment.API}/api/auth/login`, this.credentials, {
        headers: new HttpHeaders({ "Content-Type": "application/json"})
      })
      .subscribe({
        next: (response: AuthenticatedResponse) => {
          const token = response.token;
          localStorage.setItem("jwt", token);
          this.invalidLogin = false;
          this.router.navigate(["/"]);
        },
        error: (err: HttpErrorResponse) => this.invalidLogin = true
      })
    }
  }
}
