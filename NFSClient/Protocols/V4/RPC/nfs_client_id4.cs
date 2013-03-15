/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class nfs_client_id4 : XdrAble {
    public verifier4 verifier;
    public byte [] id;

    public nfs_client_id4() {
    }

    public nfs_client_id4(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeDynamicOpaque(id);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        id = xdr.xdrDecodeDynamicOpaque();
    }

}
} // End of nfs_client_id4.cs
