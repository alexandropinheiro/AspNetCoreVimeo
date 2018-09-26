import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

// bootstrap
import { CollapseModule } from 'ng2-bootstrap/collapse';
import { CarouselModule } from 'ng2-bootstrap/carousel';

// Componentes
import { AppComponent } from './app.component';
import { MenuSuperiorComponent } from './shared/menu-superior/menu-superior.component';
import { MainPrincipalComponent } from './shared/main-principal/main-principal.component';
import { FooterComponent } from './shared/footer/footer.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuSuperiorComponent,
    MainPrincipalComponent,
    FooterComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    CollapseModule.forRoot(),
    CarouselModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
