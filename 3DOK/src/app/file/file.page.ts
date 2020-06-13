import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-file',
  templateUrl: 'file.page.html',
  styleUrls: ['file.page.scss']
})
export class FilePage implements OnInit{

  constructor(
      private router: Router
  ) {}

  ngOnInit(): void {
    setTimeout(() => {
      this.router.navigate(['./tabs/partie']);
    }, 5000);
  }
}
