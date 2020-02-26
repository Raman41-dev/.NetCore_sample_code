﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BusinessEntityList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
 
namespace CFMData
{
    [Serializable]
    public partial class BusinessEntityList : List< BusinessEntity>
    {    
        private List<BusinessEntityDTO> _currentDto =null; 
        public List<BusinessEntityDTO> CurrentDTO
        {
            get 
            {
                if (_currentDto==null)
                {
                    _currentDto=new List<BusinessEntityDTO>();
                    foreach (BusinessEntity entity in this)
                    {
                        _currentDto.Add(entity.CurrentDTO);
                    }
                }
                return _currentDto;
			}
            
        }
        #region Contructor(s)

        public BusinessEntityList()
        { 
       //     AllowNew = true;
        }

        #endregion

       

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="BusinessEntityList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="BusinessEntityList"/>.</returns>
        public static BusinessEntityList NewList()
        {
            return new BusinessEntityList();
        }      

        /// <summary>
        /// Returns a <see cref="BusinessEntityList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="businessEntityID">No additional detail available.</param>
        /// <returns>A <see cref="BusinessEntityList"/> object of the specified criteria.</returns>
        public static BusinessEntityList GetByBusinessEntityID(System.Int32 businessEntityID)
        {
            var criteria = new BusinessEntityCriteria{BusinessEntityID = businessEntityID};
            
            
          return  new BusinessEntityList().DataPortal_Fetch(criteria);
        }

        public static BusinessEntityList GetByCriteria(BusinessEntityCriteria criteria)
        {
          return  new BusinessEntityList().DataPortal_Fetch(criteria);
//            return DataPortal.Fetch<BusinessEntityList>(criteria);
        }

        public static BusinessEntityList GetAll()
        {
          return  new BusinessEntityList().DataPortal_Fetch(new BusinessEntityCriteria());
            //return DataPortal.Fetch<BusinessEntityList>(new BusinessEntityCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods
     

     
 
        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BusinessEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessEntity"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BusinessEntity"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BusinessEntityCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BusinessEntityCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessEntity"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BusinessEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BusinessEntity"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessEntity"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BusinessEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessEntity"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
       // partial void OnAddNewCore(ref BusinessEntity item, ref bool cancel);

        #endregion

    }
}