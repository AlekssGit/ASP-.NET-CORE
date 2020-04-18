using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина имени не менее 3-ех символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина фамилии не менее 3-ех символов")]
        public string surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина адреса не менее 5-и символов")]
        public string adress { get; set; }

        [Display(Name = "Введите телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 10-и символов")]
        public string phone { get; set; }

        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина имени не менее 10-и символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
