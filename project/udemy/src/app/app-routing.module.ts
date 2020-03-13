import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home';
import { LoginComponent } from './login';
import { RegisterComponent } from './register';
import { AuthGuard } from './_guards';
import { componentFactoryName } from '@angular/compiler';
import { CoursesComponent } from './courses/courses.component';

const routes: Routes = [
{ path: '', pathMatch:'full', redirectTo:'home' },
{ path: 'login', component: LoginComponent },
{ path: 'register', component: RegisterComponent },
//{ path: '**', redirectTo: '' },
{path:'home',component:HomeComponent},
{path: 'courses', component: CoursesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routing = RouterModule.forRoot(routes);