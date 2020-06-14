import { IonicModule } from '@ionic/angular';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { AccueilPage } from './accueil.page';
import { ExploreContainerComponentModule } from '../explore-container/explore-container.module';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';


@NgModule({
  imports: [
    IonicModule,
    MatButtonModule,
    CommonModule,
    FormsModule,
    ExploreContainerComponentModule,
    RouterModule.forChild([{path: '', component: AccueilPage}]),
    MatIconModule
  ],
  declarations: [AccueilPage]
})
export class AccueilPageModule {}


