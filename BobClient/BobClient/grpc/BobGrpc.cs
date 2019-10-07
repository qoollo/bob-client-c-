// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/bob.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BobStorage {
  /// <summary>
  /// API
  /// </summary>
  internal static partial class BobApi
  {
    static readonly string __ServiceName = "bob_storage.BobApi";

    static readonly grpc::Marshaller<global::BobStorage.PutRequest> __Marshaller_bob_storage_PutRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BobStorage.PutRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BobStorage.OpStatus> __Marshaller_bob_storage_OpStatus = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BobStorage.OpStatus.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BobStorage.GetRequest> __Marshaller_bob_storage_GetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BobStorage.GetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BobStorage.Blob> __Marshaller_bob_storage_Blob = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BobStorage.Blob.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BobStorage.Null> __Marshaller_bob_storage_Null = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BobStorage.Null.Parser.ParseFrom);

    static readonly grpc::Method<global::BobStorage.PutRequest, global::BobStorage.OpStatus> __Method_Put = new grpc::Method<global::BobStorage.PutRequest, global::BobStorage.OpStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Put",
        __Marshaller_bob_storage_PutRequest,
        __Marshaller_bob_storage_OpStatus);

    static readonly grpc::Method<global::BobStorage.GetRequest, global::BobStorage.Blob> __Method_Get = new grpc::Method<global::BobStorage.GetRequest, global::BobStorage.Blob>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_bob_storage_GetRequest,
        __Marshaller_bob_storage_Blob);

    static readonly grpc::Method<global::BobStorage.Null, global::BobStorage.Null> __Method_Ping = new grpc::Method<global::BobStorage.Null, global::BobStorage.Null>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ping",
        __Marshaller_bob_storage_Null,
        __Marshaller_bob_storage_Null);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BobStorage.BobReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for BobApi</summary>
    public partial class BobApiClient : grpc::ClientBase<BobApiClient>
    {
      /// <summary>Creates a new client for BobApi</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BobApiClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BobApi that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BobApiClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BobApiClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BobApiClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::BobStorage.OpStatus Put(global::BobStorage.PutRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Put(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::BobStorage.OpStatus Put(global::BobStorage.PutRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Put, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::BobStorage.OpStatus> PutAsync(global::BobStorage.PutRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PutAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::BobStorage.OpStatus> PutAsync(global::BobStorage.PutRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Put, null, options, request);
      }
      public virtual global::BobStorage.Blob Get(global::BobStorage.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::BobStorage.Blob Get(global::BobStorage.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::BobStorage.Blob> GetAsync(global::BobStorage.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::BobStorage.Blob> GetAsync(global::BobStorage.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::BobStorage.Null Ping(global::BobStorage.Null request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ping(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::BobStorage.Null Ping(global::BobStorage.Null request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ping, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::BobStorage.Null> PingAsync(global::BobStorage.Null request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::BobStorage.Null> PingAsync(global::BobStorage.Null request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ping, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BobApiClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BobApiClient(configuration);
      }
    }

  }
}
#endregion
