﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2012-12-25 15:33:37 by App
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apps.Models.Sys
{

    public partial class SysModuleNavModel
    {
        public  string id { get; set; }
        public  string text { get; set; }
        public  string iconCls { get; set; }
        public  string attributes { get; set; }
        public  string state { get; set; }
      
    }

    public partial class SysModuleModel
    {

     

        [NotNullExpression]
        [Display(Name = "ID")]
        public override string Id { get; set; }
        [NotNullExpression]
        [Display(Name = "名称")]
        public override string Name { get; set; }

        [Display(Name = "别名")]
        public override string EnglishName { get; set; }
        [NotNullExpression]
        [Display(Name = "上级ID")]
        public override string ParentId { get; set; }
        [Display(Name = "链接")]
        public override string Url { get; set; }
        [Display(Name = "图标")]
        public override string Iconic { get; set; }
        [NotNullExpression]
        [IsNumberExpression]//如果填写判断是否是数字
        [Display(Name = "排序号")]
        public override int? Sort { get; set; }
        [Display(Name = "说明")]
        public override string Remark { get; set; }
        [Display(Name = "状态")]
        public override bool Enable { get; set; }
        [Display(Name = "创建人")]
        public override string CreatePerson { get; set; }
        [DateExpression]//如果填写判断是否是日期
        [Display(Name = "创建时间")]
        public override DateTime? CreateTime { get; set; }
        [Display(Name = "是否最后一项")]
        public override bool IsLast { get; set; }

        public  string state { get; set; }//treegrid

    }
}

