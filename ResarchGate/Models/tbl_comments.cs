
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ResarchGate.Models
{

using System;
    using System.Collections.Generic;
    
public partial class tbl_comments
{

    public int c_id { get; set; }

    public string c_text { get; set; }

    public System.DateTime c_timestamp { get; set; }

    public Nullable<int> UserId { get; set; }

    public Nullable<int> PaperId { get; set; }



    public virtual tbl_paper tbl_paper { get; set; }

    public virtual tbl_user tbl_user { get; set; }

}

}
