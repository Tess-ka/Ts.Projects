//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VetClinicApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TreatmentСase
    {
        public int TreatmentСaseId { get; set; }
        public System.DateTime Data { get; set; }
        public int Number { get; set; }
        public int DoctorID { get; set; }
        public int PetID { get; set; }
        public string VisualInspection { get; set; }
        public string Anamnesis { get; set; }
        public string Diagnosis { get; set; }
        public string Cause { get; set; }
        public string Conclusion { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
