import { Routes } from '@angular/router';
import { HomeComponent } from './modules/features/home/page/home.component';
import { NotFoundComponentComponent } from './modules/features/error/not-found-component/not-found-component.component';

export const routes: Routes = [
    {path:"hh" ,component:HomeComponent},
    { path: '**', component: NotFoundComponentComponent } 
];


