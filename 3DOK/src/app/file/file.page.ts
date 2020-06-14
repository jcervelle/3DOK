import {AfterContentChecked, Component} from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-file',
  templateUrl: 'file.page.html',
  styleUrls: ['file.page.scss']
})
export class FilePage implements AfterContentChecked{

  constructor(
      private router: Router
  ) {}

  ngAfterContentChecked(): void {
    setTimeout(() => {
      this.router.navigate(['./tabs/partie']);
    }, 5000);
  }
}
