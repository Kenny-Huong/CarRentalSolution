﻿using Bus.Serviece.Interface; using Dal.Modal; using Dal.Repository; using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;  namespace Bus.Serviece.Implements {     public class KhachHangService:IKhachHangService     {         KhachHangRepo _khachHangRepo = new KhachHangRepo();         List<KhachHang> _lstKhachHang;          public KhachHangService()         {                 _lstKhachHang = new List<KhachHang>();         }         public List<KhachHang> GetALL()         {             return _khachHangRepo.GetALL();         }         public KhachHang FindKhachHang(Guid id)         {             return _lstKhachHang.FirstOrDefault(p => p.Id == id);         }          public bool CreateKhachHang (KhachHang khachHang)         {                 return _khachHangRepo.Create(khachHang);         }         public bool UpdateKhachHang(KhachHang khachHang)         {             return _khachHangRepo.Update(khachHang);         }      } } 