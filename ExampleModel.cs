using System;
using System.ComponentModel.DataAnnotations;
namespace LolTest
{


    public class ExampleModel
    {
        [Display(Name="姓名")]
        [Required(ErrorMessage="姓名必填")]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Display(Name="年龄")]
        [Required(ErrorMessage="年龄必填")]
        [Range(0,200,ErrorMessage="年龄必须大于0,小于200")]
        public int age{get;set;}


        [Display(Name="生日")]
        [Required(ErrorMessage="生日必填")]

        public DateTime BirthDate{get;set;}=DateTime.Now;


    }
    /// <summary>
    /// 动态表单
    /// </summary>
    public class ExampleDynamicForm
    {
        [Display(Name="姓名")]
        [Required]
        [StringLength(10, ErrorMessage = "名字太长")]
        public string Name { get; set; }
    }
}