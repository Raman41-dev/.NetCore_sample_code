﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Home.cs'.
//
//     Template: Criteria.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


 

namespace CFMData
{
    [Serializable]
    public partial class HomeCriteria 
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public HomeCriteria(){}

        public HomeCriteria(System.Int32 homeID)
        {
            HomeID = homeID;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 HomeID
        {
            get { return GetValue<System.Int32>("HomeID"); }
            set { _bag["HomeID"] = value; }
        }

        public System.Int32 GLEntityID
        {
            get { return GetValue<System.Int32>("GLEntityID"); }
            set { _bag["GLEntityID"] = value; }
        }

        public System.Int32 BusinessAreaID
        {
            get { return GetValue<System.Int32>("BusinessAreaID"); }
            set { _bag["BusinessAreaID"] = value; }
        }

        public System.String HomeCostCentreCode
        {
            get { return GetValue<System.String>("HomeCostCentreCode"); }
            set { _bag["HomeCostCentreCode"] = value; }
        }

        public System.String HomeName
        {
            get { return GetValue<System.String>("HomeName"); }
            set { _bag["HomeName"] = value; }
        }

        public System.String Parcel
        {
            get { return GetValue<System.String>("Parcel"); }
            set { _bag["Parcel"] = value; }
        }

        public System.Int32 SILTarget
        {
            get { return GetValue<System.Int32>("SILTarget"); }
            set { _bag["SILTarget"] = value; }
        }

        public System.Int32 NoofBeds
        {
            get { return GetValue<System.Int32>("NoofBeds"); }
            set { _bag["NoofBeds"] = value; }
        }

        public System.Int32 AccommodationTypeId
        {
            get { return GetValue<System.Int32>("AccommodationTypeId"); }
            set { _bag["AccommodationTypeId"] = value; }
        }

        public System.Boolean IsGST
        {
            get { return GetValue<System.Boolean>("isGST"); }
            set { _bag["isGST"] = value; }
        }

        public System.Int32? AddressID
        {
            get { return GetValue<System.Int32?>("AddressID"); }
            set { _bag["AddressID"] = value; }
        }

        public System.Boolean IsActive
        {
            get { return GetValue<System.Boolean>("IsActive"); }
            set { _bag["IsActive"] = value; }
        }

        public System.Int32 CreatedBy
        {
            get { return GetValue<System.Int32>("CreatedBy"); }
            set { _bag["CreatedBy"] = value; }
        }

        public System.DateTime CreatedOn
        {
            get { return GetValue<System.DateTime>("CreatedOn"); }
            set { _bag["CreatedOn"] = value; }
        }

        public System.Int32? UpdatedBy
        {
            get { return GetValue<System.Int32?>("UpdatedBy"); }
            set { _bag["UpdatedBy"] = value; }
        }

        public System.DateTime? UpdatedOn
        {
            get { return GetValue<System.DateTime?>("UpdatedOn"); }
            set { _bag["UpdatedOn"] = value; }
        }

        #endregion
        
        #region Read-Only

        public bool AddressIDHasValue
        {
            get { return _bag.ContainsKey("AddressID"); }
        }

        public bool UpdatedByHasValue
        {
            get { return _bag.ContainsKey("UpdatedBy"); }
        }

        public bool UpdatedOnHasValue
        {
            get { return _bag.ContainsKey("UpdatedOn"); }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].[Home]";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public  string ToString()
        {
            var result = String.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !String.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
    }
}