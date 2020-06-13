import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TabsPage } from './tabs.page';

const routes: Routes = [
  {
    path: 'tabs',
    component: TabsPage,
    children: [
      {
        path: 'accueil',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../accueil/accueil.module').then(m => m.AccueilPageModule)
          }
        ]
      },
      {
        path: 'classement',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../classement/classement.module').then(m => m.ClassementPageModule)
          }
        ]
      },
      {
        path: 'profil',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../profil/profil.module').then(m => m.ProfilPageModule)
          }
        ]
      },
      {
        path: 'accueil',
        children: [
          {
            path: '',
            loadChildren: () =>
                import('../accueil/accueil.module').then(m => m.AccueilPageModule)
          }
        ]
      },
      {
        path: 'historique',
        children: [
          {
            path: '',
            loadChildren: () =>
                import('../historique/historique.module').then(m => m.HistoriquePageModule)
          }
        ]
      },
      {
        path: 'file',
        children: [
          {
            path: '',
            loadChildren: () =>
                import('../file/file.module').then(m => m.FilePageModule)
          }
        ]
      },
      {
        path: 'partie',
        children: [
          {
            path: '',
            loadChildren: () =>
                import('../partie/partie.module').then(m => m.PartiePageModule)
          }
        ]
      },
      {
        path: '',
        redirectTo: '/tabs/accueil',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: '',
    redirectTo: '/tabs/accueil',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TabsPageRoutingModule {}
