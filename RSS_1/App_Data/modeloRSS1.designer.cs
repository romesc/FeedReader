﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSS_1.App_Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bancoRSS")]
	public partial class modeloRssDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertRegra(Regra instance);
    partial void UpdateRegra(Regra instance);
    partial void DeleteRegra(Regra instance);
    partial void InsertFeed(Feed instance);
    partial void UpdateFeed(Feed instance);
    partial void DeleteFeed(Feed instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    #endregion
		
		public modeloRssDataContext() : 
				base(global::RSS_1.Properties.Settings.Default.bancoRSSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public modeloRssDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public modeloRssDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public modeloRssDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public modeloRssDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Regra> Regra
		{
			get
			{
				return this.GetTable<Regra>();
			}
		}
		
		public System.Data.Linq.Table<Feed> Feed
		{
			get
			{
				return this.GetTable<Feed>();
			}
		}
		
		public System.Data.Linq.Table<Item> Item
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cat_codigo;
		
		private string _cat_descricao;
		
		private EntitySet<Feed> _Feed;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncat_codigoChanging(int value);
    partial void Oncat_codigoChanged();
    partial void Oncat_descricaoChanging(string value);
    partial void Oncat_descricaoChanged();
    #endregion
		
		public Categoria()
		{
			this._Feed = new EntitySet<Feed>(new Action<Feed>(this.attach_Feed), new Action<Feed>(this.detach_Feed));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cat_codigo
		{
			get
			{
				return this._cat_codigo;
			}
			set
			{
				if ((this._cat_codigo != value))
				{
					this.Oncat_codigoChanging(value);
					this.SendPropertyChanging();
					this._cat_codigo = value;
					this.SendPropertyChanged("cat_codigo");
					this.Oncat_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_descricao", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string cat_descricao
		{
			get
			{
				return this._cat_descricao;
			}
			set
			{
				if ((this._cat_descricao != value))
				{
					this.Oncat_descricaoChanging(value);
					this.SendPropertyChanging();
					this._cat_descricao = value;
					this.SendPropertyChanged("cat_descricao");
					this.Oncat_descricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Feed", Storage="_Feed", ThisKey="cat_codigo", OtherKey="cat_codigo")]
		public EntitySet<Feed> Feed
		{
			get
			{
				return this._Feed;
			}
			set
			{
				this._Feed.Assign(value);
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
		
		private void attach_Feed(Feed entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Feed(Feed entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Regra")]
	public partial class Regra : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _regra_codigo;
		
		private string _regra_chaves;
		
		private System.Nullable<bool> _regra_ativo;
		
		private string _regra_tipo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onregra_codigoChanging(int value);
    partial void Onregra_codigoChanged();
    partial void Onregra_chavesChanging(string value);
    partial void Onregra_chavesChanged();
    partial void Onregra_ativoChanging(System.Nullable<bool> value);
    partial void Onregra_ativoChanged();
    partial void Onregra_tipoChanging(string value);
    partial void Onregra_tipoChanged();
    #endregion
		
		public Regra()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_regra_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int regra_codigo
		{
			get
			{
				return this._regra_codigo;
			}
			set
			{
				if ((this._regra_codigo != value))
				{
					this.Onregra_codigoChanging(value);
					this.SendPropertyChanging();
					this._regra_codigo = value;
					this.SendPropertyChanged("regra_codigo");
					this.Onregra_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_regra_chaves", DbType="NVarChar(MAX)")]
		public string regra_chaves
		{
			get
			{
				return this._regra_chaves;
			}
			set
			{
				if ((this._regra_chaves != value))
				{
					this.Onregra_chavesChanging(value);
					this.SendPropertyChanging();
					this._regra_chaves = value;
					this.SendPropertyChanged("regra_chaves");
					this.Onregra_chavesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_regra_ativo", DbType="Bit")]
		public System.Nullable<bool> regra_ativo
		{
			get
			{
				return this._regra_ativo;
			}
			set
			{
				if ((this._regra_ativo != value))
				{
					this.Onregra_ativoChanging(value);
					this.SendPropertyChanging();
					this._regra_ativo = value;
					this.SendPropertyChanged("regra_ativo");
					this.Onregra_ativoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_regra_tipo", DbType="NVarChar(20)")]
		public string regra_tipo
		{
			get
			{
				return this._regra_tipo;
			}
			set
			{
				if ((this._regra_tipo != value))
				{
					this.Onregra_tipoChanging(value);
					this.SendPropertyChanging();
					this._regra_tipo = value;
					this.SendPropertyChanged("regra_tipo");
					this.Onregra_tipoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Feed")]
	public partial class Feed : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _feed_codigo;
		
		private string _feed_descricao;
		
		private int _feed_qt_nao_lidos;
		
		private int _cat_codigo;
		
		private EntitySet<Item> _Item;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onfeed_codigoChanging(int value);
    partial void Onfeed_codigoChanged();
    partial void Onfeed_descricaoChanging(string value);
    partial void Onfeed_descricaoChanged();
    partial void Onfeed_qt_nao_lidosChanging(int value);
    partial void Onfeed_qt_nao_lidosChanged();
    partial void Oncat_codigoChanging(int value);
    partial void Oncat_codigoChanged();
    #endregion
		
		public Feed()
		{
			this._Item = new EntitySet<Item>(new Action<Item>(this.attach_Item), new Action<Item>(this.detach_Item));
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_feed_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int feed_codigo
		{
			get
			{
				return this._feed_codigo;
			}
			set
			{
				if ((this._feed_codigo != value))
				{
					this.Onfeed_codigoChanging(value);
					this.SendPropertyChanging();
					this._feed_codigo = value;
					this.SendPropertyChanged("feed_codigo");
					this.Onfeed_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_feed_descricao", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string feed_descricao
		{
			get
			{
				return this._feed_descricao;
			}
			set
			{
				if ((this._feed_descricao != value))
				{
					this.Onfeed_descricaoChanging(value);
					this.SendPropertyChanging();
					this._feed_descricao = value;
					this.SendPropertyChanged("feed_descricao");
					this.Onfeed_descricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_feed_qt_nao_lidos", DbType="Int NOT NULL")]
		public int feed_qt_nao_lidos
		{
			get
			{
				return this._feed_qt_nao_lidos;
			}
			set
			{
				if ((this._feed_qt_nao_lidos != value))
				{
					this.Onfeed_qt_nao_lidosChanging(value);
					this.SendPropertyChanging();
					this._feed_qt_nao_lidos = value;
					this.SendPropertyChanged("feed_qt_nao_lidos");
					this.Onfeed_qt_nao_lidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_codigo", DbType="Int NOT NULL")]
		public int cat_codigo
		{
			get
			{
				return this._cat_codigo;
			}
			set
			{
				if ((this._cat_codigo != value))
				{
					if (this._Categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncat_codigoChanging(value);
					this.SendPropertyChanging();
					this._cat_codigo = value;
					this.SendPropertyChanged("cat_codigo");
					this.Oncat_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Feed_Item", Storage="_Item", ThisKey="feed_codigo", OtherKey="feed_codigo")]
		public EntitySet<Item> Item
		{
			get
			{
				return this._Item;
			}
			set
			{
				this._Item.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Feed", Storage="_Categoria", ThisKey="cat_codigo", OtherKey="cat_codigo", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Feed.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Feed.Add(this);
						this._cat_codigo = value.cat_codigo;
					}
					else
					{
						this._cat_codigo = default(int);
					}
					this.SendPropertyChanged("Categoria");
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
		
		private void attach_Item(Item entity)
		{
			this.SendPropertyChanging();
			entity.Feed = this;
		}
		
		private void detach_Item(Item entity)
		{
			this.SendPropertyChanging();
			entity.Feed = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _item_codigo;
		
		private string _item_link;
		
		private string _item_titulo;
		
		private System.Nullable<bool> _item_lido;
		
		private string _item_conteudo;
		
		private System.Nullable<System.DateTime> _item_dthr;
		
		private System.Nullable<int> _feed_codigo;
		
		private EntityRef<Feed> _Feed;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onitem_codigoChanging(int value);
    partial void Onitem_codigoChanged();
    partial void Onitem_linkChanging(string value);
    partial void Onitem_linkChanged();
    partial void Onitem_tituloChanging(string value);
    partial void Onitem_tituloChanged();
    partial void Onitem_lidoChanging(System.Nullable<bool> value);
    partial void Onitem_lidoChanged();
    partial void Onitem_conteudoChanging(string value);
    partial void Onitem_conteudoChanged();
    partial void Onitem_dthrChanging(System.Nullable<System.DateTime> value);
    partial void Onitem_dthrChanged();
    partial void Onfeed_codigoChanging(System.Nullable<int> value);
    partial void Onfeed_codigoChanged();
    #endregion
		
		public Item()
		{
			this._Feed = default(EntityRef<Feed>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int item_codigo
		{
			get
			{
				return this._item_codigo;
			}
			set
			{
				if ((this._item_codigo != value))
				{
					this.Onitem_codigoChanging(value);
					this.SendPropertyChanging();
					this._item_codigo = value;
					this.SendPropertyChanged("item_codigo");
					this.Onitem_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_link", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string item_link
		{
			get
			{
				return this._item_link;
			}
			set
			{
				if ((this._item_link != value))
				{
					this.Onitem_linkChanging(value);
					this.SendPropertyChanging();
					this._item_link = value;
					this.SendPropertyChanged("item_link");
					this.Onitem_linkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_titulo", DbType="NVarChar(200)")]
		public string item_titulo
		{
			get
			{
				return this._item_titulo;
			}
			set
			{
				if ((this._item_titulo != value))
				{
					this.Onitem_tituloChanging(value);
					this.SendPropertyChanging();
					this._item_titulo = value;
					this.SendPropertyChanged("item_titulo");
					this.Onitem_tituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_lido", DbType="Bit")]
		public System.Nullable<bool> item_lido
		{
			get
			{
				return this._item_lido;
			}
			set
			{
				if ((this._item_lido != value))
				{
					this.Onitem_lidoChanging(value);
					this.SendPropertyChanging();
					this._item_lido = value;
					this.SendPropertyChanged("item_lido");
					this.Onitem_lidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_conteudo", DbType="NVarChar(MAX)")]
		public string item_conteudo
		{
			get
			{
				return this._item_conteudo;
			}
			set
			{
				if ((this._item_conteudo != value))
				{
					this.Onitem_conteudoChanging(value);
					this.SendPropertyChanging();
					this._item_conteudo = value;
					this.SendPropertyChanged("item_conteudo");
					this.Onitem_conteudoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_dthr", DbType="DateTime")]
		public System.Nullable<System.DateTime> item_dthr
		{
			get
			{
				return this._item_dthr;
			}
			set
			{
				if ((this._item_dthr != value))
				{
					this.Onitem_dthrChanging(value);
					this.SendPropertyChanging();
					this._item_dthr = value;
					this.SendPropertyChanged("item_dthr");
					this.Onitem_dthrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_feed_codigo", DbType="Int")]
		public System.Nullable<int> feed_codigo
		{
			get
			{
				return this._feed_codigo;
			}
			set
			{
				if ((this._feed_codigo != value))
				{
					if (this._Feed.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onfeed_codigoChanging(value);
					this.SendPropertyChanging();
					this._feed_codigo = value;
					this.SendPropertyChanged("feed_codigo");
					this.Onfeed_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Feed_Item", Storage="_Feed", ThisKey="feed_codigo", OtherKey="feed_codigo", IsForeignKey=true)]
		public Feed Feed
		{
			get
			{
				return this._Feed.Entity;
			}
			set
			{
				Feed previousValue = this._Feed.Entity;
				if (((previousValue != value) 
							|| (this._Feed.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Feed.Entity = null;
						previousValue.Item.Remove(this);
					}
					this._Feed.Entity = value;
					if ((value != null))
					{
						value.Item.Add(this);
						this._feed_codigo = value.feed_codigo;
					}
					else
					{
						this._feed_codigo = default(Nullable<int>);
					}
					this.SendPropertyChanged("Feed");
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
