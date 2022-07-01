import { APP_BOOTSTRAP_LISTENER, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { LoginComponent } from './login/login.component';
import { SupplierComponent } from './supplier/supplier.component';
import { PlantComponent } from './plant/plant.component';
import { RfqComponent } from './rfq/rfq.component';
import { HomeComponent } from './home/home.component';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// import { MatToolbarModule} from '@angular/material/toolbar';
// import { MatFormFieldControl, MatFormFieldModule} from '@angular/material/form-field';
// import { MatInputModule} from '@angular/material/input';
// import { MatButtonModule} from '@angular/material/button';
import {HttpClientModule} from '@angular/common/http';
import { ViewstockComponent } from './viewstock/viewstock.component';
import { UpdateminmaxComponent } from './updateminmax/updateminmax.component';
import { PartreorderdetailsComponent } from './partreorderdetails/partreorderdetails.component';
import { GetrfqComponent } from './getrfq/getrfq.component';
import { GetpotentialvendorComponent } from './getpotentialvendor/getpotentialvendor.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    LoginComponent,
    SupplierComponent,
    PlantComponent,
    RfqComponent,
    HomeComponent,
    ViewstockComponent,
    UpdateminmaxComponent,
    PartreorderdetailsComponent,
    GetrfqComponent,
    GetpotentialvendorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    // MatFormFieldModule,
    // MatToolbarModule,
    // MatInputModule,
    // MatButtonModule,
    HttpClientModule

    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
