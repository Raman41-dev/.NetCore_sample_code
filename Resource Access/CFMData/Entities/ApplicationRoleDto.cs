﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//       Changes to this template will not be lost.
//
//     Template: DTO.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;

 

namespace CFMData
{    
    /// <summary>
    /// The ApplicationRole class is a CSLA editable root class.  See CSLA documentation for a more detailed description.
    /// </summary>
    public partial class ApplicationRoleDTO
    {
        public ApplicationRole CustomCopyDTO(ApplicationRole obj)
        {
            obj.Name = this.Name;
            obj.IsActive = this.IsActive;
            obj.SystemRoleID = this.SystemRoleID;

            return obj;
        }
    }
}