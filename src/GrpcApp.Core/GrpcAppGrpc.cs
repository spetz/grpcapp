// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: src/GrpcApp.Core/GrpcApp.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcApp.Core {
  public static partial class DemoService
  {
    static readonly string __ServiceName = "GrpcApp.Core.DemoService";

    static readonly grpc::Marshaller<global::GrpcApp.Core.Message> __Marshaller_GrpcApp_Core_Message = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcApp.Core.Message.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcApp.Core.Empty> __Marshaller_GrpcApp_Core_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcApp.Core.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcApp.Core.Message, global::GrpcApp.Core.Empty> __Method_Send = new grpc::Method<global::GrpcApp.Core.Message, global::GrpcApp.Core.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Send",
        __Marshaller_GrpcApp_Core_Message,
        __Marshaller_GrpcApp_Core_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcApp.Core.GrpcAppReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DemoService</summary>
    public abstract partial class DemoServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcApp.Core.Empty> Send(global::GrpcApp.Core.Message request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DemoService</summary>
    public partial class DemoServiceClient : grpc::ClientBase<DemoServiceClient>
    {
      /// <summary>Creates a new client for DemoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DemoServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DemoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DemoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DemoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DemoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcApp.Core.Empty Send(global::GrpcApp.Core.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Send(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcApp.Core.Empty Send(global::GrpcApp.Core.Message request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Send, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcApp.Core.Empty> SendAsync(global::GrpcApp.Core.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcApp.Core.Empty> SendAsync(global::GrpcApp.Core.Message request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Send, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DemoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DemoServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DemoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Send, serviceImpl.Send).Build();
    }

  }
}
#endregion
