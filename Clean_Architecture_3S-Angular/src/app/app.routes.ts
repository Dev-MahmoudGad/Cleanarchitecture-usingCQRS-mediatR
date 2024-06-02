import { Routes } from '@angular/router';
import { HomeComponent } from './features/home/page/home.component';
import { NotFoundComponentComponent } from './features/error/not-found-component/not-found-component.component';
import { AppComponent } from './app.component';

export const routes: Routes = [
    // {path:"" ,component:AppComponent},
    {path:"" ,component:HomeComponent},
    {path:"**" ,component:NotFoundComponentComponent}

];
