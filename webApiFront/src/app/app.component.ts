import { Component } from '@angular/core';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { IFamily } from '../Interfaces/IFamily';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  family!: IFamily;
  error!: string;
  constructor(private http: HttpClient) { }

  getFamilies() {
    this.http.get('https://localhost:7100/api/BrazilianFlora/families')
      .pipe(
        catchError(this.handleError)
      )
      .subscribe((retriveData: any) => {
        this.family = retriveData;
      });
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // Um erro do lado do cliente ocorreu. Exibir mensagem de erro personalizada.
      this.error = `Erro: ${error.error.message}`;
    } else {
      // O servidor retornou um código de erro. Exibir mensagem de erro personalizada.
      this.error = `Erro ${error.status}: ${error.error}`;
    }
    // Retornar um observable com uma mensagem de erro a ser exibida para o usuário.
    return throwError(this.error);
  }
}
