﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiscordApp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DiscordApp.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///  &lt;head&gt;
        ///    &lt;title&gt;Discord+ Processor&lt;/title&gt;
        ///
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;index/style.index.css&quot;&gt;
        ///  &lt;/head&gt;
        ///  &lt;body class=&quot;preload-images&quot;&gt;
        ///    &lt;div class=&quot;content content-logo&quot;&gt;
        ///      &lt;div class=&quot;logo&quot;&gt;
        ///        &lt;img src=&quot;index/images/logo-loading.gif&quot;&gt;
        ///      &lt;/div&gt;
        ///    &lt;/div&gt;
        ///
        ///    &lt;div class=&quot;content content-text&quot;&gt;
        ///      &lt;div class=&quot;quote&quot;&gt;Word, words, and even more words&lt;/div&gt;
        ///      &lt;div class=&quot;status&quot;&gt;I was busy thinking &apos;bout words...&lt;/div&gt;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProcesserModule {
            get {
                return ResourceManager.GetString("ProcesserModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $(function(){
        ///  var _preloadImage;
        ///
        ///  _preloadImage = new Image();
        ///  _preloadImage.src = &quot;index/images/logo-error.gif&quot;;
        ///
        ///  _preloadImage = new Image();
        ///  _preloadImage.src = &quot;index/images/logo-error-shake.gif&quot;;
        ///});
        ///
        ///function setQuoteString(string) {
        ///  return $(&quot;.content-text .quote&quot;).text(string);
        ///};
        ///
        ///function setStatusString(string) {
        ///  return $(&quot;.content-text .status&quot;).text(string);
        ///};
        ///
        ///var _showErrorMessage = false;
        ///
        ///function showErrorMessage(title = &quot;Something went terribly wrong dur [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProcessorScript {
            get {
                return ResourceManager.GetString("ProcessorScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @font-face{font-family:Whitney;src:url(fonts/Whitney.ttf)}@keyframes animFadeIn{from{margin-top:100px;opacity:-1}to{margin-top:0;opacity:1}}@keyframes animFadeOut{from{margin-top:0;opacity:1}to{margin-top:-100px;opacity:0}}html{min-height:100%}body{background:#25272b;font-family:Whitney,Helvetica Neue,Helvetica,Arial,sans-serif;color:#fff;height:100%}body .hidden{display:none}body .content{position:absolute;left:0;right:0;bottom:0;top:0;margin:auto}body .anim-fade-in{animation:animFadeIn 1.2s forwards}body  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProcessorStyle {
            get {
                return ResourceManager.GetString("ProcessorStyle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ToolbarClose {
            get {
                object obj = ResourceManager.GetObject("ToolbarClose", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ToolbarCloseActive {
            get {
                object obj = ResourceManager.GetObject("ToolbarCloseActive", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ToolbarLogo {
            get {
                object obj = ResourceManager.GetObject("ToolbarLogo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ToolbarMaximize {
            get {
                object obj = ResourceManager.GetObject("ToolbarMaximize", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ToolbarMaximizeActive {
            get {
                object obj = ResourceManager.GetObject("ToolbarMaximizeActive", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ToolbarMinimize {
            get {
                object obj = ResourceManager.GetObject("ToolbarMinimize", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ToolbarMinimizeActive {
            get {
                object obj = ResourceManager.GetObject("ToolbarMinimizeActive", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}