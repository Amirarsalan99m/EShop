import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Observable } from "rxjs";
import { DomainName } from "./pathTools";

export class Interceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    let myRequest: HttpRequest<any> = req;
    myRequest = req.clone({
      url: DomainName + req.url
      //headers: req.headers.append('test-header','myValue')
    });


    return next.handle(myRequest);
  }

}
