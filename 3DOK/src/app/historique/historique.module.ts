import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { HistoriquePage } from './historique.page';
import {MatTableModule} from '@angular/material/table';
import {ExploreContainerComponentModule} from '../explore-container/explore-container.module';
import {RouterModule} from '@angular/router';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ExploreContainerComponentModule,
    RouterModule.forChild([{path: '', component: HistoriquePage}]),
    MatTableModule
  ],
  declarations: [HistoriquePage]
})
export class HistoriquePageModule {}
