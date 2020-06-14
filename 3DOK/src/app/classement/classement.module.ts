import { IonicModule } from '@ionic/angular';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ClassementPage } from './classement.page';
import { ExploreContainerComponentModule } from '../explore-container/explore-container.module';
import {MatListModule} from '@angular/material/list';
import {MatTableModule} from '@angular/material/table';
import {MatMenuModule} from "@angular/material/menu";
import {MatButtonModule} from "@angular/material/button";
import {MatIconModule} from "@angular/material/icon";
import {FontAwesomeModule} from "@fortawesome/angular-fontawesome";

@NgModule({
    imports: [
        IonicModule,
        CommonModule,
        FormsModule,
        ExploreContainerComponentModule,
        RouterModule.forChild([{path: '', component: ClassementPage}]),
        MatListModule,
        MatTableModule,
        MatMenuModule,
        MatButtonModule,
        MatIconModule,
        FontAwesomeModule
    ],
  declarations: [ClassementPage]
})
export class ClassementPageModule {}
