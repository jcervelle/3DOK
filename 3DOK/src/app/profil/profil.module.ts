import { IonicModule } from '@ionic/angular';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AvatarModule } from 'ngx-avatar';
import { ProfilPage } from './profil.page';
import { ExploreContainerComponentModule } from '../explore-container/explore-container.module';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';


@NgModule({
  imports: [
    IonicModule,
    MatButtonModule,
    CommonModule,
    FormsModule,
    HttpClientModule,
    AvatarModule,
    ExploreContainerComponentModule,
    RouterModule.forChild([{ path: '', component: ProfilPage }])
  ],
  declarations: [ProfilPage]
})
export class ProfilPageModule {}
