//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI.Smart.UI.EF1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserVisit
    {
        public int userId { get; set; }
        public int cityId { get; set; }
        public Nullable<System.DateTime> when { get; set; }
    
        public virtual City City { get; set; }
        public virtual user user { get; set; }
    }
}
