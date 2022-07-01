import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../login.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  loggedin = false
  constructor(private loginService:LoginService,private router:Router) { }

  ngOnInit(): void {
    this.loggedin= this.loginService.isLoggedIn()
  }

  logout(){
    this.loginService.logout()
    window.location.href="/login"; 
    
  }

}