import { Component } from '@angular/core';

@Component({
  selector: 'app-classement',
  templateUrl: 'classement.page.html',
  styleUrls: ['classement.page.scss']
})
export class ClassementPage {

  classementGeneral = [
    {position: 1, name: 'Tamzin Mcmanus', score: 4900},
    {position: 2, name: 'Philippe Ejtebest', score: 4800},
    {position: 3, name: 'Lillie-Mai Peacock', score: 4600},
    {position: 4, name: 'Pedro Patrick', score: 4500},
    {position: 5, name: 'Haidar David', score: 4200},
    {position: 6, name: 'Isabelle Whitley', score: 3700},
    {position: 7, name: 'Teddy Blen', score: 3600},
    {position: 8, name: 'Azra Morrow', score: 3500},
    {position: 9, name: 'Karolina Howell', score: 3500},
    {position: 10, name: 'Jules Edge', score: 3500},
    {position: 11, name: 'Mylie Dillard', score: 3400},
    {position: 12, name: 'Britney Drew', score: 3100},
    {position: 13, name: 'Bradleigh Bain', score: 2200},
    {position: 14, name: 'Roisin Mcgrath', score: 2100},
    {position: 15, name: 'Farhaan Lott', score: 1700},
    {position: 16, name: 'Patrick Benton', score: 1300},
    {position: 17, name: 'Iqrah Watt', score: 800},
  ];

  classementEntreprise = [
    {position: 1, name: 'Tamzin Mcmanus', score: 4900},
    {position: 2, name: 'Philippe Ejtebest', score: 4800},
    {position: 3, name: 'Teddy Blen', score: 3600},
    {position: 4, name: 'Azra Morrow', score: 3500},
    {position: 5, name: 'Karolina Howell', score: 3500},
    {position: 6, name: 'Farhaan Lott', score: 1700},
    {position: 7, name: 'Patrick Benton', score: 1300},
  ];
  classementAmis = [
    {position: 1, name: 'Philippe Ejtebest', score: 4800},
    {position: 2, name: 'Isabelle Whitley', score: 3700},
    {position: 3, name: 'Teddy Blen', score: 3600},
    {position: 4, name: 'Karolina Howell', score: 3500},
    {position: 5, name: 'Iqrah Watt', score: 800},
  ];
  columnsToDisplay=['position', 'name', 'score'];

  varSelector = 0;

  constructor() {}

  setVar(varS){
    this.varSelector = varS;
  }

  getDataSource(){
    switch(this.varSelector){
      case 0:
        return this.classementGeneral;
      case 1:
        return this.classementEntreprise;
      case 2:
        return this.classementAmis;
    }
  }
}
