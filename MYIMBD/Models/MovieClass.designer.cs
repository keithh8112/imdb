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

namespace MYIMBD.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dccmoviestorage")]
	public partial class MovieClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFavoriteMovy(FavoriteMovy instance);
    partial void UpdateFavoriteMovy(FavoriteMovy instance);
    partial void DeleteFavoriteMovy(FavoriteMovy instance);
    partial void InsertNewReleaseMovy(NewReleaseMovy instance);
    partial void UpdateNewReleaseMovy(NewReleaseMovy instance);
    partial void DeleteNewReleaseMovy(NewReleaseMovy instance);
    partial void InsertWantToSeeMovy(WantToSeeMovy instance);
    partial void UpdateWantToSeeMovy(WantToSeeMovy instance);
    partial void DeleteWantToSeeMovy(WantToSeeMovy instance);
    #endregion
		
		public MovieClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dccmoviestorageConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MovieClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<FavoriteMovy> FavoriteMovies
		{
			get
			{
				return this.GetTable<FavoriteMovy>();
			}
		}
		
		public System.Data.Linq.Table<NewReleaseMovy> NewReleaseMovies
		{
			get
			{
				return this.GetTable<NewReleaseMovy>();
			}
		}
		
		public System.Data.Linq.Table<WantToSeeMovy> WantToSeeMovies
		{
			get
			{
				return this.GetTable<WantToSeeMovy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FavoriteMovies")]
	public partial class FavoriteMovy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_Id;
		
		private string _Title;
		
		private string _Year;
		
		private string _Rated;
		
		private string _Released;
		
		private string _Runtime;
		
		private string _Genre;
		
		private string _Plot;
		
		private string _Director;
		
		private string _Writer;
		
		private string _IMDbRating;
		
		private string _PosterUrl;
		
		private string _Url;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IdChanging(int value);
    partial void OnP_IdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnYearChanging(string value);
    partial void OnYearChanged();
    partial void OnRatedChanging(string value);
    partial void OnRatedChanged();
    partial void OnReleasedChanging(string value);
    partial void OnReleasedChanged();
    partial void OnRuntimeChanging(string value);
    partial void OnRuntimeChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnPlotChanging(string value);
    partial void OnPlotChanged();
    partial void OnDirectorChanging(string value);
    partial void OnDirectorChanged();
    partial void OnWriterChanging(string value);
    partial void OnWriterChanged();
    partial void OnIMDbRatingChanging(string value);
    partial void OnIMDbRatingChanged();
    partial void OnPosterUrlChanging(string value);
    partial void OnPosterUrlChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    #endregion
		
		public FavoriteMovy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int P_Id
		{
			get
			{
				return this._P_Id;
			}
			set
			{
				if ((this._P_Id != value))
				{
					this.OnP_IdChanging(value);
					this.SendPropertyChanging();
					this._P_Id = value;
					this.SendPropertyChanged("P_Id");
					this.OnP_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(MAX)")]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rated", DbType="NVarChar(MAX)")]
		public string Rated
		{
			get
			{
				return this._Rated;
			}
			set
			{
				if ((this._Rated != value))
				{
					this.OnRatedChanging(value);
					this.SendPropertyChanging();
					this._Rated = value;
					this.SendPropertyChanged("Rated");
					this.OnRatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Released", DbType="NVarChar(MAX)")]
		public string Released
		{
			get
			{
				return this._Released;
			}
			set
			{
				if ((this._Released != value))
				{
					this.OnReleasedChanging(value);
					this.SendPropertyChanging();
					this._Released = value;
					this.SendPropertyChanged("Released");
					this.OnReleasedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Runtime", DbType="NVarChar(MAX)")]
		public string Runtime
		{
			get
			{
				return this._Runtime;
			}
			set
			{
				if ((this._Runtime != value))
				{
					this.OnRuntimeChanging(value);
					this.SendPropertyChanging();
					this._Runtime = value;
					this.SendPropertyChanged("Runtime");
					this.OnRuntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(MAX)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plot", DbType="NVarChar(MAX)")]
		public string Plot
		{
			get
			{
				return this._Plot;
			}
			set
			{
				if ((this._Plot != value))
				{
					this.OnPlotChanging(value);
					this.SendPropertyChanging();
					this._Plot = value;
					this.SendPropertyChanged("Plot");
					this.OnPlotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Director", DbType="NVarChar(MAX)")]
		public string Director
		{
			get
			{
				return this._Director;
			}
			set
			{
				if ((this._Director != value))
				{
					this.OnDirectorChanging(value);
					this.SendPropertyChanging();
					this._Director = value;
					this.SendPropertyChanged("Director");
					this.OnDirectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Writer", DbType="NVarChar(MAX)")]
		public string Writer
		{
			get
			{
				return this._Writer;
			}
			set
			{
				if ((this._Writer != value))
				{
					this.OnWriterChanging(value);
					this.SendPropertyChanging();
					this._Writer = value;
					this.SendPropertyChanged("Writer");
					this.OnWriterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMDbRating", DbType="NVarChar(MAX)")]
		public string IMDbRating
		{
			get
			{
				return this._IMDbRating;
			}
			set
			{
				if ((this._IMDbRating != value))
				{
					this.OnIMDbRatingChanging(value);
					this.SendPropertyChanging();
					this._IMDbRating = value;
					this.SendPropertyChanged("IMDbRating");
					this.OnIMDbRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PosterUrl", DbType="NVarChar(MAX)")]
		public string PosterUrl
		{
			get
			{
				return this._PosterUrl;
			}
			set
			{
				if ((this._PosterUrl != value))
				{
					this.OnPosterUrlChanging(value);
					this.SendPropertyChanging();
					this._PosterUrl = value;
					this.SendPropertyChanged("PosterUrl");
					this.OnPosterUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX)")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NewReleaseMovies")]
	public partial class NewReleaseMovy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_Id;
		
		private string _Title;
		
		private string _Year;
		
		private string _Rated;
		
		private string _Released;
		
		private string _Runtime;
		
		private string _Genre;
		
		private string _Plot;
		
		private string _Director;
		
		private string _Writer;
		
		private string _IMDbRating;
		
		private string _PosterUrl;
		
		private string _Url;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IdChanging(int value);
    partial void OnP_IdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnYearChanging(string value);
    partial void OnYearChanged();
    partial void OnRatedChanging(string value);
    partial void OnRatedChanged();
    partial void OnReleasedChanging(string value);
    partial void OnReleasedChanged();
    partial void OnRuntimeChanging(string value);
    partial void OnRuntimeChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnPlotChanging(string value);
    partial void OnPlotChanged();
    partial void OnDirectorChanging(string value);
    partial void OnDirectorChanged();
    partial void OnWriterChanging(string value);
    partial void OnWriterChanged();
    partial void OnIMDbRatingChanging(string value);
    partial void OnIMDbRatingChanged();
    partial void OnPosterUrlChanging(string value);
    partial void OnPosterUrlChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    #endregion
		
		public NewReleaseMovy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int P_Id
		{
			get
			{
				return this._P_Id;
			}
			set
			{
				if ((this._P_Id != value))
				{
					this.OnP_IdChanging(value);
					this.SendPropertyChanging();
					this._P_Id = value;
					this.SendPropertyChanged("P_Id");
					this.OnP_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(MAX)")]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rated", DbType="NVarChar(MAX)")]
		public string Rated
		{
			get
			{
				return this._Rated;
			}
			set
			{
				if ((this._Rated != value))
				{
					this.OnRatedChanging(value);
					this.SendPropertyChanging();
					this._Rated = value;
					this.SendPropertyChanged("Rated");
					this.OnRatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Released", DbType="NVarChar(MAX)")]
		public string Released
		{
			get
			{
				return this._Released;
			}
			set
			{
				if ((this._Released != value))
				{
					this.OnReleasedChanging(value);
					this.SendPropertyChanging();
					this._Released = value;
					this.SendPropertyChanged("Released");
					this.OnReleasedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Runtime", DbType="NVarChar(MAX)")]
		public string Runtime
		{
			get
			{
				return this._Runtime;
			}
			set
			{
				if ((this._Runtime != value))
				{
					this.OnRuntimeChanging(value);
					this.SendPropertyChanging();
					this._Runtime = value;
					this.SendPropertyChanged("Runtime");
					this.OnRuntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(MAX)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plot", DbType="NVarChar(MAX)")]
		public string Plot
		{
			get
			{
				return this._Plot;
			}
			set
			{
				if ((this._Plot != value))
				{
					this.OnPlotChanging(value);
					this.SendPropertyChanging();
					this._Plot = value;
					this.SendPropertyChanged("Plot");
					this.OnPlotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Director", DbType="NVarChar(MAX)")]
		public string Director
		{
			get
			{
				return this._Director;
			}
			set
			{
				if ((this._Director != value))
				{
					this.OnDirectorChanging(value);
					this.SendPropertyChanging();
					this._Director = value;
					this.SendPropertyChanged("Director");
					this.OnDirectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Writer", DbType="NVarChar(MAX)")]
		public string Writer
		{
			get
			{
				return this._Writer;
			}
			set
			{
				if ((this._Writer != value))
				{
					this.OnWriterChanging(value);
					this.SendPropertyChanging();
					this._Writer = value;
					this.SendPropertyChanged("Writer");
					this.OnWriterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMDbRating", DbType="NVarChar(MAX)")]
		public string IMDbRating
		{
			get
			{
				return this._IMDbRating;
			}
			set
			{
				if ((this._IMDbRating != value))
				{
					this.OnIMDbRatingChanging(value);
					this.SendPropertyChanging();
					this._IMDbRating = value;
					this.SendPropertyChanged("IMDbRating");
					this.OnIMDbRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PosterUrl", DbType="NVarChar(MAX)")]
		public string PosterUrl
		{
			get
			{
				return this._PosterUrl;
			}
			set
			{
				if ((this._PosterUrl != value))
				{
					this.OnPosterUrlChanging(value);
					this.SendPropertyChanging();
					this._PosterUrl = value;
					this.SendPropertyChanged("PosterUrl");
					this.OnPosterUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX)")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WantToSeeMovies")]
	public partial class WantToSeeMovy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_Id;
		
		private string _Title;
		
		private string _Year;
		
		private string _Rated;
		
		private string _Released;
		
		private string _Runtime;
		
		private string _Genre;
		
		private string _Plot;
		
		private string _Director;
		
		private string _Writer;
		
		private string _IMDbRating;
		
		private string _PosterUrl;
		
		private string _Url;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IdChanging(int value);
    partial void OnP_IdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnYearChanging(string value);
    partial void OnYearChanged();
    partial void OnRatedChanging(string value);
    partial void OnRatedChanged();
    partial void OnReleasedChanging(string value);
    partial void OnReleasedChanged();
    partial void OnRuntimeChanging(string value);
    partial void OnRuntimeChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnPlotChanging(string value);
    partial void OnPlotChanged();
    partial void OnDirectorChanging(string value);
    partial void OnDirectorChanged();
    partial void OnWriterChanging(string value);
    partial void OnWriterChanged();
    partial void OnIMDbRatingChanging(string value);
    partial void OnIMDbRatingChanged();
    partial void OnPosterUrlChanging(string value);
    partial void OnPosterUrlChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    #endregion
		
		public WantToSeeMovy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int P_Id
		{
			get
			{
				return this._P_Id;
			}
			set
			{
				if ((this._P_Id != value))
				{
					this.OnP_IdChanging(value);
					this.SendPropertyChanging();
					this._P_Id = value;
					this.SendPropertyChanged("P_Id");
					this.OnP_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(MAX)")]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rated", DbType="NVarChar(MAX)")]
		public string Rated
		{
			get
			{
				return this._Rated;
			}
			set
			{
				if ((this._Rated != value))
				{
					this.OnRatedChanging(value);
					this.SendPropertyChanging();
					this._Rated = value;
					this.SendPropertyChanged("Rated");
					this.OnRatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Released", DbType="NVarChar(MAX)")]
		public string Released
		{
			get
			{
				return this._Released;
			}
			set
			{
				if ((this._Released != value))
				{
					this.OnReleasedChanging(value);
					this.SendPropertyChanging();
					this._Released = value;
					this.SendPropertyChanged("Released");
					this.OnReleasedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Runtime", DbType="NVarChar(MAX)")]
		public string Runtime
		{
			get
			{
				return this._Runtime;
			}
			set
			{
				if ((this._Runtime != value))
				{
					this.OnRuntimeChanging(value);
					this.SendPropertyChanging();
					this._Runtime = value;
					this.SendPropertyChanged("Runtime");
					this.OnRuntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(MAX)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plot", DbType="NVarChar(MAX)")]
		public string Plot
		{
			get
			{
				return this._Plot;
			}
			set
			{
				if ((this._Plot != value))
				{
					this.OnPlotChanging(value);
					this.SendPropertyChanging();
					this._Plot = value;
					this.SendPropertyChanged("Plot");
					this.OnPlotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Director", DbType="NVarChar(MAX)")]
		public string Director
		{
			get
			{
				return this._Director;
			}
			set
			{
				if ((this._Director != value))
				{
					this.OnDirectorChanging(value);
					this.SendPropertyChanging();
					this._Director = value;
					this.SendPropertyChanged("Director");
					this.OnDirectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Writer", DbType="NVarChar(MAX)")]
		public string Writer
		{
			get
			{
				return this._Writer;
			}
			set
			{
				if ((this._Writer != value))
				{
					this.OnWriterChanging(value);
					this.SendPropertyChanging();
					this._Writer = value;
					this.SendPropertyChanged("Writer");
					this.OnWriterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMDbRating", DbType="NVarChar(MAX)")]
		public string IMDbRating
		{
			get
			{
				return this._IMDbRating;
			}
			set
			{
				if ((this._IMDbRating != value))
				{
					this.OnIMDbRatingChanging(value);
					this.SendPropertyChanging();
					this._IMDbRating = value;
					this.SendPropertyChanged("IMDbRating");
					this.OnIMDbRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PosterUrl", DbType="NVarChar(MAX)")]
		public string PosterUrl
		{
			get
			{
				return this._PosterUrl;
			}
			set
			{
				if ((this._PosterUrl != value))
				{
					this.OnPosterUrlChanging(value);
					this.SendPropertyChanging();
					this._PosterUrl = value;
					this.SendPropertyChanged("PosterUrl");
					this.OnPosterUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX)")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
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
