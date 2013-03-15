/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class fattr4_supported_attrs : XdrAble {

    public bitmap4 value;

    public fattr4_supported_attrs() {
    }

    public fattr4_supported_attrs(bitmap4 value) {
        this.value = value;
    }

    public fattr4_supported_attrs(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = new bitmap4(xdr);
    }

}
} // End of  fattr4_supported_attrs.cs
