/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class channel_attrs4 : XdrAble
    {
    public count4 ca_headerpadsize;
    public count4 ca_maxrequestsize;
    public count4 ca_maxresponsesize;
    public count4 ca_maxresponsesize_cached;
    public count4 ca_maxoperations;
    public count4 ca_maxrequests;
    public uint32_t [] ca_rdma_ird;


    public channel_attrs4() {
    }

    public channel_attrs4(XdrDecodingStream xdr){
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr){
        ca_headerpadsize.xdrEncode(xdr);
        ca_maxrequestsize.xdrEncode(xdr);
        ca_maxresponsesize.xdrEncode(xdr);
        ca_maxresponsesize_cached.xdrEncode(xdr);
        ca_maxoperations.xdrEncode(xdr);
        ca_maxrequests.xdrEncode(xdr);
        { int size = ca_rdma_ird.Length; xdr.xdrEncodeInt(size); for ( int idx = 0; idx < size; ++idx ) { ca_rdma_ird[idx].xdrEncode(xdr); } }
    }

    public void xdrDecode(XdrDecodingStream xdr){
        ca_headerpadsize = new count4(xdr);
        ca_maxrequestsize = new count4(xdr);
        ca_maxresponsesize = new count4(xdr);
        ca_maxresponsesize_cached = new count4(xdr);
        ca_maxoperations = new count4(xdr);
        ca_maxrequests = new count4(xdr);
        { int size = xdr.xdrDecodeInt(); ca_rdma_ird = new uint32_t[size]; for ( int idx = 0; idx < size; ++idx ) { ca_rdma_ird[idx] = new uint32_t(xdr); } }
    }
    }
}
// End of channel_attrs4.cs
