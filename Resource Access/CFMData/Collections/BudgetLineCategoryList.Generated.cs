﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BudgetLineCategoryList.cs'.
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
    public partial class BudgetLineCategoryList : List< BudgetLineCategory>
    {    
        private List<BudgetLineCategoryDTO> _currentDto =null; 
        public List<BudgetLineCategoryDTO> CurrentDTO
        {
            get 
            {
                if (_currentDto==null)
                {
                    _currentDto=new List<BudgetLineCategoryDTO>();
                    foreach (BudgetLineCategory entity in this)
                    {
                        _currentDto.Add(entity.CurrentDTO);
                    }
                }
                return _currentDto;
			}
            
        }
        #region Contructor(s)

        public BudgetLineCategoryList()
        { 
       //     AllowNew = true;
        }

        #endregion

       

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="BudgetLineCategoryList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="BudgetLineCategoryList"/>.</returns>
        public static BudgetLineCategoryList NewList()
        {
            return new BudgetLineCategoryList();
        }      

        /// <summary>
        /// Returns a <see cref="BudgetLineCategoryList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="budgetLineCategoryID">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLineCategoryList"/> object of the specified criteria.</returns>
        public static BudgetLineCategoryList GetByBudgetLineCategoryID(System.Int32 budgetLineCategoryID)
        {
            var criteria = new BudgetLineCategoryCriteria{BudgetLineCategoryID = budgetLineCategoryID};
            
            
          return  new BudgetLineCategoryList().DataPortal_Fetch(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BudgetLineCategoryList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="createdBy">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLineCategoryList"/> object of the specified criteria.</returns>
        public static BudgetLineCategoryList GetByCreatedBy(System.Int32 createdBy)
        {
            var criteria = new BudgetLineCategoryCriteria{CreatedBy = createdBy};
            
            
          return  new BudgetLineCategoryList().DataPortal_Fetch(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BudgetLineCategoryList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="budgetLineCategoryTypeID">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLineCategoryList"/> object of the specified criteria.</returns>
        public static BudgetLineCategoryList GetByBudgetLineCategoryTypeID(System.Int32 budgetLineCategoryTypeID)
        {
            var criteria = new BudgetLineCategoryCriteria{BudgetLineCategoryTypeID = budgetLineCategoryTypeID};
            
            
          return  new BudgetLineCategoryList().DataPortal_Fetch(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BudgetLineCategoryList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="updatedBy">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLineCategoryList"/> object of the specified criteria.</returns>
        public static BudgetLineCategoryList GetByUpdatedBy(System.Int32? updatedBy)
        {
            var criteria = new BudgetLineCategoryCriteria{};
                            if(updatedBy.HasValue) criteria.UpdatedBy = updatedBy.Value;
            
          return  new BudgetLineCategoryList().DataPortal_Fetch(criteria);
        }

        public static BudgetLineCategoryList GetByCriteria(BudgetLineCategoryCriteria criteria)
        {
          return  new BudgetLineCategoryList().DataPortal_Fetch(criteria);
//            return DataPortal.Fetch<BudgetLineCategoryList>(criteria);
        }

        public static BudgetLineCategoryList GetAll()
        {
          return  new BudgetLineCategoryList().DataPortal_Fetch(new BudgetLineCategoryCriteria());
            //return DataPortal.Fetch<BudgetLineCategoryList>(new BudgetLineCategoryCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods
     

     

     

     

     
 
        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BudgetLineCategory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLineCategory"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BudgetLineCategory"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BudgetLineCategoryCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BudgetLineCategoryCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLineCategory"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BudgetLineCategory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BudgetLineCategory"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLineCategory"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BudgetLineCategory"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLineCategory"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
       // partial void OnAddNewCore(ref BudgetLineCategory item, ref bool cancel);

        #endregion

    }
}