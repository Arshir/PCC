/*----------------------------------------------------------------------------------------------------------*/
/* Telligent (GH) Systems CodeGenerator (written by Stephen Adjei-Kyei.)                                   */
/*                                                                                                         */
/* File was generated using Telligent (GH) System's Code Generator.                                        */
/*                                                                                                         */
/* Date Generated: 7/7/2015 1:22:22 PM                                                                    */
/*                                                                                                         */
/* www.telligentgh.com                                                                                     */
/*---------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

/// <summary>
/// Data Access Layer Class for the [dbo].[inbox_notif] Database Table
/// Business Logic to Access this Class will be in the InboxNotif_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class InboxNotif
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[inbox_notif]";
	
		#endregion
	
	
		#region Fields
		private System.Int64? _id;
		private System.String _keyword;
		private System.String _from;
		private System.String _message;
		private System.DateTime? _receivedTime;
		private System.String _status;
		private System.DateTime? _recordedTime;
		private System.Boolean? _readStatus;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.Int64? Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}
		
		public System.String Keyword
		{
			get
			{
				return _keyword;
			}
			set
			{
				_keyword = value;
			}
		}
		
		public System.String From
		{
			get
			{
				return _from;
			}
			set
			{
				_from = value;
			}
		}
		
		public System.String Message
		{
			get
			{
				return _message;
			}
			set
			{
				_message = value;
			}
		}
		
		public System.DateTime? ReceivedTime
		{
			get
			{
				return _receivedTime;
			}
			set
			{
				_receivedTime = value;
			}
		}
		
		public System.String Status
		{
			get
			{
				return _status;
			}
			set
			{
				_status = value;
			}
		}
		
		public System.DateTime? RecordedTime
		{
			get
			{
				return _recordedTime;
			}
			set
			{
				_recordedTime = value;
			}
		}
		
		public System.Boolean? ReadStatus
		{
			get
			{
				return _readStatus;
			}
			set
			{
				_readStatus = value;
			}
		}
		
		public System.String  ORDERBY_FIELD
		{
			get
			{
				return _ORDERBY_FIELD;
			}
			set
			{
				 _ORDERBY_FIELD = value;
			}
		}
		
		#endregion
	
	
		#region Methods
	
	
		#region Mapping Methods
	
		protected void MapTo(DataSet ds)
		{
			DataRow dr;
	
	
			if (ds == null)
				ds = new DataSet();
	
			if (ds.Tables["TABLE_NAME"] == null)
				ds.Tables.Add(TABLE_NAME);
	
			ds.Tables[TABLE_NAME].Columns.Add("ID", typeof(System.Int64) );
			ds.Tables[TABLE_NAME].Columns.Add("Keyword", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("from", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("received_time", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("status", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("recorded_time", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("read_status", typeof(System.Boolean) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (Keyword == null)
				dr["Keyword"] = DBNull.Value;
			else
				dr["Keyword"] = Keyword;
	
			if (From == null)
				dr["from"] = DBNull.Value;
			else
				dr["from"] = From;
	
			if (Message == null)
				dr["message"] = DBNull.Value;
			else
				dr["message"] = Message;
	
			if (ReceivedTime == null)
				dr["received_time"] = DBNull.Value;
			else
				dr["received_time"] = ReceivedTime;
	
			if (Status == null)
				dr["status"] = DBNull.Value;
			else
				dr["status"] = Status;
	
			if (RecordedTime == null)
				dr["recorded_time"] = DBNull.Value;
			else
				dr["recorded_time"] = RecordedTime;
	
			if (ReadStatus == null)
				dr["read_status"] = DBNull.Value;
			else
				dr["read_status"] = ReadStatus;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt64(dr["ID"]) : Id = null;
			Keyword = dr["Keyword"] != DBNull.Value ? Convert.ToString(dr["Keyword"]) : Keyword = null;
			From = dr["from"] != DBNull.Value ? Convert.ToString(dr["from"]) : From = null;
			Message = dr["message"] != DBNull.Value ? Convert.ToString(dr["message"]) : Message = null;
			ReceivedTime = dr["received_time"] != DBNull.Value ? Convert.ToDateTime(dr["received_time"]) : ReceivedTime = null;
			Status = dr["status"] != DBNull.Value ? Convert.ToString(dr["status"]) : Status = null;
			RecordedTime = dr["recorded_time"] != DBNull.Value ? Convert.ToDateTime(dr["recorded_time"]) : RecordedTime = null;
			ReadStatus = dr["read_status"] != DBNull.Value ? Convert.ToBoolean(dr["read_status"]) : ReadStatus = null;
		}
	
		public static InboxNotif[] MapFrom(DataSet ds)
		{
			List<InboxNotif> objects;
	
	
			// Initialise Collection.
			objects = new List<InboxNotif>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[inbox_notif] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[inbox_notif] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				InboxNotif instance = new InboxNotif();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static InboxNotif Get(System.Int64 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			InboxNotif instance;
	
	
			instance = new InboxNotif();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get InboxNotif ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.Int64? id, System.String keyword, System.String from, System.String message, System.DateTime? receivedTime, System.String status, System.DateTime? recordedTime, System.Boolean? readStatus, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, keyword, from, message, receivedTime, status, recordedTime, readStatus);
	
			if (transaction == null)
				db.ExecuteScalar(dbCommand);
			else
				db.ExecuteScalar(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.Int64? id, System.String keyword, System.String from, System.String message, System.DateTime? receivedTime, System.String status, System.DateTime? recordedTime, System.Boolean? readStatus)
		{
			Insert(id, keyword, from, message, receivedTime, status, recordedTime, readStatus, null);
		}
	/// <summary>
	/// Insert current InboxNotif to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Id, Keyword, From, Message, ReceivedTime, Status, RecordedTime, ReadStatus, transaction);
		}
	
	/// <summary>
	/// Insert current InboxNotif to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int64? id, System.String keyword, System.String from, System.String message, System.DateTime? receivedTime, System.String status, System.DateTime? recordedTime, System.Boolean? readStatus, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@keyword"].Value = keyword;
			dbCommand.Parameters["@from"].Value = from;
			dbCommand.Parameters["@message"].Value = message;
			dbCommand.Parameters["@receivedTime"].Value = receivedTime;
			dbCommand.Parameters["@status"].Value = status;
			dbCommand.Parameters["@recordedTime"].Value = recordedTime;
			dbCommand.Parameters["@readStatus"].Value = readStatus;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int64? id, System.String keyword, System.String from, System.String message, System.DateTime? receivedTime, System.String status, System.DateTime? recordedTime, System.Boolean? readStatus)
		{
			Update(id, keyword, from, message, receivedTime, status, recordedTime, readStatus, null);
		}
	
	public static void Update(InboxNotif inboxNotif)
	{
	inboxNotif.Update();
	}
	
	public static void Update(InboxNotif inboxNotif, DbTransaction transaction)
	{
	inboxNotif.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Update(DbTransaction transaction)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@keyword"].SourceColumn = "Keyword";
			dbCommand.Parameters["@from"].SourceColumn = "from";
			dbCommand.Parameters["@message"].SourceColumn = "message";
			dbCommand.Parameters["@receivedTime"].SourceColumn = "received_time";
			dbCommand.Parameters["@status"].SourceColumn = "status";
			dbCommand.Parameters["@recordedTime"].SourceColumn = "recorded_time";
			dbCommand.Parameters["@readStatus"].SourceColumn = "read_status";
	
			ds = new DataSet();
			this.MapTo( ds );
			ds.AcceptChanges();
			ds.Tables[0].Rows[0].SetModified();
			if (transaction == null)
				db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
			else
				db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
			return;
		}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
		public void Update()
		{
			this.Update((DbTransaction)null);
		}
		#endregion
	
	
		#region DELETE
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
		public static void Delete(System.Int64? id, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Execute.
	if (transaction != null)
	{
		db.ExecuteNonQuery(dbCommand, transaction);
	}
	else
	{
		db.ExecuteNonQuery(dbCommand);
	}
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public static void Delete(System.Int64? id)
	{
	Delete(
	id);
	}
	
	/// <summary>
	/// Delete current InboxNotif from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, Id);
	
			// Execute.
	if (transaction != null)
	{
		db.ExecuteNonQuery(dbCommand, transaction);
	}
	else
	{
		db.ExecuteNonQuery(dbCommand);
	}
		}
	
	/// <summary>
	/// Delete current InboxNotif from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static InboxNotif[] Search(System.Int64? id, System.String keyword, System.String from, System.String message, System.DateTime? receivedTime, System.String status, System.DateTime? recordedTime, System.Boolean? readStatus, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, keyword, from, message, receivedTime, status, recordedTime, readStatus, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return InboxNotif.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static InboxNotif[] Search(InboxNotif searchObject)
		{
			return Search ( searchObject.Id, searchObject.Keyword, searchObject.From, searchObject.Message, searchObject.ReceivedTime, searchObject.Status, searchObject.RecordedTime, searchObject.ReadStatus, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all InboxNotif objects.
		/// </summary>
		/// <returns>List of all InboxNotif objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static InboxNotif[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static InboxNotif[] SearchExact(System.Int64? id, System.String keyword, System.String from, System.String message, System.DateTime? receivedTime, System.String status, System.DateTime? recordedTime, System.Boolean? readStatus, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].InboxNotif_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, keyword, from, message, receivedTime, status, recordedTime, readStatus, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return InboxNotif.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static InboxNotif[] SearchExact(InboxNotif searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.Keyword, searchObject.From, searchObject.Message, searchObject.ReceivedTime, searchObject.Status, searchObject.RecordedTime, searchObject.ReadStatus, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all InboxNotif objects.
		/// </summary>
		/// <returns>List of all InboxNotif objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static InboxNotif[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static InboxNotif[] CustomSelect(System.String SqlQuery)
		{
			DataSet ds;
			Database db;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			dbCommand = db.GetSqlStringCommand(SqlQuery);
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return InboxNotif.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
		#endregion
	
	
		#region DATATABLESELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static DataTable CustomDataTableSelect(System.String SqlQuery)
		{
			DataSet ds;
			Database db;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			dbCommand = db.GetSqlStringCommand(SqlQuery);
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ds.Tables[0];
		}
	
		#endregion
	
	
		#endregion
	
	
		#endregion
	
	
	}
	}
	
