/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class RECLAIM_COMPLETE4args : XdrAble {
    public bool rca_one_fs;

    public RECLAIM_COMPLETE4args() {
    }

    public RECLAIM_COMPLETE4args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeBoolean(rca_one_fs);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        rca_one_fs = xdr.xdrDecodeBoolean();
    }

}
} // End of RECLAIM_COMPLETE4args.cs
