/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class VERIFY4args : XdrAble {
    public fattr4 obj_attributes;

    public VERIFY4args() {
    }

    public VERIFY4args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
    }

    public void xdrDecode(XdrDecodingStream xdr) {
    }

}
} // End of VERIFY4args.cs
