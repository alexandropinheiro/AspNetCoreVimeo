import { Routes } from '@angular/router';

import { ListaEventosComponent } from './eventos/lista-eventos/lista-eventos.component';
import { HomeComponent } from './home/home.component';

export const rootRouterConfig: Routes = [
    {path: '', redirectTo: 'home', pathMatch: 'full'},
    {path: 'home', component: HomeComponent },
    {path: 'proximos-eventos', component: ListaEventosComponent }
];
