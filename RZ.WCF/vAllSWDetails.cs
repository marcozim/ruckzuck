//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuckZuck_WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class vAllSWDetails
    {
        public string ShortName { get; set; }
        public string Version { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string ProductDescription { get; set; }
        public string ProjectURL { get; set; }
        public Nullable<bool> IsLatest { get; set; }
        public string Type { get; set; }
        public string PSPreReq { get; set; }
        public string PSPreInstall { get; set; }
        public string PSInstall { get; set; }
        public string PSPostInstall { get; set; }
        public string PSUninstall { get; set; }
        public string PSDetection { get; set; }
        public string DownloadURL { get; set; }
        public string Filename { get; set; }
        public string FileHash { get; set; }
        public byte[] Icon { get; set; }
        public Nullable<int> Downloads { get; set; }
        public Nullable<int> Success { get; set; }
        public Nullable<int> Failed { get; set; }
        public Nullable<int> SuccessRatio { get; set; }
        public Nullable<System.DateTime> LastStatus { get; set; }
        public long IconId { get; set; }
        public string Categories { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
    }
}