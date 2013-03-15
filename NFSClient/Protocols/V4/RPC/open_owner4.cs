/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class open_owner4 : XdrAble {

    public state_owner4 value;

    public open_owner4() {
    }

    public open_owner4(state_owner4 value) {
        this.value = value;
    }

    public open_owner4(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = new state_owner4(xdr);
    }

}
} // End of open_owner4.cs
