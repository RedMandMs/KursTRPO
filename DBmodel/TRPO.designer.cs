﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBmodel
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="trpo")]
	public partial class TRPODataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcapasitor(capasitor instance);
    partial void Updatecapasitor(capasitor instance);
    partial void Deletecapasitor(capasitor instance);
    partial void Insertresistor(resistor instance);
    partial void Updateresistor(resistor instance);
    partial void Deleteresistor(resistor instance);
    partial void Insertcoil(coil instance);
    partial void Updatecoil(coil instance);
    partial void Deletecoil(coil instance);
    partial void Insertelement(element instance);
    partial void Updateelement(element instance);
    partial void Deleteelement(element instance);
    partial void Insertscheme1(scheme1 instance);
    partial void Updatescheme1(scheme1 instance);
    partial void Deletescheme1(scheme1 instance);
    partial void Insertscheme3(scheme3 instance);
    partial void Updatescheme3(scheme3 instance);
    partial void Deletescheme3(scheme3 instance);
    partial void Insertscheme2(scheme2 instance);
    partial void Updatescheme2(scheme2 instance);
    partial void Deletescheme2(scheme2 instance);
    #endregion
		
		public TRPODataContext() : 
				base(global::DBmodel.Properties.Settings.Default.trpoConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public TRPODataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TRPODataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TRPODataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TRPODataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<capasitor> capasitors
		{
			get
			{
				return this.GetTable<capasitor>();
			}
		}
		
		public System.Data.Linq.Table<resistor> resistors
		{
			get
			{
				return this.GetTable<resistor>();
			}
		}
		
		public System.Data.Linq.Table<coil> coils
		{
			get
			{
				return this.GetTable<coil>();
			}
		}
		
		public System.Data.Linq.Table<element> elements
		{
			get
			{
				return this.GetTable<element>();
			}
		}
		
		public System.Data.Linq.Table<scheme1> scheme1s
		{
			get
			{
				return this.GetTable<scheme1>();
			}
		}
		
		public System.Data.Linq.Table<scheme3> scheme3s
		{
			get
			{
				return this.GetTable<scheme3>();
			}
		}
		
		public System.Data.Linq.Table<scheme2> scheme2s
		{
			get
			{
				return this.GetTable<scheme2>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.capasitors")]
	public partial class capasitor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<double> _resistance;
		
		private System.Nullable<double> _max_freq;
		
		private System.Nullable<double> _max_temp;
		
		private System.Nullable<decimal> _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnresistanceChanging(System.Nullable<double> value);
    partial void OnresistanceChanged();
    partial void Onmax_freqChanging(System.Nullable<double> value);
    partial void Onmax_freqChanged();
    partial void Onmax_tempChanging(System.Nullable<double> value);
    partial void Onmax_tempChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    #endregion
		
		public capasitor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_resistance", DbType="Float")]
		public System.Nullable<double> resistance
		{
			get
			{
				return this._resistance;
			}
			set
			{
				if ((this._resistance != value))
				{
					this.OnresistanceChanging(value);
					this.SendPropertyChanging();
					this._resistance = value;
					this.SendPropertyChanged("resistance");
					this.OnresistanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_max_freq", DbType="Float")]
		public System.Nullable<double> max_freq
		{
			get
			{
				return this._max_freq;
			}
			set
			{
				if ((this._max_freq != value))
				{
					this.Onmax_freqChanging(value);
					this.SendPropertyChanging();
					this._max_freq = value;
					this.SendPropertyChanged("max_freq");
					this.Onmax_freqChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_max_temp", DbType="Float")]
		public System.Nullable<double> max_temp
		{
			get
			{
				return this._max_temp;
			}
			set
			{
				if ((this._max_temp != value))
				{
					this.Onmax_tempChanging(value);
					this.SendPropertyChanging();
					this._max_temp = value;
					this.SendPropertyChanged("max_temp");
					this.Onmax_tempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.resistors")]
	public partial class resistor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<double> _resistance;
		
		private System.Nullable<double> _max_voltage;
		
		private System.Nullable<double> _max_temp;
		
		private System.Nullable<decimal> _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnresistanceChanging(System.Nullable<double> value);
    partial void OnresistanceChanged();
    partial void Onmax_voltageChanging(System.Nullable<double> value);
    partial void Onmax_voltageChanged();
    partial void Onmax_tempChanging(System.Nullable<double> value);
    partial void Onmax_tempChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    #endregion
		
		public resistor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_resistance", DbType="Float")]
		public System.Nullable<double> resistance
		{
			get
			{
				return this._resistance;
			}
			set
			{
				if ((this._resistance != value))
				{
					this.OnresistanceChanging(value);
					this.SendPropertyChanging();
					this._resistance = value;
					this.SendPropertyChanged("resistance");
					this.OnresistanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_max_voltage", DbType="Float")]
		public System.Nullable<double> max_voltage
		{
			get
			{
				return this._max_voltage;
			}
			set
			{
				if ((this._max_voltage != value))
				{
					this.Onmax_voltageChanging(value);
					this.SendPropertyChanging();
					this._max_voltage = value;
					this.SendPropertyChanged("max_voltage");
					this.Onmax_voltageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_max_temp", DbType="Float")]
		public System.Nullable<double> max_temp
		{
			get
			{
				return this._max_temp;
			}
			set
			{
				if ((this._max_temp != value))
				{
					this.Onmax_tempChanging(value);
					this.SendPropertyChanging();
					this._max_temp = value;
					this.SendPropertyChanged("max_temp");
					this.Onmax_tempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.coils")]
	public partial class coil : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<double> _industance;
		
		private System.Nullable<double> _max_freq;
		
		private System.Nullable<double> _max_temp;
		
		private System.Nullable<decimal> _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnindustanceChanging(System.Nullable<double> value);
    partial void OnindustanceChanged();
    partial void Onmax_freqChanging(System.Nullable<double> value);
    partial void Onmax_freqChanged();
    partial void Onmax_tempChanging(System.Nullable<double> value);
    partial void Onmax_tempChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    #endregion
		
		public coil()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_industance", DbType="Float")]
		public System.Nullable<double> industance
		{
			get
			{
				return this._industance;
			}
			set
			{
				if ((this._industance != value))
				{
					this.OnindustanceChanging(value);
					this.SendPropertyChanging();
					this._industance = value;
					this.SendPropertyChanged("industance");
					this.OnindustanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_max_freq", DbType="Float")]
		public System.Nullable<double> max_freq
		{
			get
			{
				return this._max_freq;
			}
			set
			{
				if ((this._max_freq != value))
				{
					this.Onmax_freqChanging(value);
					this.SendPropertyChanging();
					this._max_freq = value;
					this.SendPropertyChanged("max_freq");
					this.Onmax_freqChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_max_temp", DbType="Float")]
		public System.Nullable<double> max_temp
		{
			get
			{
				return this._max_temp;
			}
			set
			{
				if ((this._max_temp != value))
				{
					this.Onmax_tempChanging(value);
					this.SendPropertyChanging();
					this._max_temp = value;
					this.SendPropertyChanged("max_temp");
					this.Onmax_tempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.elements")]
	public partial class element : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _element1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onelement1Changing(string value);
    partial void Onelement1Changed();
    #endregion
		
		public element()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="element", Storage="_element1", DbType="VarChar(255)")]
		public string element1
		{
			get
			{
				return this._element1;
			}
			set
			{
				if ((this._element1 != value))
				{
					this.Onelement1Changing(value);
					this.SendPropertyChanging();
					this._element1 = value;
					this.SendPropertyChanged("element1");
					this.Onelement1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.scheme1")]
	public partial class scheme1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_elem;
		
		private int _count;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_elemChanging(int value);
    partial void Onid_elemChanged();
    partial void OncountChanging(int value);
    partial void OncountChanged();
    #endregion
		
		public scheme1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_elem", DbType="Int NOT NULL")]
		public int id_elem
		{
			get
			{
				return this._id_elem;
			}
			set
			{
				if ((this._id_elem != value))
				{
					this.Onid_elemChanging(value);
					this.SendPropertyChanging();
					this._id_elem = value;
					this.SendPropertyChanged("id_elem");
					this.Onid_elemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_count", DbType="Int NOT NULL")]
		public int count
		{
			get
			{
				return this._count;
			}
			set
			{
				if ((this._count != value))
				{
					this.OncountChanging(value);
					this.SendPropertyChanging();
					this._count = value;
					this.SendPropertyChanged("count");
					this.OncountChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.scheme3")]
	public partial class scheme3 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_elem;
		
		private int _count;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_elemChanging(int value);
    partial void Onid_elemChanged();
    partial void OncountChanging(int value);
    partial void OncountChanged();
    #endregion
		
		public scheme3()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_elem", DbType="Int NOT NULL")]
		public int id_elem
		{
			get
			{
				return this._id_elem;
			}
			set
			{
				if ((this._id_elem != value))
				{
					this.Onid_elemChanging(value);
					this.SendPropertyChanging();
					this._id_elem = value;
					this.SendPropertyChanged("id_elem");
					this.Onid_elemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_count", DbType="Int NOT NULL")]
		public int count
		{
			get
			{
				return this._count;
			}
			set
			{
				if ((this._count != value))
				{
					this.OncountChanging(value);
					this.SendPropertyChanging();
					this._count = value;
					this.SendPropertyChanged("count");
					this.OncountChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.scheme2")]
	public partial class scheme2 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_elem;
		
		private int _count;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_elemChanging(int value);
    partial void Onid_elemChanged();
    partial void OncountChanging(int value);
    partial void OncountChanged();
    #endregion
		
		public scheme2()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_elem", DbType="Int NOT NULL")]
		public int id_elem
		{
			get
			{
				return this._id_elem;
			}
			set
			{
				if ((this._id_elem != value))
				{
					this.Onid_elemChanging(value);
					this.SendPropertyChanging();
					this._id_elem = value;
					this.SendPropertyChanged("id_elem");
					this.Onid_elemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_count", DbType="Int NOT NULL")]
		public int count
		{
			get
			{
				return this._count;
			}
			set
			{
				if ((this._count != value))
				{
					this.OncountChanging(value);
					this.SendPropertyChanging();
					this._count = value;
					this.SendPropertyChanged("count");
					this.OncountChanged();
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
