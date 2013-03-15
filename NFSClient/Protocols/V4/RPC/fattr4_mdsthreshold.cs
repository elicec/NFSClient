/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class fattr4_mdsthreshold : XdrAble {

    public mdsthreshold4 value;

    public fattr4_mdsthreshold() {
    }

    public fattr4_mdsthreshold(mdsthreshold4 value) {
        this.value = value;
    }

    public fattr4_mdsthreshold(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = new mdsthreshold4(xdr);
    }

}
} // End of  fattr4_mdsthreshold.cs
