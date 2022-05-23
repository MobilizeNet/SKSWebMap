import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "sks-frm-action-order-request",
   styleUrls : ["./frm-action-order-request.component.css"],
   templateUrl : "./frm-action-order-request.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmSKSfrmActionOrderRequest"])
export class frmActionOrderRequestComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}