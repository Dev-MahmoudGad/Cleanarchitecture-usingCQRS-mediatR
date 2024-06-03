import { NgModule } from '@angular/core';
import { HomeComponent } from './page/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeRoutingModule } from './home.routing';
import { CommonModule } from '@angular/common';
import { registrationservice } from '@app/core/services/users/registrationservice';
import { governoratservices } from '@app/core/services/lookup/governorat/governoratservices';
import { cityservice } from '@app/core/services/lookup/city/citeservices';


@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers:[
    registrationservice,
    governoratservices,
    cityservice
  ]
})
export class HomeModule { }
