import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { SupplierComponent } from './supplier/supplier.component';
import {PlantComponent} from './plant/plant.component';
import { RfqComponent } from './rfq/rfq.component';
import { AuthGuard } from './services/auth.guard';
import { PartreorderdetailsComponent } from './partreorderdetails/partreorderdetails.component';
import { ViewstockComponent } from './viewstock/viewstock.component';
import { UpdateminmaxComponent } from './updateminmax/updateminmax.component';
import { GetrfqComponent } from './getrfq/getrfq.component';
import { GetpotentialvendorComponent } from './getpotentialvendor/getpotentialvendor.component';

const routes: Routes = [{
  path:'',
  redirectTo:'home',
  pathMatch:'full'
},
{path: 'home', component: HomeComponent ,canActivate:[AuthGuard]},
{ path: 'login', component: LoginComponent},
{ path: 'supplier', component: SupplierComponent},
{ path: 'plant', component: PlantComponent,canActivate:[AuthGuard]},
{path: 'rfq', component: RfqComponent,canActivate:[AuthGuard]},
{path: 'partreorderdetails', component: PartreorderdetailsComponent,canActivate:[AuthGuard]},
{path: 'viewstock',component:ViewstockComponent,canActivate:[AuthGuard]},
{path: 'updateminmax',component: UpdateminmaxComponent,canActivate:[AuthGuard]},
{path: 'getrfq',component:GetrfqComponent ,canActivate:[AuthGuard]},
{path: 'getpotentialvendors',component: GetpotentialvendorComponent,canActivate:[AuthGuard]}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
