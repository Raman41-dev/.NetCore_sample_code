﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'SystemRole.cs'.
//
//     Template: EditableRoot.DataAccess.StoredProcedures.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
 using Dapper;

namespace CFMData
{
	public partial class SystemRole
	{
    
		private SystemRole DataPortal_Fetch(SystemRoleCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_SystemRole_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<SystemRole>();                       
						if(reader.Read())
						{
							return GetSystemRole(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.SystemRole' using the following criteria: {0}.", criteria));
					}
				}
			}
			OnFetched();
		}

       // [Transactional(TransactionalTypes.TransactionScope)]
		protected   void DataPortal_Insert()
		{
			bool cancel = false;
			OnInserting(ref cancel);
			if (cancel) return;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				SqlTransaction trans = connection.BeginTransaction();
				try
				{
				
				using(var command = new SqlCommand("[dbo].[spCFM_SystemRole_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_SystemRoleID", this.SystemRoleID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", this.Name);
                command.Parameters.AddWithValue("@p_SystemRoleTypeID", this.SystemRoleTypeID);
					command.ExecuteNonQuery();                  
                    
				}
                
				_originalSystemRoleIDProperty= this.SystemRoleID;
				UpdateChildren(this, connection,trans);
				
				trans.Commit();
			}
			catch(Exception ex)
			{
				trans.Rollback();
				throw;
			}
			
		}
			

			OnInserted();

		}

       // [Transactional(TransactionalTypes.TransactionScope)]
		protected   void DataPortal_Update()
		{
			bool cancel = false;
			OnUpdating(ref cancel);
			if (cancel) return;
            if(OriginalSystemRoleID != SystemRoleID)
            {
                // Insert new child.
				SystemRole item = new SystemRole {SystemRoleID = SystemRoleID, Code = Code, Name = Name, SystemRoleTypeID = SystemRoleTypeID};
				
				item.DataPortal_Update();

                // Mark editable child lists as dirty. This code may need to be updated to one-to-one relationships.
				foreach(ApplicationRole itemToUpdate in ApplicationRoles)
				{
                itemToUpdate.SystemRoleID = SystemRoleID;
				}

				// Create a new connection.
				using (var connection = new SqlConnection(ADOHelper.ConnectionString))
				{
					connection.Open();
					SqlTransaction trans = connection.BeginTransaction();
					try
					{
						UpdateChildren(this, connection,trans);
						trans.Commit();
					}
					catch(Exception ex)
					{
						trans.Rollback();
						throw;
					}
					
					//FieldManager.UpdateChildren(this, connection);
				}
				// Delete the old.
				var criteria = new SystemRoleCriteria {SystemRoleID = OriginalSystemRoleID};
				
				DataPortal_Delete(criteria);

				// Mark the original as the new one.
				OriginalSystemRoleID = SystemRoleID;
				OnUpdated();

				return;
			}

			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				SqlTransaction trans = connection.BeginTransaction();
				try
				{
				using(var command = new SqlCommand("[dbo].[spCFM_SystemRole_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_OriginalSystemRoleID", this.OriginalSystemRoleID);
                command.Parameters.AddWithValue("@p_SystemRoleID", this.SystemRoleID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", this.Name);
                command.Parameters.AddWithValue("@p_SystemRoleTypeID", this.SystemRoleTypeID);
					//result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
					int result = command.ExecuteNonQuery();
					if (result == 0)
						throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

					_originalSystemRoleIDProperty= this.SystemRoleID;
				}
				UpdateChildren(this, connection,trans);
				//FieldManager.UpdateChildren(this, connection);
				trans.Commit();
			}
			catch(Exception ex)
			{
				trans.Rollback();
				throw;
			}
			
		}

			OnUpdated();
		}
		protected   void UpdateChildren(SystemRole parent,SqlConnection connection,SqlTransaction trans)
		{
		
		
			
			if(_applicationRolesPropertyChecked )
			{
				if(_applicationRolesProperty!=null)
				{
				
					foreach (ApplicationRole obj in _applicationRolesProperty)
					{
						if (obj.IsNew)
						{
							obj.Child_Insert(parent, connection,trans);
						}
						else
						{
							if (obj.IsDirty ||  obj.IsChildDirty())
							{							
								obj.Child_Update(parent, connection,trans);
							}
						}
					}
				}
					
 
			}


		}

		protected   void DataPortal_DeleteSelf()
		{
			bool cancel = false;
			OnSelfDeleting(ref cancel);
			if (cancel) return;            
			DataPortal_Delete(new SystemRoleCriteria (SystemRoleID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(SystemRoleCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_SystemRole_Delete]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
		
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
		}
		
		 #region Child_Insert
        /// <summary>
        /// Inserts data into the data base using the information in the current 
        ///    CSLA editable child business object of type <see cref="SystemRole"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_SystemRole_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_SystemRoleID", this.SystemRoleID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", this.Name);
                command.Parameters.AddWithValue("@p_SystemRoleTypeID", this.SystemRoleTypeID);

                command.ExecuteNonQuery();

                // Update the original non-identity primary key value.
                _originalSystemRoleIDProperty= this.SystemRoleID;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        public void Child_Insert(SystemRoleType systemRoleType, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(systemRoleType, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_SystemRole_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_SystemRoleID", this.SystemRoleID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", this.Name);
                command.Parameters.AddWithValue("@p_SystemRoleTypeID", systemRoleType != null ? systemRoleType.SystemRoleTypeID : this.SystemRoleTypeID);

                command.ExecuteNonQuery();

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(systemRoleType != null && systemRoleType.SystemRoleTypeID != this.SystemRoleTypeID)
                _systemRoleTypeIDProperty= systemRoleType.SystemRoleTypeID;

                // Update the original non-identity primary key value.
                _originalSystemRoleIDProperty= this.SystemRoleID;
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildInserted() and insert this child manually.
            // UpdateChildren(this, null, connection);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        /// <summary>
        /// Updates the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="SystemRole"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_SystemRole_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_OriginalSystemRoleID", this.OriginalSystemRoleID);
                command.Parameters.AddWithValue("@p_SystemRoleID", this.SystemRoleID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", this.Name);
                command.Parameters.AddWithValue("@p_SystemRoleTypeID", this.SystemRoleTypeID);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update non-identity primary key value.
                _systemRoleIDProperty=(System.Int32)command.Parameters["@p_SystemRoleID"].Value;

                // Update non-identity primary key value.
                _originalSystemRoleIDProperty= this.SystemRoleID;
            }

            UpdateChildren(this, connection,trans);

            OnChildUpdated();
        }
 
        public void Child_Update(SystemRoleType systemRoleType, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(systemRoleType, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_SystemRole_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_OriginalSystemRoleID", this.OriginalSystemRoleID);
                command.Parameters.AddWithValue("@p_SystemRoleID", this.SystemRoleID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", this.Name);
                command.Parameters.AddWithValue("@p_SystemRoleTypeID", systemRoleType != null ? systemRoleType.SystemRoleTypeID : this.SystemRoleTypeID);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update non-identity primary key value.
                _systemRoleIDProperty=(System.Int32)command.Parameters["@p_SystemRoleID"].Value;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(systemRoleType != null && systemRoleType.SystemRoleTypeID != this.SystemRoleTypeID)
                    _systemRoleTypeIDProperty= systemRoleType.SystemRoleTypeID;

                // Update non-identity primary key value.
                _originalSystemRoleIDProperty= this.SystemRoleID;
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildUpdated() and update this child manually.
            // UpdateChildren(this, null, connection);

            OnChildUpdated();
        }
        #endregion

        /// <summary>
        /// Deletes the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="SystemRole"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new SystemRoleCriteria (SystemRoleID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  SystemRoleDTO dt=new SystemRoleDTO();
			dt.SystemRoleID =this.SystemRoleID ;
			dt.Code =this.Code ;
			dt.Name =this.Name ;
			dt.SystemRoleTypeID =this.SystemRoleTypeID ;
   //LoadProperty(_currentDto, dt);
  this.CurrentDTO = dt;

		}
		/*
        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_systemRoleIDProperty, reader["SystemRoleID"]);
                LoadProperty(_originalSystemRoleIDProperty, reader["SystemRoleID"]);
                LoadProperty(_codeProperty, reader["Code"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_systemRoleTypeIDProperty, reader["SystemRoleTypeID"]);
            }	
			InitDTO();
            OnMapped();
        }
        
        private void Child_Fetch(SafeDataReader reader)
        {
            Map(reader);
        }
		*/

        #endregion
	}
}
 