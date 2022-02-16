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
    
    public partial class tblEvent
    {
        public tblEvent()
        {
            this.tblEvent2EductionLevel = new HashSet<tblEvent2EductionLevel>();
            this.tblDictionaries = new HashSet<tblDictionary>();
            this.tblGroups = new HashSet<tblGroup>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid EventType { get; set; }
        public string Theme { get; set; }
        public Nullable<System.Guid> PrimaryInstructor { get; set; }
        public Nullable<System.Guid> SubstituteInstructor { get; set; }
        public Nullable<System.Guid> Auditorium { get; set; }
        public string Description { get; set; }
    
        public virtual tblDictionary tblDictionary { get; set; }
        public virtual tblDictionary tblDictionary1 { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblEmployee tblEmployee1 { get; set; }
        public virtual ICollection<tblEvent2EductionLevel> tblEvent2EductionLevel { get; set; }
        public virtual ICollection<tblDictionary> tblDictionaries { get; set; }
        public virtual ICollection<tblGroup> tblGroups { get; set; }
    }
}