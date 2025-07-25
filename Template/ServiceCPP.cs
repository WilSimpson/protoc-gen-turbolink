﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace protoc_gen_turbolink.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Google.Protobuf.Reflection;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ServiceCPP : ServiceCPPBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("//Generated by TurboLink CodeGenerator, do not edit!\r\n#include \"");
            
            #line 8 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(s.TurboLinkBasicFileName));
            
            #line default
            #line hidden
            this.Write("Service.h\"\r\n#include \"");
            
            #line 9 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(s.TurboLinkBasicFileName));
            
            #line default
            #line hidden
            this.Write("Client.h\"\r\n#include \"");
            
            #line 10 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(s.CamelFileName));
            
            #line default
            #line hidden
            this.Write("Service_Private.h\"\r\n#include \"");
            
            #line 11 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(s.CamelFileName));
            
            #line default
            #line hidden
            this.Write("Marshaling.h\"\r\n");
            
            #line 12 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

foreach(String dependency in s.DependencyFiles)
{

            
            #line default
            #line hidden
            this.Write("#include \"");
            
            #line 16 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency));
            
            #line default
            #line hidden
            this.Write("Marshaling.h\"\r\n");
            
            #line 17 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

}

            
            #line default
            #line hidden
            this.Write("#include \"TurboLinkGrpcManager_Private.h\"\r\n#include \"TurboLinkGrpcUtilities.h\"\r\n");
            
            #line 22 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

foreach(GrpcService service in s.ServiceArray)
{

            
            #line default
            #line hidden
            this.Write("\r\nU");
            
            #line 27 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::U");
            
            #line 27 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("()\r\n\t: d(new U");
            
            #line 28 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::Private())\r\n{\r\n}\r\n\r\nU");
            
            #line 32 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::~U");
            
            #line 32 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("()\r\n{\r\n\tdelete d;\r\n}\r\n\r\nvoid U");
            
            #line 37 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::Connect()\r\n{\r\n\tFString serviceEndPoint = UTurboLinkGrpcUtilities::GetTurboLinkGrpcConfig()->GetServiceEndPoint(TEXT(\"");
            
            #line 39 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("\"));\r\n\tUE_LOG(LogTurboLink, Warning, TEXT(\"Connect to ");
            
            #line 40 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write(": '%s'\"), *serviceEndPoint);\r\n\r\n\tif (d->Channel == nullptr) {\r\n\t\td->Channel = TurboLinkManager->d->CreateServiceChannel(TCHAR_TO_UTF8(*serviceEndPoint), this);\r\n\t}\r\n\tif (d->Stub == nullptr) {\r\n\t\td->Stub = ");
            
            #line 46 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(s.GrpcPackageName));
            
            #line default
            #line hidden
            this.Write("::");
            
            #line 46 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::NewStub(d->Channel->RpcChannel);\r\n\t}\r\n\r\n\tgrpc_connectivity_state currentChannelState = d->Channel->RpcChannel->GetState(true);\r\n\tif (OnServiceStateChanged.IsBound())\r\n\t{\r\n\t\tOnServiceStateChanged.Broadcast(UTurboLinkGrpcManager::Private::GrpcStateToServiceState(currentChannelState));\r\n\t}\r\n}\r\n\r\nEGrpcServiceState U");
            
            #line 56 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::GetServiceState() const\r\n{\r\n\tif (d->Channel == nullptr) return EGrpcServiceState::NotCreate;\r\n\r\n\tauto rpcChannelState = d->Channel->RpcChannel->GetState(false);\r\n\treturn UTurboLinkGrpcManager::Private::GrpcStateToServiceState(rpcChannelState);\r\n}\r\n\r\nU");
            
            #line 64 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("Client* U");
            
            #line 64 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::MakeClient()\r\n{\r\n\tauto client = UGrpcService::MakeClient<U");
            
            #line 66 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("Client>();\r\n\treturn client;\r\n}\r\n\r\nvoid U");
            
            #line 70 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::Shutdown()\r\n{\r\n\tSuper::Shutdown();\r\n\td->Stub = nullptr;\r\n\tif (d->Channel != nullptr) {\r\n\t\tTurboLinkManager->d->RemoveServiceChannel(d->Channel, this);\r\n\t\td->Channel = nullptr;\r\n\t}\r\n}\r\n");
            
            #line 79 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

	foreach (GrpcServiceMethod method in service.MethodArray)
	{
		if(!method.ClientStreaming) {

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 85 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
 if(method.ServerStreaming) { 
            
            #line default
            #line hidden
            this.Write("void U");
            
            #line 86 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::Call");
            
            #line 86 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(const ");
            
            #line 86 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.InputType));
            
            #line default
            #line hidden
            this.Write("& Request, F");
            
            #line 86 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("ResponseLambda ResponseLambda, F");
            
            #line 86 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("FinishLambda FinishLambda, TMap<FString, FString>& MetaData)\r\n");
            
            #line 87 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
 } else {
            
            #line default
            #line hidden
            this.Write("void U");
            
            #line 88 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            this.Write("::Call");
            
            #line 88 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(const ");
            
            #line 88 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.InputType));
            
            #line default
            #line hidden
            this.Write("& Request, F");
            
            #line 88 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("ResponseLambda ResponseLambda, TMap<FString, FString>& MetaData)\r\n");
            
            #line 89 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
}
            
            #line default
            #line hidden
            this.Write("{\r\n\tif (InnerClient == nullptr)\r\n\t{\r\n\t\tInnerClient = MakeClient();\r\n\t}\r\n\tU");
            
            #line 95 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            
            #line 95 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("LambdaWrapper* lambdaWrapper = NewObject<U");
            
            #line 95 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            
            #line 95 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("LambdaWrapper>();\r\n\tlambdaWrapper->InnerClient = InnerClient;\r\n\tlambdaWrapper->ResponseLambda = ResponseLambda;\r\n");
            
            #line 98 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
 if(method.ServerStreaming) { 
            
            #line default
            #line hidden
            this.Write("\tlambdaWrapper->FinishLambda = FinishLambda;\r\n");
            
            #line 100 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
}
            
            #line default
            #line hidden
            this.Write("\tlambdaWrapper->Handle = InnerClient->Init");
            
            #line 101 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n\tInnerClient->On");
            
            #line 102 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("Response.AddUniqueDynamic(lambdaWrapper, &U");
            
            #line 102 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            
            #line 102 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("LambdaWrapper::OnResponse);\r\n");
            
            #line 103 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

			if(method.ServerStreaming) {

            
            #line default
            #line hidden
            this.Write("\tInnerClient->OnContextStateChange.AddUniqueDynamic(lambdaWrapper, &U");
            
            #line 106 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service.Name));
            
            #line default
            #line hidden
            
            #line 106 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("LambdaWrapper::OnContextStateChanged);\r\n");
            
            #line 107 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

			}

            
            #line default
            #line hidden
            this.Write("\tInnerClient->");
            
            #line 110 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(lambdaWrapper->Handle, Request, MetaData);\r\n}\r\n");
            
            #line 112 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

		}
	}

            
            #line default
            #line hidden
            
            #line 116 "Z:\wilsimpson\protoc-gen-turbolink\Template\ServiceCPP.tt"

}

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class ServiceCPPBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
