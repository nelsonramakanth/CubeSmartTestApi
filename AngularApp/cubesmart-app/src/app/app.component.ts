import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CubeService } from './cube.service';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'cubesmart-app';

  constructor(private apiService: CubeService) {
  }

  ngOnInit() {           
  }

  upsertClick(textUpsert : string)
  {
    this.apiService.updateText(textUpsert).subscribe((data: any[]) => {
      alert(data)
    }); 
  }

}
