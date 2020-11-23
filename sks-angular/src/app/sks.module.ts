
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as SKS from './components/sks';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    SKS.frmAboutComponent,
    SKS.frmActionOrderReceptionComponent,
    SKS.frmActionOrderRequestComponent,
    SKS.frmAddProductToComponent,
    SKS.frmAddStockManualComponent,
    SKS.frmAdjustStockManualComponent,
    SKS.frmCustomersComponent,
    SKS.frmLoginComponent,
    SKS.frmMainComponent,
    SKS.frmOrderReceptionComponent,
    SKS.frmOrderRequestComponent,
    SKS.frmProductsComponent,
    SKS.frmProvidersComponent,
    SKS.frmReceptionApprovalComponent,
    SKS.frmRequestApprovalComponent,
    SKS.frmSearchComponent,
    SKS.frmSplashComponent,
    SKS.frmUsersManageComponent,
  ],
  declarations: [
    SKS.frmAboutComponent,
    SKS.frmActionOrderReceptionComponent,
    SKS.frmActionOrderRequestComponent,
    SKS.frmAddProductToComponent,
    SKS.frmAddStockManualComponent,
    SKS.frmAdjustStockManualComponent,
    SKS.frmCustomersComponent,
    SKS.frmLoginComponent,
    SKS.frmMainComponent,
    SKS.frmOrderReceptionComponent,
    SKS.frmOrderRequestComponent,
    SKS.frmProductsComponent,
    SKS.frmProvidersComponent,
    SKS.frmReceptionApprovalComponent,
    SKS.frmRequestApprovalComponent,
    SKS.frmSearchComponent,
    SKS.frmSplashComponent,
    SKS.frmUsersManageComponent,
  ],
  bootstrap: [
    SKS.frmAboutComponent,
    SKS.frmActionOrderReceptionComponent,
    SKS.frmActionOrderRequestComponent,
    SKS.frmAddProductToComponent,
    SKS.frmAddStockManualComponent,
    SKS.frmAdjustStockManualComponent,
    SKS.frmCustomersComponent,
    SKS.frmLoginComponent,
    SKS.frmMainComponent,
    SKS.frmOrderReceptionComponent,
    SKS.frmOrderRequestComponent,
    SKS.frmProductsComponent,
    SKS.frmProvidersComponent,
    SKS.frmReceptionApprovalComponent,
    SKS.frmRequestApprovalComponent,
    SKS.frmSearchComponent,
    SKS.frmSplashComponent,
    SKS.frmUsersManageComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class SKSModule { }

