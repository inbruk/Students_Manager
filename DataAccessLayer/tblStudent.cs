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
    
    public partial class tblStudent
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomic { get; set; }
        public string SurnameAndInitials { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public System.Guid PriceGroup { get; set; }
        public Nullable<System.Guid> Language1 { get; set; }
        public Nullable<int> CurrentScore1 { get; set; }
        public Nullable<int> FirstTestScore1 { get; set; }
        public Nullable<System.Guid> Group1 { get; set; }
        public Nullable<System.Guid> Language2 { get; set; }
        public Nullable<int> CurrentScore2 { get; set; }
        public Nullable<int> FirstTestScore2 { get; set; }
        public Nullable<System.Guid> Group2 { get; set; }
        public Nullable<System.Guid> Language3 { get; set; }
        public Nullable<int> CurrentScore3 { get; set; }
        public Nullable<int> FirstTestScore3 { get; set; }
        public Nullable<System.Guid> Group3 { get; set; }
    
        public virtual tblDictionary tblDictionary { get; set; }
        public virtual tblDictionary tblDictionary1 { get; set; }
        public virtual tblDictionary tblDictionary2 { get; set; }
        public virtual tblGroup tblGroup { get; set; }
        public virtual tblGroup tblGroup1 { get; set; }
        public virtual tblGroup tblGroup2 { get; set; }
        public virtual tblPriceGroup tblPriceGroup { get; set; }
    }
}