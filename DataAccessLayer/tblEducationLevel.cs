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
    
    public partial class tblEducationLevel
    {
        public tblEducationLevel()
        {
            this.tblEvent2EductionLevel = new HashSet<tblEvent2EductionLevel>();
            this.tblEvent2EductionLevel1 = new HashSet<tblEvent2EductionLevel>();
            this.tblGroups = new HashSet<tblGroup>();
            this.tblEmployees = new HashSet<tblEmployee>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.Guid Language { get; set; }
        public byte Position { get; set; }
        public int MaxScore { get; set; }
        public Nullable<int> MinScore { get; set; }
    
        public virtual ICollection<tblEvent2EductionLevel> tblEvent2EductionLevel { get; set; }
        public virtual ICollection<tblEvent2EductionLevel> tblEvent2EductionLevel1 { get; set; }
        public virtual ICollection<tblGroup> tblGroups { get; set; }
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
