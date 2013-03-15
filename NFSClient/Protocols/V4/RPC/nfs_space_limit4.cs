/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class nfs_space_limit4 : XdrAble {
    public int limitby;
    public int filesize;
    public nfs_modified_limit4 mod_blocks;

    public nfs_space_limit4() {
    }

    public nfs_space_limit4(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(limitby);
        switch ( limitby ) {
        case limit_by4.NFS_LIMIT_SIZE:
            xdr.xdrEncodeInt(filesize);
            break;
        case limit_by4.NFS_LIMIT_BLOCKS:
            mod_blocks.xdrEncode(xdr);
            break;
        }
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        limitby = xdr.xdrDecodeInt();
        switch ( limitby ) {
        case limit_by4.NFS_LIMIT_SIZE:
            filesize = xdr.xdrDecodeInt();
            break;
        case limit_by4.NFS_LIMIT_BLOCKS:
            mod_blocks = new nfs_modified_limit4(xdr);
            break;
        }
    }

}
} // End of nfs_space_limit4.cs
