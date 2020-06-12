import { Component } from '@angular/core';
import { Plugins } from '@capacitor/core';
import { fas } from '@fortawesome/free-solid-svg-icons'
import { far } from '@fortawesome/free-regular-svg-icons'
import { fab } from '@fortawesome/free-brands-svg-icons'
import { FaIconLibrary } from '@fortawesome/angular-fontawesome';
import { MenuController } from '@ionic/angular';
const { SplashScreen } = Plugins;

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss']
})
export class AppComponent {
  constructor(
    library: FaIconLibrary, 
    public menuController: MenuController
    ) { 
		library.addIconPacks(fas, fab, far);
    this.initializeApp();
  }

  initializeApp() {
    /* To make sure we provide the fastest app loading experience 
       for our users, hide the splash screen automatically 
       when the app is ready to be used:
        
        https://capacitor.ionicframework.com/docs/apis/splash-screen#hiding-the-splash-screen
    */
    SplashScreen.hide();
  }

  public openMenu(name: string):void{
    console.log(name)
    this.menuController.open(name);
  }
}
