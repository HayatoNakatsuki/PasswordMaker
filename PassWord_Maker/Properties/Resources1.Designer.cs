﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassWord_Maker.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
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
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PassWord_Maker.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   \PasswordMaker\ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DefaultDirectory {
            get {
                return ResourceManager.GetString("DefaultDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Password.csv に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DefaultFileName {
            get {
                return ResourceManager.GetString("DefaultFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Environment.GetEnvironmentVariable(&quot;USERPROFILE&quot;) + &quot;\\Documents&quot; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DocumentsPath {
            get {
                return ResourceManager.GetString("DocumentsPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   英数字(大文字+小文字) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string list_PassPatern1 {
            get {
                return ResourceManager.GetString("list_PassPatern1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   英数字(大文字+小文字) + 記号 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string list_PassPatern2 {
            get {
                return ResourceManager.GetString("list_PassPatern2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   *** に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Mask {
            get {
                return ResourceManager.GetString("Mask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   パスワード生成パターン に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string PaternSelect {
            get {
                return ResourceManager.GetString("PaternSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Icon PMicon {
            get {
                object obj = ResourceManager.GetObject("PMicon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Text files|*.txt,*.csv に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SaveFilter {
            get {
                return ResourceManager.GetString("SaveFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ファイルを保存する に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SaveTitle {
            get {
                return ResourceManager.GetString("SaveTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   PassWordMaker に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string WindowTitle {
            get {
                return ResourceManager.GetString("WindowTitle", resourceCulture);
            }
        }
    }
}
