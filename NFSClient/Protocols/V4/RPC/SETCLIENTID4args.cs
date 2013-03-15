/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class SETCLIENTID4args : XdrAble {
    public nfs_client_id4 client;
    public cb_client4 callback;
    public int callback_ident;

    public SETCLIENTID4args() {
    }

    public SETCLIENTID4args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        callback.xdrEncode(xdr);
        xdr.xdrEncodeInt(callback_ident);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        callback = new cb_client4(xdr);
        callback_ident = xdr.xdrDecodeInt();
    }

}
} // End of SETCLIENTID4args.cs
