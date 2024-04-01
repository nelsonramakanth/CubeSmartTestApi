import { Injectable } from '@angular/core';
import { HttpClient  } from '@angular/common/http';
import { Observable } from 'rxjs';
import { response } from 'express';

@Injectable({
  providedIn: 'root'
})
export class CubeService {

  apiUrl = 'https://localhost:44374/api/cube';

  constructor(private http: HttpClient) { }

  insertText(val : string): Observable<any> {
    let insertUrl = `${this.apiUrl}/insert?data=` + val;
    const requestOptions: Object = {
      responseType: 'text'
    }
    return this.http.post<string>(insertUrl,val,requestOptions);
  }

  updateText(val : string): Observable<any> {
    let updateUrl = `${this.apiUrl}/update?data=` + val;
    const requestOptions: Object = {
      responseType: 'text'
    }
    return this.http.post<string>(updateUrl,val,requestOptions);
  }
}
