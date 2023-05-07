import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SiteHeaderComponent } from './sharedComponents/site-header/site-header.component';
import { SiteFooterComponent } from './sharedComponents/site-footer/site-footer.component';
import { HomeComponent } from './pages/home/home.component';
import { BillboardComponent } from './pages/home/billboard/billboard.component';
import { ClientHolderComponent } from './pages/home/client-holder/client-holder.component';
import { FeaturedBooksComponent } from './pages/home/featured-books/featured-books.component';
import { BestSellingComponent } from './pages/home/best-selling/best-selling.component';
import { PopularBooksComponent } from './pages/home/popular-books/popular-books.component';
import { QuotationComponent } from './pages/home/quotation/quotation.component';
import { SpecialOfferComponent } from './pages/home/special-offer/special-offer.component';
import { SubscribeComponent } from './pages/home/subscribe/subscribe.component';
import { LatestBlogComponent } from './pages/home/latest-blog/latest-blog.component';
import { DownloadAppComponent } from './pages/home/download-app/download-app.component';
import { BillboardService } from './services/billboard/billboard.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { ContactUsComponent } from './pages/contact-us/contact-us.component';
import { AppRoutingModule } from './app-routing.module';
import { Interceptor } from './utilities/Interceptor';
import { CommentAggressionComponent } from './pages/comment-aggression/comment-aggression.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { LoginComponent } from './pages/login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AuthService } from './services/auth-service/auth.service';

@NgModule({
  declarations: [
    AppComponent,
    SiteHeaderComponent,
    SiteFooterComponent,
    HomeComponent,
    BillboardComponent,
    ClientHolderComponent,
    FeaturedBooksComponent,
    BestSellingComponent,
    PopularBooksComponent,
    QuotationComponent,
    SpecialOfferComponent,
    SubscribeComponent,
    LatestBlogComponent,
    DownloadAppComponent,
    AboutUsComponent,
    ContactUsComponent,
    CommentAggressionComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    MatButtonModule,
    MatDialogModule,
    BrowserAnimationsModule,
    ReactiveFormsModule
  ],
  providers: [
    BillboardService,
    AuthService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: Interceptor,
      multi: true
    }],
  bootstrap: [AppComponent]
})
export class AppModule { }
