import { Component, OnInit } from '@angular/core';
import { UofxDialog, UofxDialogController } from "@uofx/web-components/dialog";

import { CustomerInfo } from '../write/demo2-field.write.component';
import { CustomerService } from '@service/customer.service';
import { FormDirtyConfirm } from "@uofx/core";

@Component({
  selector: 'app-select-data',
  templateUrl: './select-data.component.html',
  styleUrls: ['./select-data.component.css']
})
export class SelectDataComponent extends UofxDialog implements OnInit {
  constructor(private dialogCtrl: UofxDialogController
    , private cs:CustomerService
  ) {
    super();
  }

  ngOnInit(): void {

    this.apiUrl=this.params.apiUrl;
    this.cs.serverUrl=this.apiUrl;
    this.cs.getCustomers().subscribe(
      data=>{
        this.gridData=data;
      }
    );

  }

apiUrl:string;
gridData:Array<CustomerInfo>=[];

selectItem(item:CustomerInfo)
{
  this.close(item);
}

  CloseDialog()
  {
this.close();

  }
}


