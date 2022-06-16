using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RubikStore.Models
{
    public class Giohang
    {
        dbRubikStoreDataContext data = new dbRubikStoreDataContext();
        public int id { get; set; }
        [Display(Name ="Tên")]
        public string ten { get; set; }
        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }
        [Display(Name = "Giá bán")]
        public Double gia { get; set; }
        [Display(Name = "Số lượng")]
        public int iSoLuong { get; set; }
        [Display(Name = "Thành tiền")]
        public Double dThanhTien
        {
            get { return iSoLuong * gia; }
        }
        public Giohang(int id)
        {
            this.id = id;
            Rubik rubik = data.Rubiks.Single(n => n.id == id);
            ten = rubik.ten;
            hinh = rubik.hinh;
            gia = double.Parse(rubik.gia.ToString());
            iSoLuong = 1;
        }
    }
}