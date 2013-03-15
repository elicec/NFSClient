/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class LAYOUTCOMMIT4res : XdrAble {
    public int locr_status;
    public LAYOUTCOMMIT4resok locr_resok4;

    public LAYOUTCOMMIT4res() {
    }

    public LAYOUTCOMMIT4res(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(locr_status);
        switch ( locr_status ) {
        case nfsstat4.NFS4_OK:
            locr_resok4.xdrEncode(xdr);
            break;
        default:
            break;
        }
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        locr_status = xdr.xdrDecodeInt();
        switch ( locr_status ) {
        case nfsstat4.NFS4_OK:
            locr_resok4 = new LAYOUTCOMMIT4resok(xdr);
            break;
        default:
            break;
        }
    }

}
} // End of LAYOUTCOMMIT4res.cs
