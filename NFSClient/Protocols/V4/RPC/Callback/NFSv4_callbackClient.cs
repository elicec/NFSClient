/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC.Callback{
using org.acplt.oncrpc;

using System.Net;

/**
 * The class <code>NFSv4_callbackClient</code> implements the client stub proxy
 * for the NFS4_CALLBACK remote program. It provides method stubs
 * which, when called, in turn call the appropriate remote method (procedure).
 */
public class NFSv4_callbackClient : OncRpcClientStub {

    /**
     * Constructs a <code>NFSv4_callbackClient</code> client stub proxy object
     * from which the NFS4_CALLBACK remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv4_callbackClient(IPAddress host, int protocol) :         base(host, NFSv4_callback.NFS4_CALLBACK, 1, 0, protocol,true) {
    }

    /**
     * Constructs a <code>NFSv4_callbackClient</code> client stub proxy object
     * from which the NFS4_CALLBACK remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param port Port number at host where the remote program can be reached.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv4_callbackClient(IPAddress host, int port, int protocol) :        base(host, NFSv4_callback.NFS4_CALLBACK, 1, port, protocol,true) {
    }

    public NFSv4_callbackClient(IPAddress host,int protocol,bool useSecurePort)
        : base(host, NFSv4_callback.NFS4_CALLBACK, 1,0,protocol, useSecurePort)
    {
    }

    /**
     * Constructs a <code>NFSv4_callbackClient</code> client stub proxy object
     * from which the NFS4_CALLBACK remote program can be accessed.
     * @param client ONC/RPC client connection object implementing a particular
     *   protocol.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv4_callbackClient(OncRpcClient client) : base(client) {
    }

    /**
     * Constructs a <code>NFSv4_callbackClient</code> client stub proxy object
     * from which the NFS4_CALLBACK remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param program Remote program number.
     * @param version Remote program version number.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv4_callbackClient(IPAddress host, int program, int version, int protocol) :        base(host, program, version, 0, protocol,true) {
    }

    /**
     * Constructs a <code>NFSv4_callbackClient</code> client stub proxy object
     * from which the NFS4_CALLBACK remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param program Remote program number.
     * @param version Remote program version number.
     * @param port Port number at host where the remote program can be reached.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv4_callbackClient(IPAddress host, int program, int version, int port, int protocol) :        base(host, program, version, port, protocol,true) {
    }

    /**
     * Call remote procedure CB_NULL_1.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public void CB_NULL_1() {
        XdrVoid args_ = XdrVoid.XDR_VOID;
        XdrVoid result_ = XdrVoid.XDR_VOID;
        client.call(NFSv4_callback.CB_NULL_1, NFSv4_callback.NFS_CB, args_, result_);
    }

    /**
     * Call remote procedure CB_COMPOUND_1.
     * @param arg1 parameter (of type CB_COMPOUND4args) to the remote procedure call.
     * @return Result from remote procedure call (of type CB_COMPOUND4res).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public CB_COMPOUND4res CB_COMPOUND_1(CB_COMPOUND4args arg1) {
        CB_COMPOUND4res result_ = new CB_COMPOUND4res();
        client.call(NFSv4_callback.CB_COMPOUND_1, NFSv4_callback.NFS_CB, arg1, result_);
        return result_;
    }

}
} // End of NFSv4_callbackClient.cs
