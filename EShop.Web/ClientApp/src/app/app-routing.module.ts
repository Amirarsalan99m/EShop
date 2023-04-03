import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AboutUsComponent } from "./pages/about-us/about-us.component";
import { ContactUsComponent } from "./pages/contact-us/contact-us.component";
import { HomeComponent } from "./pages/home/home.component";


const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'contact-us', component: ContactUsComponent },
  { path: 'about-us', component: AboutUsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})

export class AppRoutingModule {

}
