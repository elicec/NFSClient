/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class fattr4_fh_expire_type : XdrAble {

    public int value;

    public fattr4_fh_expire_type() {
    }

    public fattr4_fh_expire_type(int value) {
        this.value = value;
    }

    public fattr4_fh_expire_type(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(value);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = xdr.xdrDecodeInt();
    }

}
} // End of  fattr4_fh_expire_type.cs
