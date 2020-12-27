﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTX_Management.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KTX_Management")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDien(Dien instance);
    partial void UpdateDien(Dien instance);
    partial void DeleteDien(Dien instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertHopDong(HopDong instance);
    partial void UpdateHopDong(HopDong instance);
    partial void DeleteHopDong(HopDong instance);
    partial void InsertKhu(Khu instance);
    partial void UpdateKhu(Khu instance);
    partial void DeleteKhu(Khu instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertNuoc(Nuoc instance);
    partial void UpdateNuoc(Nuoc instance);
    partial void DeleteNuoc(Nuoc instance);
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["KTX_ManagementConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dien> Diens
		{
			get
			{
				return this.GetTable<Dien>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<HopDong> HopDongs
		{
			get
			{
				return this.GetTable<HopDong>();
			}
		}
		
		public System.Data.Linq.Table<Khu> Khus
		{
			get
			{
				return this.GetTable<Khu>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<Nuoc> Nuocs
		{
			get
			{
				return this.GetTable<Nuoc>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dien")]
	public partial class Dien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private double _GiaDien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGiaDienChanging(double value);
    partial void OnGiaDienChanged();
    #endregion
		
		public Dien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaDien", DbType="Float NOT NULL")]
		public double GiaDien
		{
			get
			{
				return this._GiaDien;
			}
			set
			{
				if ((this._GiaDien != value))
				{
					this.OnGiaDienChanging(value);
					this.SendPropertyChanging();
					this._GiaDien = value;
					this.SendPropertyChanged("GiaDien");
					this.OnGiaDienChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _MSSV;
		
		private string _Name;
		
		private string _NgaySinh;
		
		private string _Phone;
		
		private string _Passport;
		
		private int _GioiTinh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMSSVChanging(string value);
    partial void OnMSSVChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnPassportChanging(string value);
    partial void OnPassportChanged();
    partial void OnGioiTinhChanging(int value);
    partial void OnGioiTinhChanged();
    #endregion
		
		public SinhVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSSV", DbType="NVarChar(MAX)")]
		public string MSSV
		{
			get
			{
				return this._MSSV;
			}
			set
			{
				if ((this._MSSV != value))
				{
					this.OnMSSVChanging(value);
					this.SendPropertyChanging();
					this._MSSV = value;
					this.SendPropertyChanged("MSSV");
					this.OnMSSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(MAX)")]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(MAX)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passport", DbType="NVarChar(MAX)")]
		public string Passport
		{
			get
			{
				return this._Passport;
			}
			set
			{
				if ((this._Passport != value))
				{
					this.OnPassportChanging(value);
					this.SendPropertyChanging();
					this._Passport = value;
					this.SendPropertyChanged("Passport");
					this.OnPassportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Int NOT NULL")]
		public int GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdRoom;
		
		private int _IdNhanVien;
		
		private int _IdDien;
		
		private int _IdNuoc;
		
		private string _NgayLap;
		
		private int _SoDienCu;
		
		private int _SoDienMoi;
		
		private int _SoNuocCu;
		
		private int _SoNuocMoi;
		
		private double _ThanhTien;
		
		private System.Nullable<int> _IdSinhVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdRoomChanging(int value);
    partial void OnIdRoomChanged();
    partial void OnIdNhanVienChanging(int value);
    partial void OnIdNhanVienChanged();
    partial void OnIdDienChanging(int value);
    partial void OnIdDienChanged();
    partial void OnIdNuocChanging(int value);
    partial void OnIdNuocChanged();
    partial void OnNgayLapChanging(string value);
    partial void OnNgayLapChanged();
    partial void OnSoDienCuChanging(int value);
    partial void OnSoDienCuChanged();
    partial void OnSoDienMoiChanging(int value);
    partial void OnSoDienMoiChanged();
    partial void OnSoNuocCuChanging(int value);
    partial void OnSoNuocCuChanged();
    partial void OnSoNuocMoiChanging(int value);
    partial void OnSoNuocMoiChanged();
    partial void OnThanhTienChanging(double value);
    partial void OnThanhTienChanged();
    partial void OnIdSinhVienChanging(System.Nullable<int> value);
    partial void OnIdSinhVienChanged();
    #endregion
		
		public HoaDon()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRoom", DbType="Int NOT NULL")]
		public int IdRoom
		{
			get
			{
				return this._IdRoom;
			}
			set
			{
				if ((this._IdRoom != value))
				{
					this.OnIdRoomChanging(value);
					this.SendPropertyChanging();
					this._IdRoom = value;
					this.SendPropertyChanged("IdRoom");
					this.OnIdRoomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNhanVien", DbType="Int NOT NULL")]
		public int IdNhanVien
		{
			get
			{
				return this._IdNhanVien;
			}
			set
			{
				if ((this._IdNhanVien != value))
				{
					this.OnIdNhanVienChanging(value);
					this.SendPropertyChanging();
					this._IdNhanVien = value;
					this.SendPropertyChanged("IdNhanVien");
					this.OnIdNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDien", DbType="Int NOT NULL")]
		public int IdDien
		{
			get
			{
				return this._IdDien;
			}
			set
			{
				if ((this._IdDien != value))
				{
					this.OnIdDienChanging(value);
					this.SendPropertyChanging();
					this._IdDien = value;
					this.SendPropertyChanged("IdDien");
					this.OnIdDienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNuoc", DbType="Int NOT NULL")]
		public int IdNuoc
		{
			get
			{
				return this._IdNuoc;
			}
			set
			{
				if ((this._IdNuoc != value))
				{
					this.OnIdNuocChanging(value);
					this.SendPropertyChanging();
					this._IdNuoc = value;
					this.SendPropertyChanged("IdNuoc");
					this.OnIdNuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="NVarChar(MAX)")]
		public string NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienCu", DbType="Int NOT NULL")]
		public int SoDienCu
		{
			get
			{
				return this._SoDienCu;
			}
			set
			{
				if ((this._SoDienCu != value))
				{
					this.OnSoDienCuChanging(value);
					this.SendPropertyChanging();
					this._SoDienCu = value;
					this.SendPropertyChanged("SoDienCu");
					this.OnSoDienCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienMoi", DbType="Int NOT NULL")]
		public int SoDienMoi
		{
			get
			{
				return this._SoDienMoi;
			}
			set
			{
				if ((this._SoDienMoi != value))
				{
					this.OnSoDienMoiChanging(value);
					this.SendPropertyChanging();
					this._SoDienMoi = value;
					this.SendPropertyChanged("SoDienMoi");
					this.OnSoDienMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNuocCu", DbType="Int NOT NULL")]
		public int SoNuocCu
		{
			get
			{
				return this._SoNuocCu;
			}
			set
			{
				if ((this._SoNuocCu != value))
				{
					this.OnSoNuocCuChanging(value);
					this.SendPropertyChanging();
					this._SoNuocCu = value;
					this.SendPropertyChanged("SoNuocCu");
					this.OnSoNuocCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNuocMoi", DbType="Int NOT NULL")]
		public int SoNuocMoi
		{
			get
			{
				return this._SoNuocMoi;
			}
			set
			{
				if ((this._SoNuocMoi != value))
				{
					this.OnSoNuocMoiChanging(value);
					this.SendPropertyChanging();
					this._SoNuocMoi = value;
					this.SendPropertyChanged("SoNuocMoi");
					this.OnSoNuocMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float NOT NULL")]
		public double ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSinhVien", DbType="Int")]
		public System.Nullable<int> IdSinhVien
		{
			get
			{
				return this._IdSinhVien;
			}
			set
			{
				if ((this._IdSinhVien != value))
				{
					this.OnIdSinhVienChanging(value);
					this.SendPropertyChanging();
					this._IdSinhVien = value;
					this.SendPropertyChanged("IdSinhVien");
					this.OnIdSinhVienChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HopDong")]
	public partial class HopDong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdSinhVien;
		
		private System.Nullable<int> _IdNhanVien;
		
		private string _NgayBatDau;
		
		private string _NgayKetThuc;
		
		private string _NgayLap;
		
		private int _TinhTrang;
		
		private string _NgayLamDon;
		
		private System.Nullable<int> _IdRoom;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdSinhVienChanging(int value);
    partial void OnIdSinhVienChanged();
    partial void OnIdNhanVienChanging(System.Nullable<int> value);
    partial void OnIdNhanVienChanged();
    partial void OnNgayBatDauChanging(string value);
    partial void OnNgayBatDauChanged();
    partial void OnNgayKetThucChanging(string value);
    partial void OnNgayKetThucChanged();
    partial void OnNgayLapChanging(string value);
    partial void OnNgayLapChanged();
    partial void OnTinhTrangChanging(int value);
    partial void OnTinhTrangChanged();
    partial void OnNgayLamDonChanging(string value);
    partial void OnNgayLamDonChanged();
    partial void OnIdRoomChanging(System.Nullable<int> value);
    partial void OnIdRoomChanged();
    #endregion
		
		public HopDong()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSinhVien", DbType="Int NOT NULL")]
		public int IdSinhVien
		{
			get
			{
				return this._IdSinhVien;
			}
			set
			{
				if ((this._IdSinhVien != value))
				{
					this.OnIdSinhVienChanging(value);
					this.SendPropertyChanging();
					this._IdSinhVien = value;
					this.SendPropertyChanged("IdSinhVien");
					this.OnIdSinhVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNhanVien", DbType="Int")]
		public System.Nullable<int> IdNhanVien
		{
			get
			{
				return this._IdNhanVien;
			}
			set
			{
				if ((this._IdNhanVien != value))
				{
					this.OnIdNhanVienChanging(value);
					this.SendPropertyChanging();
					this._IdNhanVien = value;
					this.SendPropertyChanged("IdNhanVien");
					this.OnIdNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayBatDau", DbType="NVarChar(MAX)")]
		public string NgayBatDau
		{
			get
			{
				return this._NgayBatDau;
			}
			set
			{
				if ((this._NgayBatDau != value))
				{
					this.OnNgayBatDauChanging(value);
					this.SendPropertyChanging();
					this._NgayBatDau = value;
					this.SendPropertyChanged("NgayBatDau");
					this.OnNgayBatDauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayKetThuc", DbType="NVarChar(MAX)")]
		public string NgayKetThuc
		{
			get
			{
				return this._NgayKetThuc;
			}
			set
			{
				if ((this._NgayKetThuc != value))
				{
					this.OnNgayKetThucChanging(value);
					this.SendPropertyChanging();
					this._NgayKetThuc = value;
					this.SendPropertyChanged("NgayKetThuc");
					this.OnNgayKetThucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="NVarChar(MAX)")]
		public string NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Int NOT NULL")]
		public int TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLamDon", DbType="NVarChar(MAX)")]
		public string NgayLamDon
		{
			get
			{
				return this._NgayLamDon;
			}
			set
			{
				if ((this._NgayLamDon != value))
				{
					this.OnNgayLamDonChanging(value);
					this.SendPropertyChanging();
					this._NgayLamDon = value;
					this.SendPropertyChanged("NgayLamDon");
					this.OnNgayLamDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRoom", DbType="Int")]
		public System.Nullable<int> IdRoom
		{
			get
			{
				return this._IdRoom;
			}
			set
			{
				if ((this._IdRoom != value))
				{
					this.OnIdRoomChanging(value);
					this.SendPropertyChanging();
					this._IdRoom = value;
					this.SendPropertyChanged("IdRoom");
					this.OnIdRoomChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Khu")]
	public partial class Khu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _TenKhu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTenKhuChanging(string value);
    partial void OnTenKhuChanged();
    #endregion
		
		public Khu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhu", DbType="NVarChar(MAX)")]
		public string TenKhu
		{
			get
			{
				return this._TenKhu;
			}
			set
			{
				if ((this._TenKhu != value))
				{
					this.OnTenKhuChanging(value);
					this.SendPropertyChanging();
					this._TenKhu = value;
					this.SendPropertyChanged("TenKhu");
					this.OnTenKhuChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _ChucVu;
		
		private string _Phone;
		
		private string _DiaChi;
		
		private int _GioiTinh;
		
		private int _Status;
		
		private string _User;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnGioiTinhChanging(int value);
    partial void OnGioiTinhChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public NhanVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NVarChar(MAX)")]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(MAX)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(MAX)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Int NOT NULL")]
		public int GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="NVarChar(MAX)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(MAX)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nuoc")]
	public partial class Nuoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private double _GiaNuoc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGiaNuocChanging(double value);
    partial void OnGiaNuocChanged();
    #endregion
		
		public Nuoc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaNuoc", DbType="Float NOT NULL")]
		public double GiaNuoc
		{
			get
			{
				return this._GiaNuoc;
			}
			set
			{
				if ((this._GiaNuoc != value))
				{
					this.OnGiaNuocChanging(value);
					this.SendPropertyChanging();
					this._GiaNuoc = value;
					this.SendPropertyChanged("GiaNuoc");
					this.OnGiaNuocChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Room")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdKhu;
		
		private string _TenPhong;
		
		private int _TinhTrang;
		
		private string _MoTa;
		
		private int _SoLuong;
		
		private int _SoLuongToiDa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdKhuChanging(int value);
    partial void OnIdKhuChanged();
    partial void OnTenPhongChanging(string value);
    partial void OnTenPhongChanged();
    partial void OnTinhTrangChanging(int value);
    partial void OnTinhTrangChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnSoLuongToiDaChanging(int value);
    partial void OnSoLuongToiDaChanged();
    #endregion
		
		public Room()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdKhu", DbType="Int NOT NULL")]
		public int IdKhu
		{
			get
			{
				return this._IdKhu;
			}
			set
			{
				if ((this._IdKhu != value))
				{
					this.OnIdKhuChanging(value);
					this.SendPropertyChanging();
					this._IdKhu = value;
					this.SendPropertyChanged("IdKhu");
					this.OnIdKhuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPhong", DbType="NVarChar(MAX)")]
		public string TenPhong
		{
			get
			{
				return this._TenPhong;
			}
			set
			{
				if ((this._TenPhong != value))
				{
					this.OnTenPhongChanging(value);
					this.SendPropertyChanging();
					this._TenPhong = value;
					this.SendPropertyChanged("TenPhong");
					this.OnTenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Int NOT NULL")]
		public int TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongToiDa", DbType="Int NOT NULL")]
		public int SoLuongToiDa
		{
			get
			{
				return this._SoLuongToiDa;
			}
			set
			{
				if ((this._SoLuongToiDa != value))
				{
					this.OnSoLuongToiDaChanging(value);
					this.SendPropertyChanging();
					this._SoLuongToiDa = value;
					this.SendPropertyChanged("SoLuongToiDa");
					this.OnSoLuongToiDaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
