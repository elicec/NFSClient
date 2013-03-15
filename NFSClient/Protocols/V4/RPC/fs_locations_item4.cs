/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class fs_locations_item4 : XdrAble {
    public fs_locations_server4 [] fli_entries;
    public pathname4 fli_rootpath;

    public fs_locations_item4() {
    }

    public fs_locations_item4(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        fli_rootpath.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        fli_rootpath = new pathname4(xdr);
    }

}
} // End of  fs_locations_item4.cs
