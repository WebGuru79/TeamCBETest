//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UCT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Competencies_LearningActivities_Archive
    {
        public int Competency_LearningActivityID { get; set; }
        public int CompetencyItemID { get; set; }
        public byte CompetencyType { get; set; }
        public int LearningActivityID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<int> VersionID { get; set; }
        public Nullable<int> OldCompetency_LearningActivityID { get; set; }
        public Nullable<int> OldCompetencyItemID { get; set; }
    
        public virtual LearningActivities_Archive LearningActivities_Archive { get; set; }
        public virtual Version Version { get; set; }
    }
}
