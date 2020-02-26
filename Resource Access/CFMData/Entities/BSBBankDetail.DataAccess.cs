﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BSBBankDetail.cs'.
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
	public partial class BSBBankDetail
	{
    
		private BSBBankDetail DataPortal_Fetch(BSBBankDetailCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_BSBBankDetail_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_BankCodeHasValue", criteria.BankCodeHasValue);
                command.Parameters.AddWithValue("@p_BankNameHasValue", criteria.BankNameHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<BSBBankDetail>();                       
						if(reader.Read())
						{
							return GetBSBBankDetail(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.BSBBankDetail' using the following criteria: {0}.", criteria));
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
				
				using(var command = new SqlCommand("[dbo].[spCFM_BSBBankDetail_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_BSBBankDetailID", this.BSBBankDetailID);
                command.Parameters["@p_BSBBankDetailID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BankName", ADOHelper.NullCheck(this.BankName));
					command.ExecuteNonQuery();                  
					_bSBBankDetailIDProperty=(System.Int32)command.Parameters["@p_BSBBankDetailID"].Value;
                    
				}
                
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
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				SqlTransaction trans = connection.BeginTransaction();
				try
				{
				using(var command = new SqlCommand("[dbo].[spCFM_BSBBankDetail_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_BSBBankDetailID", this.BSBBankDetailID);
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BankName", ADOHelper.NullCheck(this.BankName));
					//result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
					int result = command.ExecuteNonQuery();
					if (result == 0)
						throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

				}
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
		protected   void UpdateChildren(BSBBankDetail parent,SqlConnection connection,SqlTransaction trans)
		{
		
		

		}

		protected   void DataPortal_DeleteSelf()
		{
			bool cancel = false;
			OnSelfDeleting(ref cancel);
			if (cancel) return;            
			DataPortal_Delete(new BSBBankDetailCriteria (BSBBankDetailID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(BSBBankDetailCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_BSBBankDetail_Delete]", connection))
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
        ///    CSLA editable child business object of type <see cref="BSBBankDetail"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BSBBankDetail_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BSBBankDetailID", this.BSBBankDetailID);
                command.Parameters["@p_BSBBankDetailID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BankName", ADOHelper.NullCheck(this.BankName));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _bSBBankDetailIDProperty=(System.Int32)command.Parameters["@p_BSBBankDetailID"].Value;
            }

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        /// <summary>
        /// Updates the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="BSBBankDetail"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BSBBankDetail_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BSBBankDetailID", this.BSBBankDetailID);
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BankName", ADOHelper.NullCheck(this.BankName));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            OnChildUpdated();
        }
        #endregion

        /// <summary>
        /// Deletes the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="BSBBankDetail"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new BSBBankDetailCriteria (BSBBankDetailID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  BSBBankDetailDTO dt=new BSBBankDetailDTO();
			dt.BSBBankDetailID =this.BSBBankDetailID ;
			dt.BankCode =this.BankCode ;
			dt.BankName =this.BankName ;
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
                LoadProperty(_bSBBankDetailIDProperty, reader["BSBBankDetailID"]);
                LoadProperty(_bankCodeProperty, reader["BankCode"]);
                LoadProperty(_bankNameProperty, reader["BankName"]);
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
 