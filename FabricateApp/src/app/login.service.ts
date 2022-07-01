import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  

  constructor(private http:HttpClient) { }

  //calling the server to generate token
  generateToken(credentials:any)
  {
    //token generate
    return this.http.post('https://localhost:44302/api/Auth',credentials); //https://localhost:44314/getToken
  }

  //for login user
  loginUser(token:any)
  {
    localStorage.setItem("token",token)
    return true;
  }

  //to check login or not
  isLoggedIn()
  {
    let token = localStorage.getItem("token");
    if(token==undefined || token=='' || token==null)
    {
      return false; //Change to true
    }
    else 
    {
      return true;
    }
  }

  //for logout
  logout()
  {
    localStorage.removeItem('token');
    return true;
  }

  //for getting the token
  getToken()
  {
    return localStorage.getItem("token");
}
}
