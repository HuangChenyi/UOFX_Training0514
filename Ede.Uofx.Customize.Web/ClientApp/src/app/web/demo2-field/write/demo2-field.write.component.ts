/*
此為外掛欄位wtite mode的樣板，修改/置換的項事如下
修改import 擴充屬性(ExProps)的interface
修改selector和templateUrl路徑
修改classname
修改 @Input() exProps 的interface
*/

import {
  AbstractControl,
  FormControl,
  UntypedFormBuilder,
  UntypedFormGroup,
  ValidationErrors,
  ValidatorFn,
  Validators,
} from '@angular/forms';
import { BpmFwWriteComponent, UofxFormTools } from '@uofx/web-components/form';
import { ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';

import { Demo2FieldExProps } from '../props/demo2-field.props.component';
import { SelectDataComponent } from '../select-data/select-data.component';
import { UofxDialogController } from '@uofx/web-components/dialog';

/*修改*/
/*↑↑↑↑修改import 各模式的Component↑↑↑↑*/

/*修改*/
/*置換selector和templateUrl*/
@Component({
  selector: 'uofx-template-field-write-component',
  templateUrl: './demo2-field.write.component.html',
})

/*修改*/
/*置換className*/
export class Demo2FieldWriteComponent
  extends BpmFwWriteComponent
  implements OnInit
{

  /*修改*/
  /*置換className*/
  @Input() exProps: Demo2FieldExProps;
 value:CustomerInfo;
  form: UntypedFormGroup;
  constructor(
    private cdr: ChangeDetectorRef,
    private fb: UntypedFormBuilder,
    private tools: UofxFormTools,
    private dialogCtrl: UofxDialogController
  ) {
    super();
  }


  errorMsg:string;

  ngOnInit(): void {

    this.initForm();

    this.parentForm.statusChanges.subscribe((res) => {
      if (res === 'INVALID' && this.selfControl.dirty) {
        if (!this.form.dirty) {
          Object.keys(this.form.controls).forEach((key) => {
            this.tools.markFormControl(this.form.get(key));
          });
          this.form.markAsDirty();
        }
      }
    });

    this.form.valueChanges.subscribe((res) => {
      this.selfControl?.setValue(res);
      /*真正送出欄位值變更的函式*/
      this.valueChanges.emit(res);
    });
    this.cdr.detectChanges();
  }

  SelectData()
  {
this.dialogCtrl.createFlexibleScreen({
  component: SelectDataComponent,
  params: {
     /*開窗要帶的參數*/
  }
}).afterClose.subscribe({
  next: res => {
  /*關閉視窗後處理的訂閱事件*/
  if (res) {  }
}
});
  }

  initForm() {
    this.form = this.fb.group({
      companyName: [this.value?.companyName || '', Validators.required],
      address: [this.value?.address || '', Validators.required],
      phone: [this.value?.phone || '', Validators.required],
    });

    if (this.selfControl) {
      // 在此便可設定自己的驗證器
      this.selfControl.setValidators(validateSelf(this.form));
      this.selfControl.updateValueAndValidity();
    }
  }

  /*判斷如果是儲存不用作驗證*/
  checkBeforeSubmit(checkValidator: boolean): Promise<boolean> {

    // 儲存不需要驗證，直接回傳true
    if (!checkValidator) {
      return new Promise((resolve) => {
        resolve(true);
      });
    }
    else {

      return new Promise((resolve) => {

        if (checkValidator) {
          return this.checkFieldValid(resolve);
        }
        else {
          resolve(true);
        }
      });
    }
  }

    /** 實作送出前驗證 */
    checkFieldValid(resolve) {
      this.setBeforeCheck(true);
      this.errorMsg = '';
      //實作驗證邏輯
      if (false) {
        this.errorMsg = '放入錯誤訊息';
        resolve(false );
      } else {
        this.errorMsg = '';
        resolve(true);
      }
    }

    /** 驗證前的設定 */
    setBeforeCheck(checkValidator: boolean) {

      this.tools.markFormGroup(this.form);
      // form驗證狀態重製
      if (!checkValidator) this.form.reset(this.form.getRawValue());
      // 暫存時不驗證必填
      checkFieldDefaultValidator(checkValidator, new FormControl(this.form.controls));
    }
}

/*外掛欄位自訂的證器*/
function validateSelf(form: UntypedFormGroup): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    return form.valid ? null : { formInvalid: true };
  };
}

/** 暫存時不驗證必填 */
function checkFieldDefaultValidator(checkDefaultValidator: boolean, formControl: FormControl) {
  if (!checkDefaultValidator && formControl.hasError('required')) {
    delete formControl.errors['required'];
    formControl.setErrors(Object.keys(formControl.errors).length === 0 ? null : formControl.errors);
  }
  else if (checkDefaultValidator && formControl.valid) {
    formControl.updateValueAndValidity();
  }
}

export interface CustomerInfo {
  companyName: string;
  address: string;
  phone: string;
}
