﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'GLEntity.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CFMData
{
    [Serializable]
    public partial class GLEntity 
    {
        #region Contructor(s)

        public GLEntity()
        { /* Require use of factory methods */ }

        #endregion

			public GLEntity  Save()
      {
        if (this.IsNew)
        {
            DataPortal_Insert();
			this.IsNew=false;
        }
        else
        {
            DataPortal_Update();
        }

        return this;
      }
	  
			public bool IsDirty=false;
			public bool IsNew=true;
			#region Properties
		
			private GLEntityDTO _currentDto = null;
			public GLEntityDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _gLEntityIDProperty  ;
			public System.Int32 GLEntityID
			{
				get { return _gLEntityIDProperty; }
				set
				{ 
                 
					if (_gLEntityIDProperty != value){
						IsDirty = true;
					}
					_gLEntityIDProperty=value; 
				}
			}

			private System.Int32 _entityTypeIDProperty  ;
			public System.Int32 EntityTypeID
			{
				get { return _entityTypeIDProperty; }
				set
				{ 
                 
					if (_entityTypeIDProperty != value){
						IsDirty = true;
					}
					_entityTypeIDProperty=value; 
				}
			}

			private System.Boolean _isActiveProperty  ;
			public System.Boolean IsActive
			{
				get { return _isActiveProperty; }
				set
				{ 
                 
					if (_isActiveProperty != value){
						IsDirty = true;
					}
					_isActiveProperty=value; 
				}
			}

			private System.Int32 _createdByProperty  ;
			public System.Int32 CreatedBy
			{
				get { return _createdByProperty; }
				set
				{ 
                 
					if (_createdByProperty != value){
						IsDirty = true;
					}
					_createdByProperty=value; 
				}
			}

			private System.DateTime _createdOnProperty  ;
			public System.DateTime CreatedOn
			{
				get { return _createdOnProperty; }
				set
				{ 
                 
					if (_createdOnProperty != value){
						IsDirty = true;
					}
					_createdOnProperty=value; 
				}
			}

			private System.Int32? _updatedByProperty  = null;
			public System.Int32? UpdatedBy
			{
				get { return _updatedByProperty; }
				set
				{ 
                 
					if (_updatedByProperty != value){
						IsDirty = true;
					}
					_updatedByProperty=value; 
				}
			}

			private System.DateTime? _updatedOnProperty  = null;
			public System.DateTime? UpdatedOn
			{
				get { return _updatedOnProperty; }
				set
				{ 
                 
					if (_updatedOnProperty != value){
						IsDirty = true;
					}
					_updatedOnProperty=value; 
				}
			}

			// ManyToOne
			private bool _createdByApplicationUserPropertyChecked = false;
			private ApplicationUser _createdByApplicationUserProperty = null;
			public ApplicationUser CreatedByApplicationUser
			{
				get
				{
					if(!_createdByApplicationUserPropertyChecked)
					{						
						var criteria = new CFMData.ApplicationUserCriteria {ApplicationUserID = CreatedBy};
						
						_createdByApplicationUserPropertyChecked=true;                       
						_createdByApplicationUserProperty= CFMData.ApplicationUser.GetByApplicationUserID(CreatedBy);
					}                
					return _createdByApplicationUserProperty;
				}
			}

			// ManyToOne
			private bool _gLEntityTypePropertyChecked = false;
			private GLEntityType _gLEntityTypeProperty = null;
			public GLEntityType GLEntityType
			{
				get
				{
					if(!_gLEntityTypePropertyChecked)
					{						
						var criteria = new CFMData.GLEntityTypeCriteria {GLEntityTypeID = EntityTypeID};
						
						_gLEntityTypePropertyChecked=true;                       
						_gLEntityTypeProperty= CFMData.GLEntityType.GetByGLEntityTypeID(EntityTypeID);
					}                
					return _gLEntityTypeProperty;
				}
			}

			// ManyToZeroOrOne
			private bool _updatedByApplicationUserPropertyChecked = false;
			private ApplicationUser _updatedByApplicationUserProperty = null;
			public ApplicationUser UpdatedByApplicationUser
			{
				get
				{
                    if(!UpdatedBy.HasValue) 
					return null;

					if(!_updatedByApplicationUserPropertyChecked)
					{						
						var criteria = new CFMData.ApplicationUserCriteria {};
						if(UpdatedBy.HasValue) criteria.ApplicationUserID = UpdatedBy.Value;
						_updatedByApplicationUserPropertyChecked=true;                       
						_updatedByApplicationUserProperty= CFMData.ApplicationUser.GetByApplicationUserID(UpdatedBy.Value);
					}                
					return _updatedByApplicationUserProperty;
				}
			}

			// OneToMany
			//PropertyInfo<ClientList>
			private bool _clientsPropertyChecked = false;
			private ClientList _clientsProperty = null;
			public ClientList Clients
			{
				get
				{
					if(!_clientsPropertyChecked )
					{
						_clientsPropertyChecked =true; 
						var criteria = new CFMData.ClientCriteria {GLEntityID = GLEntityID};
						                        
						_clientsProperty= CFMData.ClientList.GetByGLEntityID(GLEntityID);
 
					}
					return _clientsProperty;
				}
			}

			// OneToMany
			//PropertyInfo<FinAdministratorList>
			private bool _finAdministratorsPropertyChecked = false;
			private FinAdministratorList _finAdministratorsProperty = null;
			public FinAdministratorList FinAdministrators
			{
				get
				{
					if(!_finAdministratorsPropertyChecked )
					{
						_finAdministratorsPropertyChecked =true; 
						var criteria = new CFMData.FinAdministratorCriteria {GLEntityID = GLEntityID};
						                        
						_finAdministratorsProperty= CFMData.FinAdministratorList.GetByGLEntityID(GLEntityID);
 
					}
					return _finAdministratorsProperty;
				}
			}

			// ZeroOrOneToMany
			//PropertyInfo<GlList>
			private bool _glsPropertyChecked = false;
			private GlList _glsProperty = null;
			public GlList Gls
			{
				get
				{
					if(!_glsPropertyChecked )
					{
						_glsPropertyChecked =true; 
						var criteria = new CFMData.GlCriteria {GLCostCentreEntityID = GLEntityID};
						                        
						_glsProperty= CFMData.GlList.GetByGLCostCentreEntityID(GLEntityID);
 
					}
					return _glsProperty;
				}
			}

			// OneToMany
			//PropertyInfo<GLAccountList>
			private bool _gLAccountsPropertyChecked = false;
			private GLAccountList _gLAccountsProperty = null;
			public GLAccountList GLAccounts
			{
				get
				{
					if(!_gLAccountsPropertyChecked )
					{
						_gLAccountsPropertyChecked =true; 
						var criteria = new CFMData.GLAccountCriteria {GLEntityID = GLEntityID};
						                        
						_gLAccountsProperty= CFMData.GLAccountList.GetByGLEntityID(GLEntityID);
 
					}
					return _gLAccountsProperty;
				}
			}

			// OneToMany
			//PropertyInfo<HomeList>
			private bool _homesPropertyChecked = false;
			private HomeList _homesProperty = null;
			public HomeList Homes
			{
				get
				{
					if(!_homesPropertyChecked )
					{
						_homesPropertyChecked =true; 
						var criteria = new CFMData.HomeCriteria {GLEntityID = GLEntityID};
						                        
						_homesProperty= CFMData.HomeList.GetByGLEntityID(GLEntityID);
 
					}
					return _homesProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		
			 
			if(_clientsPropertyChecked)
			{
					if(_clientsProperty != null)
					{
						foreach (Client childObj in _clientsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_finAdministratorsPropertyChecked)
			{
					if(_finAdministratorsProperty != null)
					{
						foreach (FinAdministrator childObj in _finAdministratorsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_glsPropertyChecked)
			{
					if(_glsProperty != null)
					{
						foreach (Gl childObj in _glsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_gLAccountsPropertyChecked)
			{
					if(_gLAccountsProperty != null)
					{
						foreach (GLAccount childObj in _gLAccountsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_homesPropertyChecked)
			{
					if(_homesProperty != null)
					{
						foreach (Home childObj in _homesProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 



			return false;
		}

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="GLEntity"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="GLEntity"/>.</returns>    
        public static GLEntity NewGLEntity()
        {
            GLEntity obj=new GLEntity();

            return obj;
        }

			public static GLEntity GetGLEntity(Func<IDataReader, GLEntity> rowParser,SqlDataReader reader)
			{
				GLEntity obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="GLEntity"/> object of the specified criteria. 
        /// </summary>
        /// <param name="gLEntityID">No additional detail available.</param>
        /// <returns>A <see cref="GLEntity"/> object of the specified criteria.</returns>
        public static GLEntity GetByGLEntityID(System.Int32 gLEntityID)
        {
            var criteria = new GLEntityCriteria {GLEntityID = gLEntityID};
            
            
          return  new GLEntity().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="GLEntity"/> object of the specified criteria. 
        /// </summary>
        /// <param name="createdBy">No additional detail available.</param>
        /// <returns>A <see cref="GLEntity"/> object of the specified criteria.</returns>
        public static GLEntity GetByCreatedBy(System.Int32 createdBy)
        {
            var criteria = new GLEntityCriteria {CreatedBy = createdBy};
            
            
          return  new GLEntity().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="GLEntity"/> object of the specified criteria. 
        /// </summary>
        /// <param name="entityTypeID">No additional detail available.</param>
        /// <returns>A <see cref="GLEntity"/> object of the specified criteria.</returns>
        public static GLEntity GetByEntityTypeID(System.Int32 entityTypeID)
        {
            var criteria = new GLEntityCriteria {EntityTypeID = entityTypeID};
            
            
          return  new GLEntity().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="GLEntity"/> object of the specified criteria. 
        /// </summary>
        /// <param name="updatedBy">No additional detail available.</param>
        /// <returns>A <see cref="GLEntity"/> object of the specified criteria.</returns>
        public static GLEntity GetByUpdatedBy(System.Int32? updatedBy)
        {
            var criteria = new GLEntityCriteria {};
                            if(updatedBy.HasValue) criteria.UpdatedBy = updatedBy.Value;
            
          return  new GLEntity().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteGLEntity(System.Int32 gLEntityID)
        {
            var criteria = new GLEntityCriteria {GLEntityID = gLEntityID};
            
            
             new GLEntity().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="GLEntityCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(GLEntityCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="GLEntityCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(GLEntityCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="GLEntityCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(GLEntityCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="GLEntity"/> object. 
        /// </summary>
        partial void OnChildInserting(ApplicationUser applicationUser, GLEntityType gLEntityType, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="GLEntity"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildUpdating(ApplicationUser applicationUser, GLEntityType gLEntityType, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="GLEntityCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(GLEntityCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="GLEntityCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(GLEntityCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the GLEntity table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="GLEntity"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static GLEntity Exists(GLEntityCriteria criteria)
        {
			try
			{
					
				return new GLEntity().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}