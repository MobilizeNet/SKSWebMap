import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "sks-frm-request-approval",
   styleUrls : ["./frm-request-approval.component.css"],
   templateUrl : "./frm-request-approval.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmSKSfrmRequestApproval"])
export class frmRequestApprovalComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}