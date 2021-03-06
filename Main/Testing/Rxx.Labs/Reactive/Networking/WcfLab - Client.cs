﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.530
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rxx.Labs.Reactive.Networking
{
  using System.Runtime.Serialization;
  using System;


  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
  [System.Runtime.Serialization.DataContractAttribute(Name = "ExampleServiceResponse", Namespace = "http://schemas.datacontract.org/2004/07/Rxx.Labs.Reactive.Networking")]
  [System.SerializableAttribute()]
  public partial class ExampleServiceResponseReference : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
  {

    [System.NonSerializedAttribute()]
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

    [System.Runtime.Serialization.OptionalFieldAttribute()]
    private string ResponseSummaryField;

    [System.Runtime.Serialization.OptionalFieldAttribute()]
    private System.Uri UrlField;

    [global::System.ComponentModel.BrowsableAttribute(false)]
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
      get
      {
        return this.extensionDataField;
      }
      set
      {
        this.extensionDataField = value;
      }
    }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string ResponseSummary
    {
      get
      {
        return this.ResponseSummaryField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ResponseSummaryField, value) != true))
        {
          this.ResponseSummaryField = value;
          this.RaisePropertyChanged("ResponseSummary");
        }
      }
    }

    [System.Runtime.Serialization.DataMemberAttribute()]
    public System.Uri Url
    {
      get
      {
        return this.UrlField;
      }
      set
      {
        if ((object.ReferenceEquals(this.UrlField, value) != true))
        {
          this.UrlField = value;
          this.RaisePropertyChanged("Url");
        }
      }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if ((propertyChanged != null))
      {
        propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ExampleService.IExampleService")]
  public interface IExampleServiceReference
  {

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IExampleService/GetHttpResponses", ReplyAction = "http://tempuri.org/IExampleService/GetHttpResponsesResponse")]
    Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference[] GetHttpResponses(System.Uri[] urls);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://tempuri.org/IExampleService/GetHttpResponses", ReplyAction = "http://tempuri.org/IExampleService/GetHttpResponsesResponse")]
    System.IAsyncResult BeginGetHttpResponses(System.Uri[] urls, System.AsyncCallback callback, object asyncState);

    Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference[] EndGetHttpResponses(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IExampleService/GetSlowestHttpResponse", ReplyAction = "http://tempuri.org/IExampleService/GetSlowestHttpResponseResponse")]
    Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference GetSlowestHttpResponse(System.Uri[] urls);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://tempuri.org/IExampleService/GetSlowestHttpResponse", ReplyAction = "http://tempuri.org/IExampleService/GetSlowestHttpResponseResponse")]
    System.IAsyncResult BeginGetSlowestHttpResponse(System.Uri[] urls, System.AsyncCallback callback, object asyncState);

    Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference EndGetSlowestHttpResponse(System.IAsyncResult result);
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public interface IExampleServiceChannel : Rxx.Labs.Reactive.Networking.IExampleServiceReference, System.ServiceModel.IClientChannel
  {
  }

  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public partial class ExampleServiceClient : System.ServiceModel.ClientBase<Rxx.Labs.Reactive.Networking.IExampleServiceReference>, Rxx.Labs.Reactive.Networking.IExampleServiceReference
  {

    public ExampleServiceClient()
    {
    }

    public ExampleServiceClient(string endpointConfigurationName) :
      base(endpointConfigurationName)
    {
    }

    public ExampleServiceClient(string endpointConfigurationName, string remoteAddress) :
      base(endpointConfigurationName, remoteAddress)
    {
    }

    public ExampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
      base(endpointConfigurationName, remoteAddress)
    {
    }

    public ExampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
      base(binding, remoteAddress)
    {
    }

    public Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference[] GetHttpResponses(System.Uri[] urls)
    {
      return base.Channel.GetHttpResponses(urls);
    }

    public Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference GetSlowestHttpResponse(System.Uri[] urls)
    {
      return base.Channel.GetSlowestHttpResponse(urls);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    public System.IAsyncResult BeginGetHttpResponses(System.Uri[] urls, System.AsyncCallback callback, object asyncState)
    {
      return base.Channel.BeginGetHttpResponses(urls, callback, asyncState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    public Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference[] EndGetHttpResponses(System.IAsyncResult result)
    {
      return base.Channel.EndGetHttpResponses(result);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    public System.IAsyncResult BeginGetSlowestHttpResponse(System.Uri[] urls, System.AsyncCallback callback, object asyncState)
    {
      return base.Channel.BeginGetSlowestHttpResponse(urls, callback, asyncState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    public Rxx.Labs.Reactive.Networking.ExampleServiceResponseReference EndGetSlowestHttpResponse(System.IAsyncResult result)
    {
      return base.Channel.EndGetSlowestHttpResponse(result);
    }
  }
}