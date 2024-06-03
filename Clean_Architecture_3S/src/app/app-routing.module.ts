import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { errorComponent } from './shared/page/error.component';
import { HomeComponent } from './modules/home/page/home.component';

const routes: Routes = [
   {path:"home" ,loadChildren:()=>import('./modules/home/home.module').then(a=>a.HomeModule)},
   {path:"**" ,component:errorComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {}
