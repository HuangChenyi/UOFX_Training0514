const exposes = {
  // 設定要開放外部使用欄位和頁面
  // ***目前僅實作外掛欄位
  //屬性名稱會對應到/assets/configs/fields-runtime.json 的exposedModule
  web: {
    './TemplateField': './src/app/web/template-field/template-field.module.ts'
    ,'./Demo1Field' : './src/app/web/demo1-field/demo1-field.module.ts'
        ,'./Demo2Field' : './src/app/web/demo2-field/demo2-field.module.ts'
        //勿刪除存放Web欄位的路徑
  },
  app: {
     './TemplateField': './src/app/web/template-field/template-field.module.ts'
    ,'./Demo1Field' : './src/app/mobile/demo1-field/demo1-field.module.ts'
        ,'./Demo2Field' : './src/app/mobile/demo2-field/demo2-field.module.ts'
        //勿刪除存放App欄位的路徑
  }
};

module.exports = exposes;
