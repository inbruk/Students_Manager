//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsManager.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwGroup4List
    {
        public System.Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public Nullable<System.Guid> GroupPrimaryInstructor { get; set; }
        public Nullable<System.Guid> GroupSecondaryInstructor { get; set; }
        public System.Guid EducationLevelId { get; set; }
        public string EducationLevelName { get; set; }
        public System.Guid EducationLevelLanguageId { get; set; }
        public string EducationLevelLanguageName { get; set; }
    }
}