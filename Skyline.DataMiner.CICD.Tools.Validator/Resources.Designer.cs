﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skyline.DataMiner.CICD.Tools.Validator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Skyline.DataMiner.CICD.Tools.Validator.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!--*********************************************************************************
        ///*  Copyright (c) 2014,  Skyline Communications NV  All Rights Reserved.    *
        ///*********************************************************************************
        /// 
        ///Reproduction of this document is authorized on condition that this
        ///copyright notice is included.  This DataMiner Protocol Schema
        ///embodies proprietary intellectual property.  The copyright
        ///retains all title and ownershi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string uom {
            get {
                return ResourceManager.GetString("uom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     &lt;/table&gt;
        ///&lt;script type=&quot;text/javascript&quot;&gt;//&lt;![CDATA[
        ///document.addEventListener(&apos;DOMContentLoaded&apos;, function() {
        ///    [].forEach.call(document.querySelectorAll(&apos;#resultstable .toggle&apos;), function(el) {
        ///  el.addEventListener(&apos;click&apos;, function() {
        ///    var el = this;
        ///    var tr = el.closest(&apos;tr&apos;);
        ///    var children = findChildren(tr);
        ///    var subnodes = children.filter(function(element) {
        ///      return element.matches(&apos;.expand&apos;);
        ///    });
        ///    subnodes.forEach(function(subnode) {
        ///      var subnodeChild [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string validatorResultsTemplateEnd {
            get {
                return ResourceManager.GetString("validatorResultsTemplateEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html lang=&quot;en&quot;&gt;
        ///&lt;head&gt;
        ///&lt;meta http-equiv=&quot;content-type&quot; content=&quot;text/html; charset=UTF-8&quot;&gt;
        ///  &lt;title&gt;Validator results $protocolName$ $protocolVersion$&lt;/title&gt;
        ///    &lt;style type=&quot;text/css&quot;&gt;
        ///
        ///html, body {
        ///	font-family: Segoe UI, SegoeUI, Helvetica Neue, Helvetica, Arial, sans-serif;
        ///	-webkit-font-smoothing: antialiased;
        ///	text-rendering: optimizeLegibility;
        ///}
        ///
        ///table {
        ///	border-collapse: collapse;
        ///}
        ///
        ///th {
        ///	text-align: left;
        ///	padding-left: 3px;
        ///	padding-right: 3px;
        ///}
        ///
        ///td {
        ///	 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string validatorResultsTemplateStart {
            get {
                return ResourceManager.GetString("validatorResultsTemplateStart", resourceCulture);
            }
        }
    }
}
