﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seranet.Api.Plugins.Employee {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Seranet.Api.Plugins.Employee.SqlResource", typeof(SqlResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT 
        ///	e.FirstName, 
        ///	e.Surname, 
        ///                   e.Email,
        ///	e.NICNumber,
        ///	e.hrMobileNo,
        ///	e.Twitter,
        ///	e.Facebook,
        ///	e.LinkedIn,
        ///	
        ///	e.PAddress1,
        ///	e.PAddress2,
        ///	e.PAddress3, 
        ///	pd.DistrictName AS PDistrict,
        ///	pc.CountryName AS PCountry,
        ///	s.PermanentZipCode as PCoordinates, 
        ///	e.PTelephone,
        ///	
        ///	e.RAddress1,
        ///	e.RAddress2,
        ///	e.RAddress3, 
        ///	rd.DistrictName AS RDistrict,
        ///	rc.CountryName AS RCountry,
        ///	s.PresentZipCode as RCoordinates,
        ///	e.RTelephone
        ///	
        ///FROM MI_Employer_Employee AS e
        ///LEFT OUTE [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string emp_details {
            get {
                return ResourceManager.GetString("emp_details", resourceCulture);
            }
        }
    }
}
