/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class BIND_CONN_TO_SESSION4resok : XdrAble
    {
        public sessionid4 bctsr_sessid;
        public int bctsr_dir;
        public bool bctsr_use_conn_in_rdma_mode;

        public BIND_CONN_TO_SESSION4resok()
        {
        }

        public BIND_CONN_TO_SESSION4resok(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt(bctsr_dir);
            xdr.xdrEncodeBoolean(bctsr_use_conn_in_rdma_mode);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            bctsr_dir = xdr.xdrDecodeInt();
            bctsr_use_conn_in_rdma_mode = xdr.xdrDecodeBoolean();
        }

    }
}
// End of BIND_CONN_TO_SESSION4resok.cs
