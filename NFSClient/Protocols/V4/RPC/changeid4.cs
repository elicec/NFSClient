/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class changeid4 : XdrAble
    {

    public uint64_t value;

    public changeid4() {
    }

    public changeid4(uint64_t value) {
        this.value = value;
    }

    public changeid4(XdrDecodingStream xdr)
     {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr)
    {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr)
    {
        value = new uint64_t(xdr);
    }

    }
}
// End of changeid4.cs
