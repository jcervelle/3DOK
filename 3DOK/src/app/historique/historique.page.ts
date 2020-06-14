import { Component } from '@angular/core';

@Component({
  selector: 'app-historique',
  templateUrl: './historique.page.html',
  styleUrls: ['./historique.page.scss'],
})
export class HistoriquePage   {

  constructor() { }

  matchs = [
    {date: '12/06/2020', score: '8 - 10', j1: 'Edge', j2: 'Morrow'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Tamzin', j2: 'Ejtebest'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Dillard', j2: 'Haidar'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Jules', j2: 'Azra'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Howell', j2: 'Morrow'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Blen', j2: 'Dillard'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Drew', j2: 'Howell'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Lott', j2: 'Benton'},
    {date: '12/06/2020', score: '2 - 10', j1: 'Watt', j2: 'Dillard'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Tamzin', j2: 'Peacock'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Patrick', j2: 'Ejtebest'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Patrick', j2: 'Mcmanus'},
    {date: '12/06/2020', score: '8 - 10', j1: 'Zhitley', j2: 'Mcgrath'},
  ];
  columnsToDisplay=['date', 'score', 'j1', 'j2' ];

}
