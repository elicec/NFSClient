/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class utf8str_cs : XdrAble {

    public utf8string value;

    public utf8str_cs() {
    }

    public utf8str_cs(utf8string value) {
        this.value = value;
    }

    public utf8str_cs(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = new utf8string(xdr);
    }

}
} // End of utf8str_cs.cs
