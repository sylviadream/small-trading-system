// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: efrei_exchange_server.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Efrei.ExchangeServer {
  /// <summary>
  /// Exchange server implements this interface.
  /// A trading client must be a client of this interface
  /// </summary>
  public static partial class ExchangeEngine
  {
    static readonly string __ServiceName = "efrei.exchange_server.ExchangeEngine";

    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.SubscribeArgs> __Marshaller_efrei_exchange_server_SubscribeArgs = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.SubscribeArgs.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.SubscribeResponse> __Marshaller_efrei_exchange_server_SubscribeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.SubscribeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.SendOrderArgs> __Marshaller_efrei_exchange_server_SendOrderArgs = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.SendOrderArgs.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.SendOrderResponse> __Marshaller_efrei_exchange_server_SendOrderResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.SendOrderResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.Void> __Marshaller_efrei_exchange_server_Void = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.Void.Parser.ParseFrom);

    static readonly grpc::Method<global::Efrei.ExchangeServer.SubscribeArgs, global::Efrei.ExchangeServer.SubscribeResponse> __Method_Subscribe = new grpc::Method<global::Efrei.ExchangeServer.SubscribeArgs, global::Efrei.ExchangeServer.SubscribeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Subscribe",
        __Marshaller_efrei_exchange_server_SubscribeArgs,
        __Marshaller_efrei_exchange_server_SubscribeResponse);

    static readonly grpc::Method<global::Efrei.ExchangeServer.SendOrderArgs, global::Efrei.ExchangeServer.SendOrderResponse> __Method_SendOrder = new grpc::Method<global::Efrei.ExchangeServer.SendOrderArgs, global::Efrei.ExchangeServer.SendOrderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendOrder",
        __Marshaller_efrei_exchange_server_SendOrderArgs,
        __Marshaller_efrei_exchange_server_SendOrderResponse);

    static readonly grpc::Method<global::Efrei.ExchangeServer.Void, global::Efrei.ExchangeServer.Void> __Method_PingSrv = new grpc::Method<global::Efrei.ExchangeServer.Void, global::Efrei.ExchangeServer.Void>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PingSrv",
        __Marshaller_efrei_exchange_server_Void,
        __Marshaller_efrei_exchange_server_Void);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Efrei.ExchangeServer.EfreiExchangeServerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ExchangeEngine</summary>
    public abstract partial class ExchangeEngineBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Efrei.ExchangeServer.SubscribeResponse> Subscribe(global::Efrei.ExchangeServer.SubscribeArgs request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Efrei.ExchangeServer.SendOrderResponse> SendOrder(global::Efrei.ExchangeServer.SendOrderArgs request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Efrei.ExchangeServer.Void> PingSrv(global::Efrei.ExchangeServer.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ExchangeEngine</summary>
    public partial class ExchangeEngineClient : grpc::ClientBase<ExchangeEngineClient>
    {
      /// <summary>Creates a new client for ExchangeEngine</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ExchangeEngineClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ExchangeEngine that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ExchangeEngineClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ExchangeEngineClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ExchangeEngineClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Efrei.ExchangeServer.SubscribeResponse Subscribe(global::Efrei.ExchangeServer.SubscribeArgs request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subscribe(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Efrei.ExchangeServer.SubscribeResponse Subscribe(global::Efrei.ExchangeServer.SubscribeArgs request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Subscribe, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.SubscribeResponse> SubscribeAsync(global::Efrei.ExchangeServer.SubscribeArgs request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubscribeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.SubscribeResponse> SubscribeAsync(global::Efrei.ExchangeServer.SubscribeArgs request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Subscribe, null, options, request);
      }
      public virtual global::Efrei.ExchangeServer.SendOrderResponse SendOrder(global::Efrei.ExchangeServer.SendOrderArgs request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendOrder(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Efrei.ExchangeServer.SendOrderResponse SendOrder(global::Efrei.ExchangeServer.SendOrderArgs request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendOrder, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.SendOrderResponse> SendOrderAsync(global::Efrei.ExchangeServer.SendOrderArgs request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendOrderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.SendOrderResponse> SendOrderAsync(global::Efrei.ExchangeServer.SendOrderArgs request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendOrder, null, options, request);
      }
      public virtual global::Efrei.ExchangeServer.Void PingSrv(global::Efrei.ExchangeServer.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PingSrv(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Efrei.ExchangeServer.Void PingSrv(global::Efrei.ExchangeServer.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PingSrv, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> PingSrvAsync(global::Efrei.ExchangeServer.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PingSrvAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> PingSrvAsync(global::Efrei.ExchangeServer.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PingSrv, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ExchangeEngineClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ExchangeEngineClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ExchangeEngineBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Subscribe, serviceImpl.Subscribe)
          .AddMethod(__Method_SendOrder, serviceImpl.SendOrder)
          .AddMethod(__Method_PingSrv, serviceImpl.PingSrv).Build();
    }

  }
  /// <summary>
  /// Exchange server will be client of this interface.
  /// A trading client must provides a server implementation of this interface (so the exchange can contact it)
  /// </summary>
  public static partial class ExchangeClient
  {
    static readonly string __ServiceName = "efrei.exchange_server.ExchangeClient";

    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.NewPriceArgs> __Marshaller_efrei_exchange_server_NewPriceArgs = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.NewPriceArgs.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.Void> __Marshaller_efrei_exchange_server_Void = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.Void.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Efrei.ExchangeServer.OrderEventArg> __Marshaller_efrei_exchange_server_OrderEventArg = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Efrei.ExchangeServer.OrderEventArg.Parser.ParseFrom);

    static readonly grpc::Method<global::Efrei.ExchangeServer.NewPriceArgs, global::Efrei.ExchangeServer.Void> __Method_NewPrice = new grpc::Method<global::Efrei.ExchangeServer.NewPriceArgs, global::Efrei.ExchangeServer.Void>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewPrice",
        __Marshaller_efrei_exchange_server_NewPriceArgs,
        __Marshaller_efrei_exchange_server_Void);

    static readonly grpc::Method<global::Efrei.ExchangeServer.OrderEventArg, global::Efrei.ExchangeServer.Void> __Method_OrderEvent = new grpc::Method<global::Efrei.ExchangeServer.OrderEventArg, global::Efrei.ExchangeServer.Void>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OrderEvent",
        __Marshaller_efrei_exchange_server_OrderEventArg,
        __Marshaller_efrei_exchange_server_Void);

    static readonly grpc::Method<global::Efrei.ExchangeServer.Void, global::Efrei.ExchangeServer.Void> __Method_Ping = new grpc::Method<global::Efrei.ExchangeServer.Void, global::Efrei.ExchangeServer.Void>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ping",
        __Marshaller_efrei_exchange_server_Void,
        __Marshaller_efrei_exchange_server_Void);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Efrei.ExchangeServer.EfreiExchangeServerReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of ExchangeClient</summary>
    public abstract partial class ExchangeClientBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Efrei.ExchangeServer.Void> NewPrice(global::Efrei.ExchangeServer.NewPriceArgs request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Efrei.ExchangeServer.Void> OrderEvent(global::Efrei.ExchangeServer.OrderEventArg request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Efrei.ExchangeServer.Void> Ping(global::Efrei.ExchangeServer.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ExchangeClient</summary>
    public partial class ExchangeClientClient : grpc::ClientBase<ExchangeClientClient>
    {
      /// <summary>Creates a new client for ExchangeClient</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ExchangeClientClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ExchangeClient that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ExchangeClientClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ExchangeClientClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ExchangeClientClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Efrei.ExchangeServer.Void NewPrice(global::Efrei.ExchangeServer.NewPriceArgs request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NewPrice(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Efrei.ExchangeServer.Void NewPrice(global::Efrei.ExchangeServer.NewPriceArgs request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NewPrice, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> NewPriceAsync(global::Efrei.ExchangeServer.NewPriceArgs request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NewPriceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> NewPriceAsync(global::Efrei.ExchangeServer.NewPriceArgs request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NewPrice, null, options, request);
      }
      public virtual global::Efrei.ExchangeServer.Void OrderEvent(global::Efrei.ExchangeServer.OrderEventArg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OrderEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Efrei.ExchangeServer.Void OrderEvent(global::Efrei.ExchangeServer.OrderEventArg request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OrderEvent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> OrderEventAsync(global::Efrei.ExchangeServer.OrderEventArg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OrderEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> OrderEventAsync(global::Efrei.ExchangeServer.OrderEventArg request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OrderEvent, null, options, request);
      }
      public virtual global::Efrei.ExchangeServer.Void Ping(global::Efrei.ExchangeServer.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ping(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Efrei.ExchangeServer.Void Ping(global::Efrei.ExchangeServer.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ping, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> PingAsync(global::Efrei.ExchangeServer.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Efrei.ExchangeServer.Void> PingAsync(global::Efrei.ExchangeServer.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ping, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ExchangeClientClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ExchangeClientClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ExchangeClientBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_NewPrice, serviceImpl.NewPrice)
          .AddMethod(__Method_OrderEvent, serviceImpl.OrderEvent)
          .AddMethod(__Method_Ping, serviceImpl.Ping).Build();
    }

  }
}
#endregion
