/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class fattr4_owner : XdrAble {

    public utf8str_mixed value;

    public fattr4_owner() {
    }

    public fattr4_owner(utf8str_mixed value) {
        this.value = value;
    }

    public fattr4_owner(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = new utf8str_mixed(xdr);
    }

}
} // End of  fattr4_owner.cs
