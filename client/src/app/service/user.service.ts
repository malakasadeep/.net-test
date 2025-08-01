import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

export interface User {
  id: number;
  firstName: string;
  lastName: string;
  address: string;
  mobile: string;
  email: string;
  department: string;
  designation: string;
  updatedBy: string;
  updated: string;
}

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private apiUrl = 'https://localhost:5044/api/users';

  constructor(private http: HttpClient) {}

  getUsers(
    page: number = 1,
    pageSize: number = 10,
    searchTerm: string = ''
  ): Observable<any> {
    // Convert to zero-based index for backend
    const adjustedPage = page - 1;

    let params = new HttpParams()
      .set('pageNumber', adjustedPage.toString())
      .set('pageSize', pageSize.toString());

    if (searchTerm) {
      params = params.append('searchTerm', searchTerm);
    }

    return this.http.get(this.apiUrl, { params }).pipe(
      map((response: any) => ({
        items: response || [],
        total: response.length || 0,
        currentPage: page,
        pageSize: pageSize,
        totalPages: Math.ceil((response.length || 0) / pageSize),
      }))
    );
  }
}
