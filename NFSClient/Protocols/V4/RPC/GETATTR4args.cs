/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class GETATTR4args : XdrAble {
    public bitmap4 attr_request;


    public GETATTR4args() {
    }

    public GETATTR4args(XdrDecodingStream xdr)
    {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr)
    {
        attr_request.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr)
    {
        attr_request = new bitmap4(xdr);
    }

}
} // End of  GETATTR4args.cs
