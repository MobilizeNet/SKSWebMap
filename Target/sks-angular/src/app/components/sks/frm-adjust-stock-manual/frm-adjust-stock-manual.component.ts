import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "sks-frm-adjust-stock-manual",
   styleUrls : ["./frm-adjust-stock-manual.component.css"],
   templateUrl : "./frm-adjust-stock-manual.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmSKSfrmAdjustStockManual"])
export class frmAdjustStockManualComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}