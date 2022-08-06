import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { MyFundiService, IUserStatus, IUserDetail } from '../services/myFundiService';


@Injectable()
export class AuthFundiGuard implements CanActivate {

  roles: string[];

  // Inject Router so we can hand off the user to the Login Page 
  constructor(private router: Router, private myFundiService: MyFundiService) {
  }

  canActivate(): boolean {

    let userDetails: IUserDetail = JSON.parse(localStorage.getItem("userDetails"));

    let obsRes: any = this.myFundiService.GetUserRolesByUsername(userDetails.username);

    return obsRes.subscribe((qos: string[]): boolean => {
      this.roles = qos;
      console.log(qos);
      return qos.indexOf("Fundi") > -1;
    });
  }
}
