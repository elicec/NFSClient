/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class READDIR4resok : XdrAble {
    public verifier4 cookieverf;
    public dirlist4 reply;


    public READDIR4resok() {
    }

    public READDIR4resok(XdrDecodingStream xdr)
    {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr)
     {
        cookieverf.xdrEncode(xdr);
        reply.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr)
    {
        cookieverf = new verifier4(xdr);
        reply = new dirlist4(xdr);
    }

}
} // End of READDIR4resok.cs
