import { IonicModule } from '@ionic/angular';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { FilePage } from './file.page';
import { ExploreContainerComponentModule } from '../explore-container/explore-container.module';
import {MatButtonModule} from '@angular/material/button'; 
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner'; 


@NgModule({
  imports: [
    IonicModule,
    MatButtonModule,
    MatProgressSpinnerModule,
    CommonModule,
    FormsModule,
    ExploreContainerComponentModule,
    RouterModule.forChild([{ path: '', component: FilePage }])
  ],
  declarations: [FilePage]
})
export class FilePageModule {}