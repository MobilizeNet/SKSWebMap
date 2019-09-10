
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as SKS from './components/sks';

@NgModule({
  imports: [
    CommonModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    SKS.frmSplashComponent,
    SKS.frmRequestApprovalComponent,
    SKS.frmMainComponent,
    SKS.frmActionOrderRequestComponent,
    SKS.frmReceptionApprovalComponent,
    SKS.frmActionOrderReceptionComponent,
    SKS.frmProductsComponent,
    SKS.frmProvidersComponent,
    SKS.frmAddStockManualComponent,
    SKS.frmAdjustStockManualComponent,
    SKS.frmAddProductToComponent,
    SKS.frmOrderRequestComponent,
    SKS.frmUsersManageComponent,
    SKS.frmSearchComponent,
    SKS.frmOrderReceptionComponent,
    SKS.frmLoginComponent,
    SKS.frmAboutComponent,
    SKS.frmCustomersComponent,
  ],
  declarations: [
    SKS.frmSplashComponent,
    SKS.frmRequestApprovalComponent,
    SKS.frmMainComponent,
    SKS.frmActionOrderRequestComponent,
    SKS.frmReceptionApprovalComponent,
    SKS.frmActionOrderReceptionComponent,
    SKS.frmProductsComponent,
    SKS.frmProvidersComponent,
    SKS.frmAddStockManualComponent,
    SKS.frmAdjustStockManualComponent,
    SKS.frmAddProductToComponent,
    SKS.frmOrderRequestComponent,
    SKS.frmUsersManageComponent,
    SKS.frmSearchComponent,
    SKS.frmOrderReceptionComponent,
    SKS.frmLoginComponent,
    SKS.frmAboutComponent,
    SKS.frmCustomersComponent,
  ],
  entryComponents: [
    SKS.frmSplashComponent,
    SKS.frmRequestApprovalComponent,
    SKS.frmMainComponent,
    SKS.frmActionOrderRequestComponent,
    SKS.frmReceptionApprovalComponent,
    SKS.frmActionOrderReceptionComponent,
    SKS.frmProductsComponent,
    SKS.frmProvidersComponent,
    SKS.frmAddStockManualComponent,
    SKS.frmAdjustStockManualComponent,
    SKS.frmAddProductToComponent,
    SKS.frmOrderRequestComponent,
    SKS.frmUsersManageComponent,
    SKS.frmSearchComponent,
    SKS.frmOrderReceptionComponent,
    SKS.frmLoginComponent,
    SKS.frmAboutComponent,
    SKS.frmCustomersComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class SKSModule { }

