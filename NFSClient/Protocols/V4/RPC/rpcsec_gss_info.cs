/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class rpcsec_gss_info : XdrAble {
    public sec_oid4 oid;
    public qop4 qop;
    public int service;

    public rpcsec_gss_info() {
    }

    public rpcsec_gss_info(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        qop.xdrEncode(xdr);
        xdr.xdrEncodeInt(service);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        qop = new qop4(xdr);
        service = xdr.xdrDecodeInt();
    }

}
} // End of rpcsec_gss_info.cs
