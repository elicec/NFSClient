/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class sec_oid4 : XdrAble {

    public byte [] value;

    public sec_oid4() {
    }

    public sec_oid4(byte [] value) {
        this.value = value;
    }

    public sec_oid4(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeDynamicOpaque(value);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = xdr.xdrDecodeDynamicOpaque();
    }

}
} // End of sec_oid4.cs
