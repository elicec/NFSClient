/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class open_claim_delegate_cur4 : XdrAble {
    public stateid4 delegate_stateid;
    public component4 file;


    public open_claim_delegate_cur4() {
    }

    public open_claim_delegate_cur4(XdrDecodingStream xdr)
    {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr)
    {
        delegate_stateid.xdrEncode(xdr);
        file.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr)
    {
        delegate_stateid = new stateid4(xdr);
        file = new component4(xdr);
    }

}
} // End of open_claim_delegate_cur4.cs
