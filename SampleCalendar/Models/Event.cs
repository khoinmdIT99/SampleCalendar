//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleCalendar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public long EventID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public string UTCStartDateTime { get; set; }
        public string UTCEndDateTime { get; set; }
        public string ThemeColor { get; set; }
        public Nullable<bool> IsFullDay { get; set; }
        public Nullable<bool> IsRecurring { get; set; }
        public string RRule { get; set; }
        public Nullable<int> EventTypeId { get; set; }
        public Nullable<System.DateTime> RepeatEndDate { get; set; }
        public string UTCRepeatEndDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string EventGUID { get; set; }
        public string EventStatus { get; set; }
        public string UserId { get; set; }
    }
}
